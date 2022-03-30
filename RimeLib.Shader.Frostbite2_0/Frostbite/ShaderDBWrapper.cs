using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite
{
    //This loads the actual binary, a shaderdb can have multiple graphics backends.
    public class ShaderDBWrapper : IFbSerializable
    {
        public Dictionary<ShaderRenderPath, ShaderDB> m_Shaders = new Dictionary<ShaderRenderPath, ShaderDB>();

        public ShaderDBWrapper()
        {
        }

        public ShaderDBWrapper(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }

      
        public void Deserialize(RimeReader p_Reader)
        {
            var s_ShaderRenderPaths = p_Reader.ReadUInt32();


            for (var i = 0; i < s_ShaderRenderPaths; i++)
            {
                var s_ShaderPath = p_Reader.ReadUInt32();
                var s_ShaderDbSize = p_Reader.ReadUInt32();

                var s_CurrentPosition = p_Reader.BaseStream.Position;

                using (var s_LimitedStream = new LimitedRimeReader(p_Reader, s_ShaderDbSize))
                    m_Shaders.Add((ShaderRenderPath) s_ShaderPath, new ShaderDB(s_LimitedStream));
                //m_Shaders.Add(s_ShaderPath, new ShaderDB(p_Reader));


                p_Reader.Seek(s_CurrentPosition + s_ShaderDbSize, SeekOrigin.Begin);
            }
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
