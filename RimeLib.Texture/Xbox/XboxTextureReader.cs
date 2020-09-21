using RimeLib.IO;
using RimeLib.Texture.Frostbite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Texture.Xbox
{
    public class XboxTextureReader : RimeReader
    {
        public override bool CanSeek => true;

        public override long Position => m_RealPosition;

        //public override long Length => m_OriginalSize;

        protected long m_RealPosition = 0;

        protected XboxFormatInformation? m_FormatInfo = null;
        protected uint m_Width = 0;
        protected uint m_Height = 0;

        protected uint m_BytesPerBlock =0;

        public XboxTextureReader(RimeReader p_Reader, uint p_Width, uint p_Height, uint p_BitsPerPixel, TextureFormat p_Format, bool p_ShouldDispose = true) :
            base(p_Reader, p_Reader.Endianness, p_ShouldDispose)
        {
            m_Width = p_Width;
            m_Height = p_Height;
            m_FormatInfo = XboxFormat.GetFormatInformation(p_Format);

            if (m_FormatInfo == null)
                throw new Exception("Invalid format!");


            m_BytesPerBlock = (p_BitsPerPixel * m_FormatInfo.m_BlockSizeX * m_FormatInfo.m_BlockSizeY) / 8;
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        /*
        public override long Seek(long p_Offset, SeekOrigin p_Origin)
        {
            if (m_FormatInfo == null)
                throw new Exception("XBOX format cannot be null!");

            //TODO: Mipmap info

            var s_YPos = (uint)p_Offset/m_Width;

            var s_XPos = (uint)p_Offset-s_YPos;

            var s_BlockWidth = m_Width / m_FormatInfo.m_BlockSizeX;


            var s_Offset = XboxUntiler.XGAddress2DTiledOffset(s_XPos, s_YPos, s_BlockWidth, );

            BaseStream.Seek(s_Offset, SeekOrigin.Begin);

            throw new NotSupportedException();
        }
        */

        protected override int ReadInternal(byte[] p_Data, int p_Index, int p_Count)
        {
            if (m_FormatInfo == null)
                throw new Exception("XBOX format cannot be null!");

            //TODO: Mipmaps, this assumes its all a single mipmap...



            if (p_Count < m_BytesPerBlock)
            {
                var s_YPos = m_RealPosition/m_Width;

                var s_XPos = m_RealPosition-s_YPos;

                var s_BlockWidth = m_Width / m_FormatInfo.m_BlockSizeX;


                var s_Offset = XboxUntiler.XGAddress2DTiledOffset((int) s_XPos, (int) s_YPos, (int) s_BlockWidth, (int) m_BytesPerBlock);

                BaseStream.Seek(s_Offset, SeekOrigin.Begin);

                var s_ReadCount = BaseStream.Read(p_Data, 0, p_Count);

                m_RealPosition += s_ReadCount;

                return s_ReadCount;
            }
            else
            {
                var s_Count = 0;

                var s_YPos = m_RealPosition / m_Width;

                var s_XPos = m_RealPosition - s_YPos;
                var s_BlockWidth = m_Width / m_FormatInfo.m_BlockSizeX;

                for (var i = 0; i < (p_Count / m_BytesPerBlock); i++)
                {
                    var s_Offset = XboxUntiler.XGAddress2DTiledOffset((int) s_XPos + i, (int) s_YPos, (int) s_BlockWidth, (int) m_BytesPerBlock);

                    BaseStream.Seek(s_Offset, SeekOrigin.Begin);

                    //TODO: Block offset
                    s_Count += BaseStream.Read(p_Data, i * (int)m_BytesPerBlock, (int)m_BytesPerBlock);
                }

                m_RealPosition += s_Count;

                return s_Count;
            }
        }
    }
}
