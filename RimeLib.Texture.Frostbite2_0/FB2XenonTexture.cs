using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Texture.Frostbite2_0
{
    class FB2XenonTexture : FB2Texture
    {
        public FB2XenonTexture(RimeReader p_Reader)
            : base(p_Reader)
        {
        }

        public override bool IsTiled => true;


        public override bool SerializeHeaderData(Stream p_Header)
        {
            using var s_Writer = new RimeWriter(p_Header, Endianness.BigEndian);

            return m_Texture.Serialize(s_Writer);
        }
    }
}
