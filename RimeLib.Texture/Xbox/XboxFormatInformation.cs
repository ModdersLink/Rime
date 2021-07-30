using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Texture.Xbox
{
    public class XboxFormatInformation
    {
        public XboxFormatInformation(uint p_BlockSizeX, uint p_BlockSizeY, uint p_AlignX=0, uint p_AlignY = 0)
        {
            m_BlockSizeX = p_BlockSizeX;
            m_BlockSizeY = p_BlockSizeY;

            m_AlignX = p_AlignX;
            m_AlignY = p_AlignY;

        }

        public uint m_BlockSizeX;
        public uint m_BlockSizeY;
        public uint m_AlignX;
        public uint m_AlignY;
    }
}
