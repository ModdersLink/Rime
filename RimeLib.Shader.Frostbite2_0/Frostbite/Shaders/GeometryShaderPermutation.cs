using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Shaders
{
    public class GeometryShaderPermutation : ShaderBase, IFbSerializable
    {
        public GeometryShaderPermutation()
        {
        }

        public GeometryShaderPermutation(RimeReader p_Reader)
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

            m_Metrics = p_Reader.ReadUInt32();
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
