using Rimelib.Shader.Frostbite2_0.Frostbite.Functions;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;
using RimeLib.Shader.Frostbite2_0.Frostbite.Solutions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite
{
    public class ShaderDB : IFbSerializable
    {
        public ShaderRenderPath m_ShaderPath;

        public ShaderConstantBlock[] m_Constants = new ShaderConstantBlock[0];
        public ShaderConstantFunction[] m_ConstantFunctions = new ShaderConstantFunction[0];
        public ShaderTextureFunction[] m_TextureFunctions = new ShaderTextureFunction[0];

        public VertexShaderPermutation[] m_VertexShaders = new VertexShaderPermutation[0];
        public PixelShaderPermutation[] m_PixelShaders = new PixelShaderPermutation[0];
        public GeometryShaderPermutation[] m_GeometryShaders = new GeometryShaderPermutation[0];


        public ShaderSolution[] m_Solutions = new ShaderSolution[0];


        public Dictionary<uint, SurfaceShaderInfo> m_IdMap = new Dictionary<uint, SurfaceShaderInfo>();

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


            m_ShaderPath = (ShaderRenderPath) p_Reader.ReadUInt32();

            // fb::DxShaderDatabase::loadShaderConstants
            {
                var s_Count = p_Reader.ReadUInt32();

                m_Constants = new ShaderConstantBlock[s_Count];

                for (var i = 0; i < s_Count; i++)
                {
                    //Size object included in size...
                    var s_Size = p_Reader.ReadUInt32() -4;

                    var s_CurrentPosition = p_Reader.Position;

                    using (var s_ConstantsReader = new LimitedRimeReader(p_Reader, s_Size))
                        m_Constants[i] = new ShaderConstantBlock(s_ConstantsReader);

                    p_Reader.Seek(s_CurrentPosition + s_Size, SeekOrigin.Begin);
                }
            }

            // fb::ShaderDatabase::loadConstantFunctions
            {
                var s_Count = p_Reader.ReadUInt32();

                m_ConstantFunctions = new ShaderConstantFunction[s_Count];

                for (var i = 0; i < s_Count; i++)
                    m_ConstantFunctions[i] = new ShaderConstantFunction(p_Reader);
            }

            // fb::ShaderDatabase::loadTextureFunctions
            {
                var s_Count = p_Reader.ReadUInt32();

                m_TextureFunctions = new ShaderTextureFunction[s_Count];

                for (var i = 0; i < s_Count; i++)
                    m_TextureFunctions[i] = new ShaderTextureFunction(p_Reader);
            }



            // fb::DxShaderDatabase::loadVertexShaderPermutations
            {
                var s_Count = p_Reader.ReadUInt32();

                m_VertexShaders = new VertexShaderPermutation[s_Count];

                for (var i = 0; i < s_Count; i++)
                    m_VertexShaders[i] = new VertexShaderPermutation(p_Reader);
            }

            // fb::DxShaderDatabase::loadPixelShaderPermutations
            {
                var s_Count = p_Reader.ReadUInt32();

                m_PixelShaders = new PixelShaderPermutation[s_Count];

                for (var i = 0; i < s_Count; i++)
                    m_PixelShaders[i] = new PixelShaderPermutation(p_Reader);
            }

            // fb::DxShaderDatabase::loadGeometryShaderPermutations
            {
                var s_Count = p_Reader.ReadUInt32();

                m_GeometryShaders = new GeometryShaderPermutation[s_Count];

                for (var i = 0; i < s_Count; i++)
                    m_GeometryShaders[i] = new GeometryShaderPermutation(p_Reader);
            }


            
            // fb::DxShaderDatabase::loadSolutions
            {
                var s_SolutionCount = p_Reader.ReadUInt32();

                m_Solutions = new ShaderSolution[s_SolutionCount];

                for (var i = 0; i < s_SolutionCount; i++)
                    m_Solutions[i] = new ShaderSolution(p_Reader);


                var s_SolutionStateCount = p_Reader.ReadUInt32();
                for (var i = 0; i < s_SolutionStateCount; i++)
                {
                    var s_ShaderSolutionState = new ShaderSolutionState(p_Reader);

                    // HASH CHECK | Fletcher32

                    // this should be a hash check iirc, but index should also work
                    if (i < m_Solutions.Length)
                        m_Solutions[i].m_State = s_ShaderSolutionState;
                }
            }


            // fb::DxShaderDatabase::loadGeometryDeclarations
            {
                var s_DeclarationCount = p_Reader.ReadUInt32();

                for (var i = 0; i < s_DeclarationCount; i++)
                {
                    var s_Hash = p_Reader.ReadUInt32();

                    //Not implimented, just seek over it
                    //This is fb::GeomertyDeclarationDesc, you can find this struct in Shader branch
                    p_Reader.Seek(0x4C, SeekOrigin.Current);
                }
            }

            // fb::ShaderDatabase::loadIdMaps
            {
                var s_ShaderCount = p_Reader.ReadUInt32();

                for (var i = 0; i < s_ShaderCount; i++)
                {
                    var s_Key = p_Reader.ReadUInt32(); //Shader path hash afaik
                    var s_Value = new SurfaceShaderInfo( p_Reader );

                    m_IdMap.Add(s_Key, s_Value);
                }
            }

        }

        public bool Serialize(out byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
    }
}
