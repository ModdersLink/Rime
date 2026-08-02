using RimeLib.IO;
using RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;
using RimeLib.Shader.Frostbite2_0.Frostbite.Solutions;
using System;
using System.Collections.Generic;
using System.IO;
using fb;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Mesh.Frostbite;
using RimeLib.Serialization;
using RimeLib.Shader.Frostbite2_0.Frostbite.Functions;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

public class ShaderDatabase
{
    public ShaderRenderPath RenderPath { get; set; }
    public Dictionary<string, SurfaceShaderInfo> Shaders { get; set; } = new();
    public ShaderConstant[] Constants { get; private set; } = [];

    public ShaderDatabase()
    {
    }

    public ShaderDatabase(RimeReader p_Reader, IEngineMounter p_Mounter)
    {
        var s_Version = p_Reader.ReadUInt32();

        if (s_Version != 182)
            throw new Exception($"Unsupported shader database version (expected 182 got {s_Version}).");

        RenderPath = (ShaderRenderPath)p_Reader.ReadUInt32();

        //

        var s_ConstantsCount = p_Reader.ReadUInt32();
        Constants = new ShaderConstant[s_ConstantsCount];

        for (var i = 0; i < s_ConstantsCount; i++)
        {
            //Size object included in size...
            var s_Size = p_Reader.ReadUInt32() - 4;

            var s_CurrentPosition = p_Reader.Position;

            // The loop keeps reading from p_Reader afterwards, so the limited view must not own it.
            using (var s_ConstantsReader = new LimitedRimeReader(p_Reader, s_Size, false))
                Constants[i] = new ShaderConstant(s_ConstantsReader);

            p_Reader.Seek(s_CurrentPosition + s_Size, SeekOrigin.Begin);
        }

        //

        var s_ConstantFunctionsCount = p_Reader.ReadUInt32();
        var s_ConstantFunctions = new ShaderConstantFunctionData[s_ConstantFunctionsCount];

        for (var i = 0; i < s_ConstantFunctionsCount; i++)
            s_ConstantFunctions[i] = new ShaderConstantFunctionData(p_Reader);

        //

        var s_TextureFunctionCount = p_Reader.ReadUInt32();
        var s_TextureFunctions = new ShaderTextureFunctionData[s_TextureFunctionCount];

        for (var i = 0; i < s_TextureFunctionCount; i++)
            s_TextureFunctions[i] = new ShaderTextureFunctionData(p_Reader);

        //

        var s_VertexShaderPermutationsCount = p_Reader.ReadUInt32();
        var s_VertexShaderPermutations = new VertexShaderPermutation[s_VertexShaderPermutationsCount];

        for (var i = 0; i < s_VertexShaderPermutationsCount; i++)
        {
            s_VertexShaderPermutations[i] = new VertexShaderPermutation(
                p_Reader,
                Constants,
                s_ConstantFunctions,
                s_TextureFunctions
            );
        }

        //
        
        var s_PixelShaderPermutationsCount = p_Reader.ReadUInt32();
        var s_PixelShaderPermutations = new PixelShaderPermutation[s_PixelShaderPermutationsCount];

        for (var i = 0; i < s_PixelShaderPermutationsCount; i++)
        {
            s_PixelShaderPermutations[i] = new PixelShaderPermutation(
                p_Reader,
                Constants,
                s_ConstantFunctions,
                s_TextureFunctions
            );
        }

        //
       
        var s_GeometryShaderPermutationsCount = p_Reader.ReadUInt32();

        var s_GeometryShaderPermutations = new GeometryShaderPermutation[s_GeometryShaderPermutationsCount];

        for (var i = 0; i < s_GeometryShaderPermutationsCount; i++)
            s_GeometryShaderPermutations[i] = new GeometryShaderPermutation(p_Reader);

        //
        
        var s_SolutionCount = p_Reader.ReadUInt32();
        var s_Solutions = new ShaderSolution[s_SolutionCount];

        for (var i = 0; i < s_SolutionCount; i++)
        {
            s_Solutions[i] = new ShaderSolution(
                p_Reader,
                s_VertexShaderPermutations,
                s_PixelShaderPermutations,
                s_GeometryShaderPermutations,
                Constants
            );
        }

        //

        var s_SolutionStateCount = p_Reader.ReadUInt32();
        
        if (s_SolutionStateCount != s_SolutionCount)
            throw new Exception($"Solution state count doesn't match solution count (expected {s_SolutionCount} got {s_SolutionStateCount}). Is this shader database corrupted?");


        for (var i = 0; i < s_SolutionStateCount; i++)
        {
            var s_SolutionState = new ShaderSolutionState(p_Reader);

            if (s_Solutions[i].StateHash != s_SolutionState.Hash)
                throw new Exception($"Solution state hash doesnt match solution hash. (expected 0x{s_Solutions[i].StateHash:X016} got 0x{s_SolutionState.Hash:X016}). Is this shader database corrupted?");

            s_Solutions[i].State = s_SolutionState;
        }

        //
        
        var s_DeclarationCount = p_Reader.ReadUInt32();
            
        for (var i = 0; i < s_DeclarationCount; i++)
        {
            var s_Hash = p_Reader.ReadUInt32();
            var s_Desc = new GeometryDeclarationDesc(p_Reader);

            foreach (var s_Solution in s_Solutions)
                if (s_Solution.State.GeometryDeclarationHash == s_Hash)
                    s_Solution.State.GeometryDeclarationDesc = s_Desc;
        }

        //
        
        var s_ShaderCount = p_Reader.ReadUInt32();

        for (var i = 0; i < s_ShaderCount; i++)
        {
            var s_Key = p_Reader.ReadUInt32();
            
            if (!p_Mounter.TryGetPartitionByHashLower(s_Key, out var s_PartitionObject))
                throw new Exception($"Could not find partition for shader asset with hash '{s_Key}'. Is the appropriate content mounted?");

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(EngineType.Frostbite2_0);
            var s_Partition = s_Converter.FromPartitionObject(s_PartitionObject.OriginalName, s_PartitionObject.FirstVariant);
            
            if (s_Partition.PrimaryInstance is not SurfaceShaderBaseAsset s_Asset)
                throw new Exception($"Primary instance of shader asset partition '{s_Partition.Name}' is not a SurfaceShaderBaseAsset.");
            
            Shaders.Add(s_Asset.Name, new SurfaceShaderInfo(p_Reader, s_Solutions, RimeLib.Frostbite.Utils.HashQuick(s_Asset.Name)));
        }
    }
}