using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Texture
{
    public class MemoryTextureDataProvider : ITextureDataProvider
    {
        public MemoryTextureDataProvider(int p_Size = 0)
        {
            if (p_Size > 0)
                m_Stream = new MemoryStream(p_Size);
            else
                m_Stream = new MemoryStream();
        }
        protected MemoryStream m_Stream;

        public RimeReader? GetReader(object? p_Data)
        {
            return new RimeReader(m_Stream);
        }

        public RimeWriter? GetWriter(object? p_Data)
        {
            return new RimeWriter(m_Stream);
        }
    }
}
