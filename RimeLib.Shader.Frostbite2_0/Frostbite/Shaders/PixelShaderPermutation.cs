using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Shaders
{
    public class PixelShaderPermutation : ShaderBase, IFbSerializable
    {

        public uint m_ConstantsIndex = 0;
        public uint m_ConstantFunctionIndex = 0;
        public uint m_TextureFunctionIndex = 0;

        public PixelShaderPermutation()
        {
        }

        public PixelShaderPermutation(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            m_Guid = new GUID(p_Reader);


            var s_DataSize = p_Reader.ReadUInt32();
            m_ShaderData = p_Reader.ReadBytes((int) s_DataSize);


            m_ConstantsIndex = p_Reader.ReadUInt32();
            m_ConstantFunctionIndex = p_Reader.ReadUInt32();
            m_TextureFunctionIndex = p_Reader.ReadUInt32();

            m_Metrics = p_Reader.ReadUInt32();
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
