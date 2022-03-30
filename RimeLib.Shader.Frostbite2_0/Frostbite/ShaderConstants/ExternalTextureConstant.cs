using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.ShaderConstants
{
    public class ExternalTextureConstant : IFbSerializable
    {
        public string m_Name = string.Empty;

        public uint m_Handle = 0;
        public ushort m_Index = 0;
        public byte m_TextureType = 0; //TODO: Texturetype from rimelib
        public bool m_Required = false;

        public ExternalTextureConstant()
        {

        }

        public ExternalTextureConstant(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();

            p_Writer.Write(Encoding.ASCII.GetBytes(m_Name).Take(0x20).ToArray());

            p_Writer.Write(m_Handle);
            p_Writer.Write(m_Index);
            p_Writer.Write(m_TextureType);
            p_Writer.Write(m_Required);

            return true;
        }
        
        public void Deserialize(RimeReader p_Reader)
        {
            m_Name = Encoding.UTF8.GetString(p_Reader.ReadBytes(0x20));

            m_Handle = p_Reader.ReadUInt32();

            m_Index = p_Reader.ReadUInt16();

            m_TextureType = p_Reader.ReadUByte();
            m_Required = p_Reader.ReadBool(); 
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
