using RimeLib.IO;
using RimeLib.IO.Conversion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Texture.Frostbite2_0
{
    class FB2Ps3Texture : FB2Texture
    {
        public FB2Ps3Texture(RimeReader p_Reader)
            : base(p_Reader)
        {
        }

        public override bool SerializeHeaderData(Stream p_Header)
        {
            using var s_Writer = new RimeWriter(p_Header, Endianness.BigEndian);

            return m_Texture.Serialize(s_Writer);
        }
    }
}
