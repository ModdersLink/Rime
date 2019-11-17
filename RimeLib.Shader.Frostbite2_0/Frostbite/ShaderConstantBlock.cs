using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Shader.Frostbite2_0.Frostbite.ShaderConstants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite
{
    public class ShaderConstantBlock : IFbSerializable
    {
        public TextureConstant[] m_Textures = new TextureConstant[0];

        public ExternalValueConstant[] m_ExternalValues = new ExternalValueConstant[0];
        public ExternalTextureConstant[] m_ExternalTextures = new ExternalTextureConstant[0];

        public SamplerState[] m_Samplers = new SamplerState[0];

        public ShaderConstantBlock()
        {
        }

        public ShaderConstantBlock(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }
       

        public void Deserialize(RimeReader p_Reader)
        {
            var s_StartPosition = p_Reader.Position - 4; //4 bytes allready used...

            p_Reader.Seek(4, SeekOrigin.Current); //Pad

            var s_ValueConstantOffset = p_Reader.ReadUInt64();
            var s_TextureConstantOffset = p_Reader.ReadUInt64();

            var s_ExternalValueConstantOffset = p_Reader.ReadUInt64();
            var s_ExternalTextureConstantOffset = p_Reader.ReadUInt64();

            var s_SamplerStatesOffset = p_Reader.ReadUInt64();



            var s_ConstantCount = p_Reader.ReadUInt16();
            var s_ValueConstantsStart = p_Reader.ReadUInt16();


            var s_ValueConstantCount = p_Reader.ReadUByte();
            var s_TextureConstantCount = p_Reader.ReadUByte();
            var s_ExternalValueConstantCount = p_Reader.ReadUByte();
            var s_ExternalTextureConstantCount = p_Reader.ReadUByte();
            var s_SamplerStateCount = p_Reader.ReadUByte();


            if (s_ValueConstantCount > 0)
            {
                //TODO: Valueconstants is just a list of vector4s
                p_Reader.Seek(s_StartPosition + (long) s_ValueConstantOffset, SeekOrigin.Begin);
            }

            if (s_TextureConstantCount > 0)
            {
                p_Reader.Seek(s_StartPosition + (long) s_TextureConstantOffset, SeekOrigin.Begin);

                m_Textures = new TextureConstant[s_TextureConstantCount];

                for (var i = 0; i < s_TextureConstantCount; i++)
                    m_Textures[i] = new TextureConstant(p_Reader);
            }

            if (s_ExternalValueConstantCount > 0)
            {
                p_Reader.Seek(s_StartPosition + (long) s_ExternalValueConstantOffset, SeekOrigin.Begin);

                m_ExternalValues = new ExternalValueConstant[s_ExternalValueConstantCount];

                for (var i = 0; i < s_ExternalValueConstantCount; i++)
                    m_ExternalValues[i] = new ExternalValueConstant(p_Reader);
            }

            if (s_ExternalTextureConstantCount > 0)
            {
                p_Reader.Seek(s_StartPosition + (long) s_ExternalTextureConstantOffset, SeekOrigin.Begin);

                m_ExternalTextures = new ExternalTextureConstant[s_ExternalTextureConstantCount];

                for (var i = 0; i < s_ExternalTextureConstantCount; i++)
                    m_ExternalTextures[i] = new ExternalTextureConstant(p_Reader);
            }


            if (s_SamplerStateCount > 0)
            {
                p_Reader.Seek(s_StartPosition + (long) s_SamplerStatesOffset, SeekOrigin.Begin);

                m_Samplers = new SamplerState[s_SamplerStateCount];

                for (var i = 0; i < s_SamplerStateCount; i++)
                    m_Samplers[i] = new SamplerState(p_Reader);
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
