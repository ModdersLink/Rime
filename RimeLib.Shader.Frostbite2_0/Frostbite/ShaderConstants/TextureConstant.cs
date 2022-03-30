using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.ShaderConstants
{
    public class TextureConstant : IFbSerializable
    {
        public byte m_Index = 0;
        public byte m_TextureType = 0; //TODO: Texturetype from rimelib
        public string m_Name = string.Empty;

        public TextureConstant()
        {

        }

        public TextureConstant(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            m_Index = p_Reader.ReadUByte();
            m_TextureType = p_Reader.ReadUByte();

            p_Reader.Seek(0x6, SeekOrigin.Current); 

            m_Name = Encoding.UTF8.GetString(p_Reader.ReadBytes(0x80));

            p_Reader.Seek(0x10, SeekOrigin.Current); //This is moved to the previous pad in newer shaderdbs
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
