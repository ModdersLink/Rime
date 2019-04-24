using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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

        private readonly RimeReader[] m_Buffers;

        private readonly List<DeltaBundleRun> m_Runs;

        public RimeMultiplexedReader(RimeReader p_PatchedReader, RimeReader p_BaseReader, Endianness p_Endianness)
            : base(new MemoryStream(), p_Endianness)
        {
            m_Runs = new List<DeltaBundleRun>();
            m_Position = 0;
            m_Buffers = new [] { p_PatchedReader, p_BaseReader };
            ReadRuns();
        }

        public RimeMultiplexedReader(RimeReader p_PatchedReader, RimeReader p_BaseReader, Encoding p_Encoding, Endianness p_Endianness)
            : base(new MemoryStream(), p_Encoding, p_Endianness)
        {
            m_Runs = new List<DeltaBundleRun>();
            m_Position = 0;
            m_Buffers = new [] { p_PatchedReader, p_BaseReader };
            ReadRuns();
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
            throw new Exception("Cannot seek in a Multiplexed Reader.");
        }

        public override int Read(byte[] p_Data, int p_Index, int p_Count)
        {
            if (p_Index == 0)
                return TryReadInternal(p_Data, p_Count);

            throw new Exception("Reading is only supported from the current position in Multiplexed Readers.");
        }

        public override byte[] ReadBytes(int p_Count)
        {
            var s_Data = new byte[p_Count];
            ReadInternal(s_Data, p_Count);
            return s_Data;
        }

        protected override void ReadInternal(byte[] p_Data, int p_Length)
        {
            CheckDisposed();

            if (p_Length == 0)
                return;

	        var s_ToRead = p_Length;
	        var s_Remaining = p_Length;

	        var s_CurrentPos = 0;

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

            m_Position += p_Length;
        }

        protected override int TryReadInternal(byte[] p_Data, int p_Length)
        {
            CheckDisposed();

            if (p_Length == 0)
                return 0;

            if (m_Remaining < p_Length)
                p_Length = (int) m_Remaining;

            var s_ToRead = p_Length;
            var s_Remaining = p_Length;

            var s_CurrentPos = 0;

            while (s_Remaining > 0)
            {
                // This shouldn't happen in this method.
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
                    m_Buffers[1].Seek((int)m_Runs[m_Cursor].Offset, SeekOrigin.Begin);
            }

            m_Position += p_Length;

            return p_Length;
        }
    }
}
