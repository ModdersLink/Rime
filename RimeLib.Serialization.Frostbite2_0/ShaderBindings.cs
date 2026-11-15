using System;
using System.Collections.Generic;
using System.Linq;
using fb;
using RimeLib.Frostbite;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Serialization.Frostbite2_0;

/// <summary>
/// The shaders of Frostbite 2 mesh materials that set their shader inline; a vector array
/// parameter counts as a vector one.
/// </summary>
public class ShaderBindings : IShaderBindings
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0];

    public IEnumerable<MaterialBinding> Materials(DatabasePartitionBase p_Partition) =>
        InlineMaterials(p_Partition).Select(p_M => new MaterialBinding(
            new InstanceRef(p_Partition.PartitionGuid, ((DataContainerId.Guid)p_M.Container.InstanceId).Id), Ref(p_M.Shader.Shader), Parameters(p_M.Shader)));

    public IReadOnlyList<InstanceRef> MeshMaterials(DatabasePartitionBase p_Partition) =>
        p_Partition.PrimaryInstance is MeshAsset s_Mesh ? s_Mesh.Materials.Select(p_M => Ref(p_M)).ToList() : [];

    public IEnumerable<(InstanceRef Mesh, InstanceRef Material, InstanceRef Variation)> MaterialVariations(DatabasePartitionBase p_Partition) =>
        p_Partition.Instances.OfType<MeshVariationDatabaseEntry>()
            .Where(p_E => !p_E.Mesh.IsNull())
            .SelectMany(p_E => p_E.Materials
                .Where(p_M => !p_M.Material.IsNull() && !p_M.MaterialVariation.IsNull())
                .Select(p_M => (Ref(p_E.Mesh), Ref(p_M.Material), Ref(p_M.MaterialVariation))));

    public InstanceRef? VariationShader(DatabasePartitionBase p_Partition, InstanceRef p_Variation) =>
        p_Partition.Instances.OfType<MeshMaterialVariation>()
            .FirstOrDefault(p_V => p_V.InstanceId is DataContainerId.Guid s_Id && s_Id.Id == p_Variation.Instance) is { } s_Variation
            && !s_Variation.Shader.Shader.IsNull()
            ? Ref(s_Variation.Shader.Shader)
            : null;

    public IEnumerable<(InstanceRef Material, IEnumerable<string> Textures)> VariationTextures(DatabasePartitionBase p_Partition) =>
        p_Partition.Instances.OfType<MeshVariationDatabaseEntry>()
            .SelectMany(p_E => p_E.Materials)
            .Where(p_M => !p_M.Material.IsNull())
            .Select(p_M => (Ref(p_M.Material), p_M.TextureParameters.Select(p_P => p_P.ParameterName)));

    public IReadOnlyList<InstanceRef?> MeshShaders(DatabasePartitionBase p_Partition)
    {
        if (p_Partition.PrimaryInstance is not MeshAsset s_Mesh)
            return [];

        return s_Mesh.Materials.Select(p_Ref => p_Partition.Instances.OfType<MeshMaterial>()
                .FirstOrDefault(p_M => p_M.InstanceId.Equals(p_Ref.InstanceId)) is { } s_Material && !s_Material.Shader.Shader.IsNull()
                ? Ref(s_Material.Shader.Shader)
                : null)
            .ToList();
    }

    public IReadOnlyList<string> Rebind(DatabasePartitionBase p_Partition, IReadOnlyDictionary<InstanceRef, ShaderStandIn> p_StandIns)
    {
        var s_Dropped = new List<string>();
        foreach (var s_Material in InlineMaterials(p_Partition))
        {
            var s_Shader = s_Material.Shader;
            if (!p_StandIns.TryGetValue(Ref(s_Shader.Shader), out var s_StandIn))
                continue;

            s_Shader.Shader.SetValue(s_StandIn.Shader.Partition, new DataContainerId.Guid(s_StandIn.Shader.Instance));
            var s_Takes = s_StandIn.Takes;
            s_Dropped.AddRange(Drop(s_Shader.TextureParameters, p_P => p_P.ParameterName, s_Takes.Textures));
            s_Dropped.AddRange(Drop(s_Shader.VectorParameters, p_P => p_P.ParameterName, s_Takes.Vectors));
            s_Dropped.AddRange(Drop(s_Shader.VectorArrayParameters, p_P => p_P.ParameterName, s_Takes.Vectors));
            s_Dropped.AddRange(Drop(s_Shader.BoolParameters, p_P => p_P.ParameterName, s_Takes.Bools));
        }

        return s_Dropped;
    }

    /// <summary>The mesh materials and material variations of the partition that set their shader inline.</summary>
    private static IEnumerable<(DataContainer Container, SurfaceShaderInstanceDataStruct Shader)> InlineMaterials(DatabasePartitionBase p_Partition) =>
        p_Partition.Instances.OfType<MeshMaterial>().Select(p_M => ((DataContainer)p_M, p_M.Shader))
            .Concat(p_Partition.Instances.OfType<MeshMaterialVariation>().Select(p_V => ((DataContainer)p_V, p_V.Shader)))
            .Where(p_M => !p_M.Item2.Shader.IsNull());

    private static InstanceRef Ref(CtrRefBase p_Ref) =>
        new(p_Ref.PartitionGuid, PartitionConversion.InstanceGuid(p_Ref.PartitionGuid, p_Ref.InstanceId));

    private static ShaderParameters Parameters(SurfaceShaderInstanceDataStruct p_Shader) => ShaderParameters.Of(
        p_Shader.TextureParameters.Select(p_P => p_P.ParameterName),
        p_Shader.VectorParameters.Select(p_P => p_P.ParameterName).Concat(p_Shader.VectorArrayParameters.Select(p_P => p_P.ParameterName)),
        p_Shader.BoolParameters.Select(p_P => p_P.ParameterName));

    /// <summary>Removes the parameters whose name is not in <paramref name="p_Takes"/> and returns their names.</summary>
    private static IEnumerable<string> Drop<T>(List<T> p_Parameters, Func<T, string> p_Name, IReadOnlySet<string> p_Takes)
    {
        var s_Dropped = p_Parameters.Where(p_P => !p_Takes.Contains(p_Name(p_P))).ToList();
        p_Parameters.RemoveAll(s_Dropped.Contains);
        return s_Dropped.Select(p_Name);
    }
}
