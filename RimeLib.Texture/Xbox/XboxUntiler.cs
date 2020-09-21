using RimeLib.Texture.Frostbite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Texture.Xbox
{


    public class XboxUntiler
    {
        private static int XGLog2LE16(int p_TexelPitch) => (p_TexelPitch >> 2) + ((p_TexelPitch >> 1) >> (p_TexelPitch >> 2));

        public static long XGAddress2DTiledOffset(int p_X, int p_Y, int p_Width, int p_TexelPitch)
        {

            var s_AlignedWidth = p_Width % 32 != 0 ? p_Width + 32 - (p_Width % 32) : p_Width;

            var s_LogBpp = XGLog2LE16(p_TexelPitch);

            long s_Macro  = ((p_X >> 5) + (p_Y >> 5) * (s_AlignedWidth >> 5)) << (s_LogBpp + 7);

            long s_Micro  = (((p_X & 7) + ((p_Y & 6) << 2)) << s_LogBpp); //0xE = 6

            long s_Offset = s_Macro + ((s_Micro & 0xFFFFFFF0) << 1) + (s_Micro & 15) + ((p_Y & 8) << (3 + s_LogBpp)) + ((p_Y & 1) << 4);

            return (((s_Offset & 0xFFFFFE00) << 3) + ((s_Offset & 0x1C0) << 2) + (s_Offset & 0x3F) +
                    ((p_Y & 16) << 7) + (((((p_Y & 8) >> 2) + (p_X >> 3)) & 3) << 6)) >> s_LogBpp;
        }


        public static long XGAddress3DTiledOffset(int p_X, int p_Y, int p_Z, int p_Width, int p_Height, int p_TexelPitch)
        {

            var s_AlignedWidth = (p_Width + 31) & ~32;
            var s_AlignedHeight = (p_Height + 31) & ~32;

            var s_LogBpp = XGLog2LE16(p_TexelPitch);

            long s_Macro  = ((p_Z >> 2)*(s_AlignedHeight >> 4) + (p_Y >> 4))* (s_AlignedWidth >> 5) + (p_X >> 5);

            long s_Micro  = (((p_Y & 6) << 2) + (p_X & 7)) << s_LogBpp;

            long s_Offset1 = ((s_Macro << (8 + s_LogBpp)) + ((s_Micro & 0xFFFFFFF0) << 1) + (s_Micro & 0xF) + ((p_Z & 3) << (6 + s_LogBpp)) + ((p_Y & 1) << 4));
            long s_Offset2 = (((p_Z >> 2) + (p_Y >> 3)) & 1);

            return (((s_Offset1 & ~0x1FF) << 3) + ((s_Offset1 & 0x1C0) << 2) + (s_Offset1 & 0x3F) +
                    (s_Offset2 << 11) + ((((s_Offset2 << 1) + (p_X >> 3)) & 3) << 6)) >> s_LogBpp;
        }

        public static byte[]? GetUntiledTextureData(TextureBase p_Texture, bool p_BigEndian = true)
        {
            var s_Reader = p_Texture.Provider?.GetReader();

            if (s_Reader == null)
                return null;

            var s_Data = s_Reader.ReadBytes((int)p_Texture.TextureSize);

            var s_FormatInfo = XboxFormat.GetFormatInformation(p_Texture.Format);


            var s_BitsPerPixel = TextureUtils.BitsPerPixel(p_Texture.Format);

            // Div by 8 to get bytes-
            var s_BytesPerBlock = (s_BitsPerPixel * s_FormatInfo.m_BlockSizeX * s_FormatInfo.m_BlockSizeX)/8;

            var s_Endianess = 0;

            if (XboxFormat.c_EndianByteSize.TryGetValue(p_Texture.Format, out var s_TextureByteEndianess))
                s_Endianess = (int) s_TextureByteEndianess;



            var s_ResultArray = new byte[s_Data.Length];

            var s_CurrentOffset = 0;

            //var s_CurrentWidth = p_Texture.Width;
            //var s_CurrentHeight = p_Texture.Height;

            //Untiles current mipmap
            for (var i = 0; i < p_Texture.MipmapCount; i++)
            {
                var s_Width = p_Texture.Width / (uint) System.Math.Pow(2, i);
                var s_Height = p_Texture.Height / (uint) System.Math.Pow(2, i);

                uint s_BlockWidth = s_Width / s_FormatInfo.m_BlockSizeX;

                uint s_BlockHeight = s_Height / s_FormatInfo.m_BlockSizeY;

                uint s_StartXOffset = 0;

                //if ((s_BlockWidth >= s_OriginalBlockWidth * 2) && (s_CurrentWidth == 16))
                //    s_StartXOffset = s_OriginalBlockWidth;

                uint s_BlockCount = s_BlockWidth*s_BlockHeight;

                for (uint s_YBlock = 0; s_YBlock < s_BlockHeight; s_YBlock++)
                {
                    for (uint s_XBlock = 0; s_XBlock < s_BlockWidth; s_XBlock++)
                    {
                        var s_TileIndex = XGAddress2DTiledOffset((int) (s_XBlock + s_StartXOffset), (int) s_YBlock, (int) s_BlockWidth, (int) s_BytesPerBlock);

                        if (s_TileIndex > s_BlockCount)
                            //throw new Exception($"Tile is beyond texture: {s_TileIndex}");
                            continue;

                        //var s_TileX = s_TileIndex % s_TiledBlockWidth;
                        //var s_TileY = s_TileIndex / s_TiledBlockWidth;


                        var s_SourceOffset = s_CurrentOffset + s_TileIndex*s_BytesPerBlock;//(s_TileY*s_TiledBlockWidth + s_TileX)*s_BytesPerBlock;
                        var s_TargetOffset = s_CurrentOffset + (s_YBlock*s_BlockWidth + s_XBlock)*s_BytesPerBlock;

                        if (s_SourceOffset + s_BytesPerBlock > s_Data.Length ||
                            s_TargetOffset + s_BytesPerBlock > s_ResultArray.Length)
                            continue;

                        Array.ConstrainedCopy(s_Data, (int) s_SourceOffset, s_ResultArray, (int) s_TargetOffset, (int) s_BytesPerBlock);

                        if (p_BigEndian && s_Endianess != 0 && s_Endianess < s_BytesPerBlock)
                        {
                            for (var j = 0; j < s_BytesPerBlock / s_Endianess; j++)
                                Array.Reverse(s_ResultArray, (int) s_TargetOffset + (j * s_Endianess), s_Endianess);
                        }
                    }
                }

                //s_CurrentWidth /= 2;
                //s_CurrentHeight /= 2;
                s_CurrentOffset += (int) p_Texture.GetMipmapSize((uint) i);
            }

            return s_ResultArray;
        }
    }
}
