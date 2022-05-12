using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;
using RimeLib.Shader.Frostbite2_0.Frostbite.Solutions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Mesh.Frostbite;
using RimeLib.Shader.Frostbite2_0.Frostbite.Functions;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

public class ShaderDB : IFbSerializable
{
    public ShaderRenderPath RenderPath { get; set; }

    public ShaderConstant[] Constants { get; set; } = Array.Empty<ShaderConstant>();
    public ShaderConstantFunctionData[] ConstantFunctions { get; set; } = Array.Empty<ShaderConstantFunctionData>();
    public ShaderTextureFunctionData[] TextureFunctions { get; set; } = Array.Empty<ShaderTextureFunctionData>();

    public VertexShaderPermutation[] VertexShaderPermutations { get; set; } = Array.Empty<VertexShaderPermutation>();
    public PixelShaderPermutation[] PixelShaderPermutations { get; set; } = Array.Empty<PixelShaderPermutation>();
    public GeometryShaderPermutation[] GeometryShaderPermutations { get; set; } = Array.Empty<GeometryShaderPermutation>();

    public ShaderSolution[] Solutions { get; set; } = Array.Empty<ShaderSolution>();

    public GeometryDeclarationDesc[] GeometryDeclarations { get; set; } = Array.Empty<GeometryDeclarationDesc>();

    public Dictionary<uint, SurfaceShaderInfo> IdMap { get; set; } = new();

    public ShaderDB()
    {
    }

    public ShaderDB(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        throw new System.NotImplementedException();
    }

    public void Deserialize(RimeReader p_Reader)
    {
        var s_Version = p_Reader.ReadUInt32();

        if (s_Version != 182) //This shaderdb reader should also work for version 179
            throw new Exception($"This shaderdb isnt up to date. {s_Version}");


        RenderPath = (ShaderRenderPath) p_Reader.ReadUInt32();

        // fb::DxShaderDatabase::loadShaderConstants
        {
            var s_Count = p_Reader.ReadUInt32();

            Constants = new ShaderConstant[s_Count];

            for (var i = 0; i < s_Count; i++)
            {
                //Size object included in size...
                var s_Size = p_Reader.ReadUInt32() -4;

                var s_CurrentPosition = p_Reader.Position;

                using (var s_ConstantsReader = new LimitedRimeReader(p_Reader, s_Size))
                    Constants[i] = new ShaderConstant(s_ConstantsReader);

                p_Reader.Seek(s_CurrentPosition + s_Size, SeekOrigin.Begin);
            }
        }

        // fb::ShaderDatabase::loadConstantFunctions
        {
            var s_Count = p_Reader.ReadUInt32();

            ConstantFunctions = new ShaderConstantFunctionData[s_Count];

            for (var i = 0; i < s_Count; i++)
                ConstantFunctions[i] = new ShaderConstantFunctionData(p_Reader);
        }

        // fb::ShaderDatabase::loadTextureFunctions
        {
            var s_Count = p_Reader.ReadUInt32();

            TextureFunctions = new ShaderTextureFunctionData[s_Count];

            for (var i = 0; i < s_Count; i++)
                TextureFunctions[i] = new ShaderTextureFunctionData(p_Reader);
        }



        // fb::DxShaderDatabase::loadVertexShaderPermutations
        {
            var s_Count = p_Reader.ReadUInt32();

            VertexShaderPermutations = new VertexShaderPermutation[s_Count];

            for (var i = 0; i < s_Count; i++)
                VertexShaderPermutations[i] = new VertexShaderPermutation(p_Reader);
        }

        // fb::DxShaderDatabase::loadPixelShaderPermutations
        {
            var s_Count = p_Reader.ReadUInt32();

            PixelShaderPermutations = new PixelShaderPermutation[s_Count];

            for (var i = 0; i < s_Count; i++)
                PixelShaderPermutations[i] = new PixelShaderPermutation(p_Reader);
        }

        // fb::DxShaderDatabase::loadGeometryShaderPermutations
        {
            var s_Count = p_Reader.ReadUInt32();

            GeometryShaderPermutations = new GeometryShaderPermutation[s_Count];

            for (var i = 0; i < s_Count; i++)
                GeometryShaderPermutations[i] = new GeometryShaderPermutation(p_Reader);
        }


            
        // fb::DxShaderDatabase::loadSolutions
        {
            var s_SolutionCount = p_Reader.ReadUInt32();

            Solutions = new ShaderSolution[s_SolutionCount];

            for (var i = 0; i < s_SolutionCount; i++)
                Solutions[i] = new ShaderSolution(p_Reader);


            var s_SolutionStateCount = p_Reader.ReadUInt32();
            for (var i = 0; i < s_SolutionStateCount; i++)
            {
                var s_ShaderSolutionState = new ShaderSolutionState(p_Reader);

                // HASH CHECK | Fletcher32

                // this should be a hash check iirc, but index should also work
                if (i < Solutions.Length)
                    Solutions[i].State = s_ShaderSolutionState;
            }
        }


        // fb::DxShaderDatabase::loadGeometryDeclarations
        {
            var s_DeclarationCount = p_Reader.ReadUInt32();

            GeometryDeclarations = new GeometryDeclarationDesc[s_DeclarationCount];
                
            for (var i = 0; i < s_DeclarationCount; i++)
            {
                var s_Hash = p_Reader.ReadUInt32();

                GeometryDeclarations[i] = new GeometryDeclarationDesc(p_Reader);
            }
        }

        // fb::ShaderDatabase::loadIdMaps
        {
            var s_ShaderCount = p_Reader.ReadUInt32();

            for (var i = 0; i < s_ShaderCount; i++)
            {
                var s_Key = p_Reader.ReadUInt32(); //Shader path hash afaik
                var s_Value = new SurfaceShaderInfo( p_Reader );

                IdMap.Add(s_Key, s_Value);
            }
        }

    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        p_Data = null;
        throw new System.NotImplementedException();
    }
        
    public void Deserialize(byte[] p_Data)
    {
        throw new System.NotImplementedException();
    }
}