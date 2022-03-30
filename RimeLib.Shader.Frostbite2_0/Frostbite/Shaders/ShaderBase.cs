using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Shaders
{
    public class ShaderBase
    {
        public GUID m_Guid = GUID.Empty;
        public byte[] m_ShaderData = new byte[0];
        public uint m_Metrics = 0;
    }
}
