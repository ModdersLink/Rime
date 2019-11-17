using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.ShaderConstants
{
    public class SamplerState : IFbSerializable
    {
        uint m_Index = 0;
        //D3D11_SAMPLER_DESC


        public SamplerState()
        {

        }

        public SamplerState(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }

        

        public void Deserialize(RimeReader p_Reader)
        {
            m_Index = p_Reader.ReadUInt32();

            p_Reader.Seek(0x34, SeekOrigin.Current); //D3D11_SAMPLER_DESC


            //Padding
            p_Reader.Seek(0x8, SeekOrigin.Current); 
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
