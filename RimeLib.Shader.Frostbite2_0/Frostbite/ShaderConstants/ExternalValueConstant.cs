using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.ShaderConstants
{
    public class ExternalValueConstant : IFbSerializable
    {
        public string m_Name = string.Empty;

        public uint m_Handle = 0;
        public ushort m_Index = 0;
        public ushort m_ArraySize = 0;
        public byte m_Size = 0;
        public bool m_Required = false;

        public Vec4 m_DefaultValue = new Vec4();

        public ExternalValueConstant()
        {
        }

        public ExternalValueConstant(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
            p_Writer.Write(Encoding.ASCII.GetBytes(m_Name).Take(0x20).ToArray());

            p_Writer.Write(m_Handle);
            p_Writer.Write(m_Index);
            p_Writer.Write(m_ArraySize);
            p_Writer.Write(m_Size);
            p_Writer.Write(m_Required);


            p_Writer.Seek(2, System.IO.SeekOrigin.Current);

            //Vec4
            p_Writer.Write(m_DefaultValue.X);
            p_Writer.Write(m_DefaultValue.Y);
            p_Writer.Write(m_DefaultValue.Z);
            p_Writer.Write(m_DefaultValue.W);
        }

       

        public void Deserialize(RimeReader p_Reader)
        {
            m_Name = Encoding.UTF8.GetString(p_Reader.ReadBytes(0x20));

            m_Handle = p_Reader.ReadUInt32();

            m_Index = p_Reader.ReadUInt16();

            m_ArraySize = p_Reader.ReadUInt16();

            m_Size = p_Reader.ReadUByte();
            m_Required = p_Reader.ReadBool();

            p_Reader.Seek(2, System.IO.SeekOrigin.Current);

            m_DefaultValue = new Vec4(p_Reader);
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
