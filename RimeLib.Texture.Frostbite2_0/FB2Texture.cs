using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Texture.Frostbite;

namespace RimeLib.Texture.Frostbite2_0
{
    public class FB2Texture : TextureBase
    {
        public FB2Texture(RimeReader p_Reader)
        {
            m_Texture = new Engine.TextureHeader(p_Reader);
        }

        public FB2Texture(TextureType p_Type, TextureFormat p_Format, uint p_Width, uint p_Height, uint p_MipmapCount, TextureFlags p_Flags = 0)
        {
            m_Texture = new Engine.TextureHeader();

            m_Texture.Type = p_Type;
            m_Texture.Format = p_Format;

            m_Texture.Width = (short) p_Width;
            m_Texture.Height = (short) p_Height;
            m_Texture.Depth = 1;

            m_Texture.Flags = p_Flags;

            m_Texture.MipmapCount = (byte) p_MipmapCount;


            this.GenerateMipmaps();
        }


        public Engine.TextureHeader m_Texture;


        public override bool IsTiled => false;

        public override uint TextureSize => m_Texture.MipmapChainSize;

        public override TextureType Type => m_Texture.Type;
        public override TextureFormat Format => m_Texture.Format;


        //Return -1 if invalid or not avalible

        public override TextureFlags Flags => m_Texture.Flags;

        public override uint Width => (uint)m_Texture.Width;

        public override uint Height => (uint)m_Texture.Height;


        public override uint Depth => (uint)m_Texture.Depth;

        public override uint MipmapCount => m_Texture.MipmapCount;

        public override bool SerializeHeaderData(Stream p_Header)
        {
            using var s_Writer = new RimeWriter(p_Header, Endianness.LittleEndian);

            return m_Texture.Serialize(s_Writer);
        }



        public override uint GetMipmapSize(uint p_MipmapIndex) => p_MipmapIndex < m_Texture.MipmapCount ? m_Texture.MipmapSizes[p_MipmapIndex] : 0;


        private void GenerateMipmaps()
        {
            m_Texture.MipmapSizes = new uint[m_Texture.MipmapCount];

            //Calculate mimap sizes and chain size
            var s_CurrentWidth = (uint) m_Texture.Width;
            var s_CurrentHeight = (uint) m_Texture.Width;

            //TODO: Cubemap, 3d textures?

            uint s_ChainSize = 0;

            for (var i = 0; i < m_Texture.MipmapCount; i++)
            {
                //TODO: Custom bpp for diffrnet formats!
                TextureUtils.ComputePitch(this.Format, s_CurrentWidth, s_CurrentHeight, out var _, out var s_SlicePitch);

                m_Texture.MipmapSizes[i] = s_SlicePitch;

                s_ChainSize += s_SlicePitch;

                s_CurrentWidth /= 2;
                s_CurrentHeight /= 2;

            }

            m_Texture.MipmapChainSize = s_ChainSize;
        }

    }
}
