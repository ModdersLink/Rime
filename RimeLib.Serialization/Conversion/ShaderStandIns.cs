using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization.Conversion;

/// <summary>The names of the parameters set on a surface shader, by kind.</summary>
public sealed record ShaderParameters(IReadOnlySet<string> Textures, IReadOnlySet<string> Vectors, IReadOnlySet<string> Bools)
{
    public static ShaderParameters Of(IEnumerable<string> p_Textures, IEnumerable<string> p_Vectors, IEnumerable<string> p_Bools) =>
        new(p_Textures.ToHashSet(StringComparer.Ordinal), p_Vectors.ToHashSet(StringComparer.Ordinal), p_Bools.ToHashSet(StringComparer.Ordinal));

    public ShaderParameters Union(ShaderParameters p_Other) =>
        Of(Textures.Union(p_Other.Textures), Vectors.Union(p_Other.Vectors), Bools.Union(p_Other.Bools));

    /// <summary>
    /// How alike two parameter sets are, from 0 to 1: the shared names over all names, with a
    /// texture counting <see cref="TextureWeight"/> times, as the textures decide most of the look.
    /// </summary>
    public double Similarity(ShaderParameters p_Other)
    {
        var s_Shared = TextureWeight * Textures.Intersect(p_Other.Textures).Count()
            + Vectors.Intersect(p_Other.Vectors).Count() + Bools.Intersect(p_Other.Bools).Count();
        var s_All = TextureWeight * Textures.Union(p_Other.Textures).Count()
            + Vectors.Union(p_Other.Vectors).Count() + Bools.Union(p_Other.Bools).Count();
        return s_All == 0 ? 0 : (double)s_Shared / s_All;
    }

    public const int TextureWeight = 3;
}

/// <summary>A reference to an instance: its partition and its GUID.</summary>
public sealed record InstanceRef(GUID Partition, GUID Instance);

/// <summary>A mesh material, the surface shader it uses and the parameters it sets inline.</summary>
public sealed record MaterialBinding(InstanceRef Material, InstanceRef Shader, ShaderParameters Parameters);

/// <summary>A shader of the target and the parameters its materials set, which it is taken to take.</summary>
public sealed record ShaderStandIn(InstanceRef Shader, ShaderParameters Takes, double Similarity);

/// <summary>
/// The surface shaders of mesh materials, each with the parameters its materials set: inline,
/// and the textures mesh variation database entries bind to them.
/// </summary>
public sealed class MaterialShaders
{
    private readonly List<MaterialBinding> m_Materials = new();
    private readonly Dictionary<InstanceRef, HashSet<string>> m_VariationTextures = new();

    public void Add(IShaderBindings p_Bindings, DatabasePartitionBase p_Partition)
    {
        m_Materials.AddRange(p_Bindings.Materials(p_Partition));
        foreach (var (s_Material, s_Textures) in p_Bindings.VariationTextures(p_Partition))
        {
            if (!m_VariationTextures.TryGetValue(s_Material, out var s_Known))
                m_VariationTextures[s_Material] = s_Known = new HashSet<string>(StringComparer.Ordinal);
            s_Known.UnionWith(s_Textures);
        }
    }

    /// <summary>Each shader with the parameters its materials set and how many materials use it.</summary>
    public IReadOnlyDictionary<InstanceRef, (ShaderParameters Parameters, int Materials)> ByShader()
    {
        var s_Shaders = new Dictionary<InstanceRef, (ShaderParameters Parameters, int Materials)>();
        foreach (var s_Material in m_Materials)
        {
            var s_Parameters = m_VariationTextures.TryGetValue(s_Material.Material, out var s_Textures)
                ? s_Material.Parameters.Union(ShaderParameters.Of(s_Textures, [], []))
                : s_Material.Parameters;
            s_Shaders[s_Material.Shader] = s_Shaders.TryGetValue(s_Material.Shader, out var s_Known)
                ? (s_Known.Parameters.Union(s_Parameters), s_Known.Materials + 1)
                : (s_Parameters, 1);
        }

        return s_Shaders;
    }
}

/// <summary>Picks, for a shader of another engine, the most similar of an engine's own shaders.</summary>
public sealed class ShaderStandIns
{
    private readonly IReadOnlyDictionary<InstanceRef, (ShaderParameters Parameters, int Materials)> m_Shaders;

    /// <param name="p_Shaders">The engine's own shaders, from <see cref="MaterialShaders.ByShader"/>.</param>
    public ShaderStandIns(IReadOnlyDictionary<InstanceRef, (ShaderParameters Parameters, int Materials)> p_Shaders)
    {
        m_Shaders = p_Shaders;
    }

