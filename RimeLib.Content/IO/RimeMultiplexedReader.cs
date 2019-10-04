using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.IO
{
    /// <summary>
    /// The Multiplexed Reader is designed specifically for providing
    /// read multiplexing in order to support bundle patches in FB2.0.
    /// </summary>
    public class RimeMultiplexedReader : RimeReader
    {
        public override long Position => m_Position;

        private long m_Position;
        private int m_Cursor;
        private long m_Remaining;
        private bool m_Dispose;

        private readonly RimeReader[] m_Buffers;

        private readonly List<DeltaBundleRun> m_Runs;

        public RimeMultiplexedReader(RimeReader p_PatchedReader, RimeReader p_BaseReader, Endianness p_Endianness, bool p_Dispose = false)
            : base(new MemoryStream(), p_Endianness)
        {
            m_Runs = new List<DeltaBundleRun>();
            m_Position = 0;
            m_Buffers = new [] { p_PatchedReader, p_BaseReader };
            m_Dispose = p_Dispose;

            ReadRuns();
        }

        public override void Dispose()
        {
            base.Dispose();

            if (!m_Dispose) 
                return;

            foreach (var s_Reader in m_Buffers)
                s_Reader.Dispose();
        }

        private void ReadRuns()
        {
            m_Cursor = 0;
            m_Remaining = 0;

            // Do we have enough data for reading the patch header?
            if (m_Buffers[0].BaseStream.Position + 16 > m_Buffers[0].BaseStream.Length)
                throw new Exception("Not enough data found to read patch header. This is probably caused because we tried to parse a non-patch file.");

            // Read the patch header.
            var s_RunsSize = m_Buffers[0].ReadInt32();
            var s_Magic = m_Buffers[0].ReadUInt32();
            m_Buffers[0].ReadUInt64(); // Padding

            // Perform some validation.
            if (m_Buffers[0].BaseStream.Position + s_RunsSize > m_Buffers[0].BaseStream.Length)
                throw new Exception("Not enough data found to read patch runs. This is probably caused because we tried to parse a non-patch file.");

            if (s_Magic != 0xDE17AAAA)
                throw new Exception("Failed to validate patch data header. This is probably caused because we tried to parse a non-patch file.");

            if (s_RunsSize % 16 != 0)
                throw new Exception("Read an invalid patch runs size. This is probably caused because we tried to parse a non-patch file.");

            // Calculate how many runs we have.
            var s_RunCount = s_RunsSize / 16;

            // Read out all the runs from the patch header.
            for (int i = 0; i < s_RunCount; ++i)
            {
                var s_Run = new DeltaBundleRun(m_Buffers[0]);
                m_Runs.Add(s_Run);

                m_Remaining += s_Run.CopyBytes;
            }

            if (s_RunCount > 0 && m_Runs[0].FileId == 1)
                m_Buffers[1].Seek((int)m_Runs[0].Offset, SeekOrigin.Begin);
        }

        public override void Seek(long p_Offset, SeekOrigin p_Origin)
        {
            CheckDisposed();

            if (p_Origin != SeekOrigin.Current)
                throw new Exception("Can only seek from current position in a Multiplexed Reader.");

            if (p_Offset < 0)
                throw new Exception("Multiplexed Reader can only seek forwards.");

            if (p_Offset >= int.MaxValue)
                throw new Exception($"Multiplexed Reader can only seek forwards up to {int.MaxValue} bytes at a time.");

            if (p_Offset == 0)
                return;

            var s_ToRead = (int) p_Offset;
            var s_Remaining = (int) p_Offset;

            while (s_Remaining > 0)
            {
                if (m_Remaining < s_ToRead)
                    throw new EndOfStreamException("End of stream reached with " + s_Remaining + " bytes left to skip.");

                // We don't have enough bytes in the current run.
                if (s_Remaining > m_Runs[m_Cursor].CopyBytes)
                    s_ToRead = m_Runs[m_Cursor].CopyBytes;
                else
                    s_ToRead = s_Remaining;

                m_Buffers[m_Runs[m_Cursor].FileId].Seek(s_ToRead, SeekOrigin.Current);

                m_Runs[m_Cursor].CopyBytes -= s_ToRead;
                s_Remaining -= s_ToRead;

                if (m_Runs[m_Cursor].CopyBytes != 0) 
                    continue;

                ++m_Cursor;

                if (m_Cursor < m_Runs.Count && m_Runs[m_Cursor].FileId == 1)
                    m_Buffers[1].Seek((int) m_Runs[m_Cursor].Offset, SeekOrigin.Begin);
            }

            m_Position += p_Offset;
        }
        
        protected override int ReadInternal(byte[] p_Data, int p_Index, int p_Count)
        {
            CheckDisposed();

            if (p_Count == 0)
                return 0;

            var s_ToRead = p_Count;
            var s_Remaining = p_Count;

            var s_CurrentPos = p_Index;

            while (s_Remaining > 0)
            {
                if (m_Remaining < s_ToRead)
                    throw new EndOfStreamException("End of stream reached with " + s_Remaining + " bytes left to read.");

                // We don't have enough bytes in the current run.
                if (s_Remaining > m_Runs[m_Cursor].CopyBytes)
                    s_ToRead = m_Runs[m_Cursor].CopyBytes;
                else
                    s_ToRead = s_Remaining;

                var s_TempData = m_Buffers[m_Runs[m_Cursor].FileId].ReadBytes(s_ToRead);
                Buffer.BlockCopy(s_TempData, 0, p_Data, s_CurrentPos, s_ToRead);
                s_CurrentPos += s_ToRead;

                m_Runs[m_Cursor].CopyBytes -= s_ToRead;
                s_Remaining -= s_ToRead;

                if (m_Runs[m_Cursor].CopyBytes != 0) 
                    continue;

                ++m_Cursor;

                if (m_Cursor < m_Runs.Count && m_Runs[m_Cursor].FileId == 1)
                    m_Buffers[1].Seek((int) m_Runs[m_Cursor].Offset, SeekOrigin.Begin);
            }

            m_Position += p_Count;
            return p_Count;
        }
    }
}
