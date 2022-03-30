using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Rimelib.Shader.Frostbite2_0.Frostbite.Functions
{
    public class ShaderTextureFunction : IFbSerializable
    {
        public class Texture : IFbSerializable
        {
            public byte m_Function = 0; //fb::ShaderConstantFunction
            public byte m_ValueType = 0;
            public byte m_Index = 0;
            public byte m_Parameter = 0;

            public Texture()
            {

            }
            public Texture(RimeReader p_Reader)
            {
                Deserialize(p_Reader);
            }

            public bool Serialize(RimeWriter p_Writer)
            {
                p_Writer.Write((byte) m_Function);
                p_Writer.Write(m_ValueType);
                p_Writer.Write(m_Parameter);
                p_Writer.Write(m_Index);
                p_Writer.Write(m_Parameter);

                return true;
            }

            public void Deserialize(RimeReader p_Reader)
            {
                m_Function = p_Reader.ReadUByte();
                m_ValueType = p_Reader.ReadUByte();
                m_Index = p_Reader.ReadUByte();
                m_Parameter = p_Reader.ReadUByte();
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

            
        };

        public Texture[] m_Textures = new Texture[0];

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShaderTextureFunction()
        {

        }

        /// <summary>
        /// TextureHeader Constructor
        /// This will read out the ITexture structure at an opened stream where the position is at a ITexture structure in the data
        /// </summary>
        /// <param name="p_Reader">Reference to an IceReader class</param>
        public ShaderTextureFunction(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write((uint) m_Textures.Length);

            for (var i = 0; i < m_Textures.Length; i++)
                m_Textures[i].Serialize(p_Writer);

            return true;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            var s_TextureCount = p_Reader.ReadUInt32();

            m_Textures = new Texture[s_TextureCount];

            for (var i = 0; i < s_TextureCount; i++)
                m_Textures[i] = new Texture(p_Reader);
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
}
