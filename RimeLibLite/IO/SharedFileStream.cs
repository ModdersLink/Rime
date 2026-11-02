using System;
using System.Collections.Concurrent;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace RimeLib.IO
{
    /// <summary>
    /// A read-only stream over a file that stays open for the process and is shared by every stream
    /// on it. Opening a file per read takes and releases a file lock each time, which serializes
    /// threads reading the same archive; positioned reads on one handle do not.
    /// </summary>
    public sealed class SharedFileStream : Stream
    {
        private static readonly ConcurrentDictionary<string, SafeFileHandle> s_Handles = new(StringComparer.Ordinal);

        private readonly SafeFileHandle m_Handle;
        private readonly long m_Length;
        private long m_Position;

        private SharedFileStream(SafeFileHandle p_Handle)
        {
            m_Handle = p_Handle;
            m_Length = RandomAccess.GetLength(p_Handle);
        }

        /// <summary>A buffered stream at the start of the file.</summary>
        public static Stream Open(string p_Path)
        {
            var s_Handle = s_Handles.GetOrAdd(Path.GetFullPath(p_Path), p_P => File.OpenHandle(p_P, FileMode.Open, FileAccess.Read, FileShare.Read));
            return new BufferedStream(new SharedFileStream(s_Handle), 4096);
        }

        public override bool CanRead => true;
        public override bool CanSeek => true;
        public override bool CanWrite => false;
        public override long Length => m_Length;

        public override long Position
        {
            get => m_Position;
            set => m_Position = value;
        }

        public override int Read(byte[] p_Buffer, int p_Offset, int p_Count) => Read(p_Buffer.AsSpan(p_Offset, p_Count));

        public override int Read(Span<byte> p_Buffer)
        {
            var s_Read = RandomAccess.Read(m_Handle, p_Buffer, m_Position);
            m_Position += s_Read;
            return s_Read;
        }

        public override long Seek(long p_Offset, SeekOrigin p_Origin)
        {
            m_Position = p_Origin switch
            {
                SeekOrigin.Begin => p_Offset,
                SeekOrigin.Current => m_Position + p_Offset,
                _ => m_Length + p_Offset,
            };
            return m_Position;
        }

        public override void Flush()
        {
        }

        public override void SetLength(long p_Value) => throw new NotSupportedException();

        public override void Write(byte[] p_Buffer, int p_Offset, int p_Count) => throw new NotSupportedException();
    }
}