    public int Count => m_Shaders.Count;

    /// <summary>
    /// The shader whose parameters are most like <paramref name="p_Parameters"/>, the more used one
    /// of equally alike ones; none when no shader shares a parameter name.
    /// </summary>
    public ShaderStandIn? Choose(ShaderParameters p_Parameters) => Choose(p_Parameters, _ => 0L);

    /// <summary>The shaders that can stand in.</summary>
    public IEnumerable<InstanceRef> Shaders => m_Shaders.Keys;

    /// <summary>One of the shaders as a stand-in for a shader of <paramref name="p_Parameters"/>; none if it is not one of them.</summary>
    public ShaderStandIn? Of(InstanceRef p_Shader, ShaderParameters p_Parameters) =>
        m_Shaders.TryGetValue(p_Shader, out var s_Shader)
            ? new ShaderStandIn(p_Shader, s_Shader.Parameters, p_Parameters.Similarity(s_Shader.Parameters))
            : null;

    /// <summary>
    /// Of the shaders nearly as alike to <paramref name="p_Parameters"/> as the most alike one (by
    /// at most <see cref="AlikeMargin"/> of its similarity less), the one that draws most, by
    /// <paramref name="p_Draws"/>, then the most alike, then the more used one; none when no shader
    /// shares a parameter name.
    /// </summary>
    public ShaderStandIn? Choose(ShaderParameters p_Parameters, Func<InstanceRef, long> p_Draws)
    {
        var s_Alike = m_Shaders
            .Select(p_S => (Shader: p_S.Key, p_S.Value.Parameters, p_S.Value.Materials, Similarity: p_Parameters.Similarity(p_S.Value.Parameters)))
            .Where(p_S => p_S.Similarity > 0)
            .ToList();
        if (s_Alike.Count == 0)
            return null;

        var s_Least = s_Alike.Max(p_S => p_S.Similarity) * (1 - AlikeMargin);
        var s_Best = s_Alike
            .Where(p_S => p_S.Similarity >= s_Least)
            .Select(p_S => (p_S.Shader, p_S.Parameters, p_S.Materials, p_S.Similarity, Draws: p_Draws(p_S.Shader)))
            .OrderByDescending(p_S => p_S.Draws)
            .ThenByDescending(p_S => p_S.Similarity)
            .ThenByDescending(p_S => p_S.Materials)
            .ThenBy(p_S => p_S.Shader.Partition)
            .First();

        return new ShaderStandIn(s_Best.Shader, s_Best.Parameters, s_Best.Similarity);
    }

    /// <summary>
    /// Of all the shaders, however little alike, the one that draws most by <paramref name="p_Draws"/>, then the
    /// most alike, then the more used one: for a shader none of the alike ones draws all of.
    /// </summary>
    public ShaderStandIn? ChooseDrawing(ShaderParameters p_Parameters, Func<InstanceRef, long> p_Draws)
    {
        if (m_Shaders.Count == 0)
            return null;

        var s_Best = m_Shaders
            .Select(p_S => (Shader: p_S.Key, p_S.Value.Parameters, p_S.Value.Materials, Similarity: p_Parameters.Similarity(p_S.Value.Parameters)))
            .Select(p_S => (p_S.Shader, p_S.Parameters, p_S.Materials, p_S.Similarity, Draws: p_Draws(p_S.Shader)))
            .OrderByDescending(p_S => p_S.Draws)
            .ThenByDescending(p_S => p_S.Similarity)
            .ThenByDescending(p_S => p_S.Materials)
            .ThenBy(p_S => p_S.Shader.Partition)
            .First();

        return new ShaderStandIn(s_Best.Shader, s_Best.Parameters, s_Best.Similarity);
    }

    /// <summary>
    /// The shader that takes the texture used by the most materials, as a plain stand-in for a
    /// shader no shader is alike to; none when no shader takes it.
    /// </summary>
    public ShaderStandIn? MostUsed(string p_Texture)
    {
        var s_Best = m_Shaders
            .Where(p_S => p_S.Value.Parameters.Textures.Contains(p_Texture))
            .OrderByDescending(p_S => p_S.Value.Materials)
            .ThenBy(p_S => p_S.Key.Partition)
            .FirstOrDefault();

        return s_Best.Key == null ? null : new ShaderStandIn(s_Best.Key, s_Best.Value.Parameters, 0);
    }

    /// <summary>How much less alike than the most alike shader one may be to be taken for drawing more.</summary>
    public const double AlikeMargin = 0.25;
}
