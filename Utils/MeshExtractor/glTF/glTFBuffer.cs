using System.IO;

namespace MeshExtractor.glTF
{
    public class glTFBuffer
    {
        public class BufferHeader
        {
            public uint Magic;
            public uint Version;
            public uint Length;

            public const uint c_Magic = 0x46546C67; // 'glTF'
            public const uint c_Version = 2;
            
        }

        private string m_Uri;
        private long m_ByteLength;

        public bool Exists => File.Exists(m_Uri);

        public glTFBuffer(string p_RelativePath)
        {
            if (!Exists)
                throw new FileNotFoundException();

            m_Uri = p_RelativePath;
            m_ByteLength = new FileInfo(m_Uri).Length;
        }
    }
}
