using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Serialization;
using RimeLib.Shader.Frostbite2_0.Frostbite.Functions;
using RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;
using RimeLib.Shader.Frostbite2_0.Frostbite.Solutions;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

/// <summary>
/// One render path's shader database (version 182). Its records are pooled: constant blocks,
/// constant and texture function blocks, then one pool per shader stage and the solutions, each a
/// count then the records; then a state per solution, the geometry declarations and the shader
/// table. Records name each other by index; after reading, the referenced records are also filled
/// in, and writing uses the indices.
/// </summary>
public class ShaderDatabase : IFbSerializable
{
    public virtual uint Version => 182;

    public ShaderRenderPath RenderPath { get; set; }

    public List<ShaderConstant> Constants { get; set; } = new();
    public List<ShaderConstantFunctionData> ConstantFunctions { get; set; } = new();
    public List<ShaderTextureFunctionData> TextureFunctions { get; set; } = new();
    public List<VertexShaderPermutation> VertexPermutations { get; set; } = new();
    public List<PixelShaderPermutation> PixelPermutations { get; set; } = new();
    public List<GeometryShaderPermutation> GeometryPermutations { get; set; } = new();
    public List<ShaderSolution> Solutions { get; set; } = new();
    public List<ShaderGeometryDeclaration> Declarations { get; set; } = new();

    /// <summary>The shader table in file order.</summary>
    public List<SurfaceShaderInfo> ShaderInfos { get; set; } = new();

    /// <summary>The shader table by shader asset name, once <see cref="ResolveNames"/> has run.</summary>
    public Dictionary<string, SurfaceShaderInfo> Shaders { get; } = new();

    public ShaderDatabase()
    {
    }

    public ShaderDatabase(RimeReader p_Reader, IEngineMounter p_Mounter)
    {
        Deserialize(p_Reader);
        ResolveNames(p_Mounter);
    }

    protected virtual ShaderSolution CreateSolution() => new();
    protected virtual ShaderSolutionState CreateSolutionState() => new();
    protected virtual VertexShaderPermutation CreateVertexPermutation() => new();
    protected virtual SurfaceShaderInfo CreateShaderInfo() => new();

    /// <summary>A record of the same type as <paramref name="p_Record"/> with the same content.</summary>
    public static T Clone<T>(T p_Record) where T : IFbSerializable
    {
        p_Record.Serialize(out var s_Data);
        var s_Clone = (T)Activator.CreateInstance(p_Record.GetType())!;
        s_Clone.Deserialize(s_Data!);
        return s_Clone;
    }

    /// <summary>A database of the same version and render path, with nothing in it.</summary>
    public virtual ShaderDatabase CreateEmpty() => new() { RenderPath = RenderPath };

    protected static List<T> ReadPool<T>(RimeReader p_Reader, Func<T> p_Create) where T : IFbSerializable
    {
        var s_Count = p_Reader.ReadUInt32();
        var s_Pool = new List<T>((int)s_Count);
        for (var i = 0; i < s_Count; i++)
        {
            var s_Record = p_Create();
            s_Record.Deserialize(p_Reader);
            s_Pool.Add(s_Record);
        }

        return s_Pool;
    }

    protected static void WritePool<T>(RimeWriter p_Writer, List<T> p_Pool) where T : IFbSerializable
    {
        p_Writer.Write((uint)p_Pool.Count);
        foreach (var s_Record in p_Pool)
            s_Record.Serialize(p_Writer);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        var s_Version = p_Reader.ReadUInt32();
        if (s_Version != Version)
            throw new InvalidDataException($"Unsupported shader database version (expected {Version} got {s_Version}).");

        RenderPath = (ShaderRenderPath)p_Reader.ReadUInt32();
        DeserializeHeader(p_Reader);

        Constants = ReadPool(p_Reader, () => new ShaderConstant());
        ConstantFunctions = ReadPool(p_Reader, () => new ShaderConstantFunctionData());
        TextureFunctions = ReadPool(p_Reader, () => new ShaderTextureFunctionData());
        VertexPermutations = ReadPool(p_Reader, CreateVertexPermutation);
        PixelPermutations = ReadPool(p_Reader, () => new PixelShaderPermutation());
        GeometryPermutations = ReadPool(p_Reader, () => new GeometryShaderPermutation());
        DeserializeStagePools(p_Reader);
        Solutions = ReadPool(p_Reader, CreateSolution);

        var s_States = ReadPool(p_Reader, CreateSolutionState);
        if (s_States.Count != Solutions.Count)
            throw new InvalidDataException($"{s_States.Count} solution states for {Solutions.Count} solutions.");
        for (var i = 0; i < s_States.Count; i++)
            Solutions[i].State = s_States[i];

        Declarations = ReadPool(p_Reader, () => new ShaderGeometryDeclaration());
        ShaderInfos = ReadPool(p_Reader, CreateShaderInfo);

        Resolve();
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(Version);
        p_Writer.Write((uint)RenderPath);
        SerializeHeader(p_Writer);

        WritePool(p_Writer, Constants);
        WritePool(p_Writer, ConstantFunctions);
        WritePool(p_Writer, TextureFunctions);
        WritePool(p_Writer, VertexPermutations);
        WritePool(p_Writer, PixelPermutations);
        WritePool(p_Writer, GeometryPermutations);
        SerializeStagePools(p_Writer);
        WritePool(p_Writer, Solutions);

        p_Writer.Write((uint)Solutions.Count);
        foreach (var s_Solution in Solutions)
            s_Solution.State.Serialize(p_Writer);

        WritePool(p_Writer, Declarations);
        WritePool(p_Writer, ShaderInfos);
        return true;
    }

