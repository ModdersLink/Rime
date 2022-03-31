using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Rimelib.Shader.Frostbite2_0.Frostbite.Functions
{
    public class ShaderConstantFunction : IFbSerializable
    {
        public class Constant : IFbSerializable
        {
            public uint m_Function = 0; //fb::ShaderConstantFunction
            public byte m_Index = 0;
            public byte m_Parameter = 0;
            public byte m_ArraySize = 0;
            public byte m_VectorCount = 0;

            public Constant()
            {
            }

            public Constant(RimeReader p_Reader)
            {
                Deserialize(p_Reader);
            }

            public bool Serialize(RimeWriter p_Writer)
            {
                p_Writer.Write((byte) m_Function);
                p_Writer.Write(m_Index);
                p_Writer.Write(m_Parameter);
                p_Writer.Write(m_ArraySize);
                p_Writer.Write(m_VectorCount);

                return true;
            }

            public void Deserialize(RimeReader p_Reader)
            {
                m_Function = p_Reader.ReadUInt32();
                m_Index = p_Reader.ReadUByte();
                m_Parameter = p_Reader.ReadUByte();
                m_ArraySize = p_Reader.ReadUByte();
                m_VectorCount = p_Reader.ReadUByte();

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

        public uint m_RegisterCount = 0;
        public Constant[] m_Constants = new Constant[0];

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShaderConstantFunction()
        {

        }

        /// <summary>
        /// TextureHeader Constructor
        /// This will read out the ITexture structure at an opened stream where the position is at a ITexture structure in the data
        /// </summary>
        /// <param name="p_Reader">Reference to an IceReader class</param>
        public ShaderConstantFunction(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write((short) m_Constants.Length);
            p_Writer.Write((short) m_RegisterCount);

            for (var i = 0; i < (short) m_Constants.Length; i++)
                m_Constants[i].Serialize(p_Writer);

            return true;
        }
                             
        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            p_Data = null;
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            var s_ContantsCount = p_Reader.ReadUInt16();

            m_RegisterCount = p_Reader.ReadUInt16();

            m_Constants = new Constant[s_ContantsCount];

            for (var i = 0; i < s_ContantsCount; i++)
                m_Constants[i] = new Constant(p_Reader);
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }

    }
}
