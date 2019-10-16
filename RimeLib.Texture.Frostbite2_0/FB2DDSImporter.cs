using RimeLib.IO;
using RimeLib.Texture.DDS;
using RimeLib.Texture.Frostbite;
using RimeLib.Texture.Frostbite.DDS;
using RimeLib.Texture.Frostbite2_0.Engine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace RimeLib.Texture.Frostbite2_0
{
    public static class FB2DDSImporter
    {
        public static void LoadDDS(RimeReader p_Reader, out TextureHeader p_Header, out Stream p_Data)
        {
            var s_StartPosition = p_Reader.BaseStream.Position;

            var s_DDSHeader = new DDSHeader( p_Reader );

            p_Header = new TextureHeader();

            p_Header.Width = (short) s_DDSHeader.m_Width;
            p_Header.Height = (short) s_DDSHeader.m_Height;
            p_Header.Depth = (short) s_DDSHeader.m_Depth;


            if ((s_DDSHeader.m_Flags & DDSFlags.MipmapCount) != 0)
                p_Header.MipmapCount = (byte) s_DDSHeader.m_MipmapCount;


            //Make it work for some strange dds
            p_Reader.Seek(s_StartPosition + s_DDSHeader.m_Size, SeekOrigin.Begin);

            if ((s_DDSHeader.m_PixelFormat.m_Flags & DDSFormatFlags.FourCC) != 0 &&
                s_DDSHeader.m_PixelFormat.m_FourCC == DDSPixelFormat.s_DXExtFormat.m_FourCC) //This is a dx texture
            {
                var s_ExtendedHeader = new DDSDX10Header( p_Reader );

                //TODO: rgb formats, typeless formats!!
                var s_TextureFormat = DDSUtils.c_DDSDXFormatMap.Where( x => x.Value == s_ExtendedHeader.m_DxgiFormat ).Select( x => x.Key ).FirstOrDefault( );
                p_Header.Format = s_TextureFormat;


                //Read type from extendedheader
                if ((s_ExtendedHeader.m_MiscFlag & DDSMiscFlag1.TextureCube) != 0)
                {
                    p_Header.Type = TextureType.TextureType_Cube;

                    if (s_ExtendedHeader.m_ArraySize != 6)
                        throw new Exception("This cube is not a full cube");
                }
                else
                {
                    switch (s_ExtendedHeader.m_ResourceDimension)
                    {
                    case DDSResoruceDimension.Texture1D:
                        p_Header.Type = TextureType.TextureType_1D;
                        break;
                    case DDSResoruceDimension.Texture2D:
                        p_Header.Type = TextureType.TextureType_2D;
                        break;
                    case DDSResoruceDimension.Texture3D:
                        p_Header.Type = TextureType.TextureType_3D;
                        break;
                    }
                }

            }
            else
            {
                var s_TextureFormat = TextureFormat.TextureFormat_Unknown;

                foreach (var s_FormatPair in DDSUtils.c_DDSFormatMap)
                {
                    if (s_FormatPair.Value.m_RBitMask != s_DDSHeader.m_PixelFormat.m_RBitMask)
                        continue;
                    if (s_FormatPair.Value.m_GBitMask != s_DDSHeader.m_PixelFormat.m_GBitMask)
                        continue;
                    if (s_FormatPair.Value.m_BBitMask != s_DDSHeader.m_PixelFormat.m_BBitMask)
                        continue;
                    if (s_FormatPair.Value.m_ABitMask != s_DDSHeader.m_PixelFormat.m_ABitMask)
                        continue;

                    s_TextureFormat = s_FormatPair.Key;
                    Debug.WriteLine($"Found valid format {s_FormatPair.Key}");

                }

                if (s_TextureFormat == TextureFormat.TextureFormat_Unknown)
                    throw new Exception("Unsupported dds!");



                if ((s_DDSHeader.m_Caps & DDSCaps.Complex) != 0)
                    p_Header.Type = TextureType.TextureType_Cube;
                else if ((s_DDSHeader.m_Flags & DDSFlags.Depth) != 0)
                    p_Header.Type = TextureType.TextureType_3D;
                else if(s_DDSHeader.m_Height != 1)
                    p_Header.Type = TextureType.TextureType_2D;
                else
                    p_Header.Type = TextureType.TextureType_1D; //if the height is 1, load as texture1d

            }

            //TODO: Probably calculate texture size based off bitcount, will just use the input stream size for now
            p_Data = new LimitedRimeReader(p_Reader, p_Reader.BaseStream.Length - p_Reader.BaseStream.Position);
        }
    }
}