    /// <summary>What the header holds after the render path.</summary>
    protected virtual void DeserializeHeader(RimeReader p_Reader)
    {
    }

    protected virtual void SerializeHeader(RimeWriter p_Writer)
    {
    }

    /// <summary>The pools of the stages a later engine adds after the geometry shaders.</summary>
    protected virtual void DeserializeStagePools(RimeReader p_Reader)
    {
    }

    protected virtual void SerializeStagePools(RimeWriter p_Writer)
    {
    }

    protected static T? At<T>(List<T> p_Pool, long p_Index) where T : class => p_Index == -1 ? null : p_Pool[(int)p_Index];

    /// <summary>Fills in the records each record names by index.</summary>
    public virtual void Resolve()
    {
        foreach (var s_Permutation in VertexPermutations)
            ResolvePermutation(s_Permutation);
        foreach (var s_Permutation in PixelPermutations)
            ResolvePermutation(s_Permutation);

        foreach (var s_Solution in Solutions)
        {
            s_Solution.VertexPermutation = At(VertexPermutations, s_Solution.VertexPermutationIndex);
            s_Solution.PixelPermutation = At(PixelPermutations, s_Solution.PixelPermutationIndex);
            s_Solution.GeometryPermutation = At(GeometryPermutations, s_Solution.GeometryPermutationIndex);
            s_Solution.VertexConstants = At(Constants, s_Solution.VertexConstantsIndex);
            s_Solution.PixelConstants = At(Constants, s_Solution.PixelConstantsIndex);
        }

        foreach (var s_Declaration in Declarations)
        foreach (var s_Solution in Solutions)
            if (s_Solution.State.GeometryDeclarationHash == s_Declaration.Hash)
                s_Solution.State.GeometryDeclarationDesc = s_Declaration.Desc;

        foreach (var s_Info in ShaderInfos)
        {
            s_Info.Solutions = s_Info.SolutionIndices.ConvertAll(p_I => Solutions[p_I]).ToArray();
            s_Info.SolutionMap.Clear();
            foreach (var s_Solution in s_Info.Solutions)
                s_Info.SolutionMap.Add(s_Solution.StateHash, s_Solution);
        }
    }

    protected void ResolvePermutation(ShaderPermutation p_Permutation)
    {
        p_Permutation.Constant = Constants[p_Permutation.ConstantIndex];
        p_Permutation.ConstantFunction = ConstantFunctions[p_Permutation.ConstantFunctionIndex];
        p_Permutation.TextureFunction = TextureFunctions[p_Permutation.TextureFunctionIndex];
    }

    /// <summary>
    /// Names the shader table by the shader assets its keys hash: each shader's partition is read
    /// for its asset's name, which keeps the case the partition names lose.
    /// </summary>
    public void ResolveNames(IEngineMounter p_Mounter)
    {
        Shaders.Clear();
        var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(p_Mounter.GetEngineType());
        foreach (var s_Info in ShaderInfos)
        {
            if (!p_Mounter.TryGetPartitionByHashLower(s_Info.Key, out var s_PartitionObject))
                throw new InvalidDataException($"Could not find partition for shader asset with hash '{s_Info.Key}'. Is the appropriate content mounted?");

            var s_Partition = s_Converter.FromPartitionObject(s_PartitionObject.OriginalName, s_PartitionObject.FirstVariant);
            if (ShaderAssetName(s_Partition.PrimaryInstance) is not { } s_Name)
                throw new InvalidDataException($"Primary instance of shader asset partition '{s_Partition.Name}' is not a SurfaceShaderBaseAsset.");

            s_Info.NameHash = RimeLib.Frostbite.Utils.HashQuick(s_Name);
            Shaders.Add(s_Name, s_Info);
        }
    }

    /// <summary>The name of a shader partition's primary instance, null when it is no surface shader asset.</summary>
    protected virtual string? ShaderAssetName(DataContainerBase? p_Primary) => (p_Primary as SurfaceShaderBaseAsset)?.Name;

    /// <summary>Each pool's name and record count, in file order.</summary>
    public virtual IEnumerable<(string Name, int Count)> PoolCounts()
    {
        yield return ("constants", Constants.Count);
        yield return ("constant functions", ConstantFunctions.Count);
        yield return ("texture functions", TextureFunctions.Count);
        yield return ("vertex permutations", VertexPermutations.Count);
        yield return ("pixel permutations", PixelPermutations.Count);
        yield return ("geometry permutations", GeometryPermutations.Count);
        yield return ("solutions", Solutions.Count);
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
            Serialize(s_Writer);

        p_Data = s_Stream.ToArray();
        return true;
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        Deserialize(s_Reader);
        if (s_Reader.Position != p_Data.Length)
            throw new InvalidDataException($"A {p_Data.Length} byte shader database ends after {s_Reader.Position} bytes.");
    }
}
