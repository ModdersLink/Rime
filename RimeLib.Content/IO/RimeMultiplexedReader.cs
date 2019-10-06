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
        public override long Position => m_CurrentPosition;
        public override long Length => m_Length;

        private long m_CurrentPosition;
        private long m_Length;
        private long m_BasePatchedOffset;

        private readonly RimeReader m_BaseReader;
        private readonly RimeReader m_PatchReader;

        private readonly List<DeltaBundleRun> m_Runs;

        private readonly bool m_InternalDispose;

        public RimeMultiplexedReader(RimeReader p_PatchReader, RimeReader p_BaseReader, Endianness p_Endianness, bool p_ShouldDispose = true)
            : base(new MemoryStream(), p_Endianness)
        {
            m_Runs = new List<DeltaBundleRun>();
            m_InternalDispose = p_ShouldDispose;

            m_BaseReader = p_BaseReader;
            m_PatchReader = p_PatchReader;

            m_CurrentPosition = 0;
            m_Length = 0;
            m_BasePatchedOffset = 0;

            ReadRuns();
        }

        public override void Dispose()
        {
            base.Dispose();

            if (!m_InternalDispose) 
                return;

            m_BaseReader.Dispose();
            m_PatchReader.Dispose();
        }

        private void ReadRuns()
        {
            // Do we have enough data for reading the patch header?
            if (m_PatchReader.BaseStream.Position + 16 > m_PatchReader.BaseStream.Length)
                throw new Exception("Not enough data found to read patch header. This is probably caused because we tried to parse a non-patch file.");

            // Read the patch header.
            var s_RunsSize = m_PatchReader.ReadInt32();
            var s_Magic = m_PatchReader.ReadUInt32();
            m_PatchReader.ReadUInt64(); // Padding

            // Perform some validation.
            if (m_PatchReader.BaseStream.Position + s_RunsSize > m_PatchReader.BaseStream.Length)
                throw new Exception("Not enough data found to read patch runs. This is probably caused because we tried to parse a non-patch file.");

            if (s_Magic != 0xDE17AAAA)
                throw new Exception("Failed to validate patch data header. This is probably caused because we tried to parse a non-patch file.");

            if (s_RunsSize % 16 != 0)
                throw new Exception("Read an invalid patch runs size. This is probably caused because we tried to parse a non-patch file.");

            // Calculate how many runs we have.
            var s_RunCount = s_RunsSize / 16;

            // Read out all the runs from the patch header.
            for (var i = 0; i < s_RunCount; ++i)
            {
                var s_Run = new DeltaBundleRun(m_PatchReader);
                m_Runs.Add(s_Run);
                m_Length += s_Run.CopyBytes;
            }

            // Store the offset where the patched data begins.
            m_BasePatchedOffset = m_PatchReader.Position;
        }

        public override long Seek(long p_Offset, SeekOrigin p_Origin)
        {
            CheckDisposed();

            // Find the requested target offset.
            var s_TargetOffset = p_Offset;

            if (p_Origin == SeekOrigin.End)
                s_TargetOffset = m_Length - p_Offset;
            else if (p_Origin == SeekOrigin.Current)
                s_TargetOffset = m_CurrentPosition + p_Offset;

            if (s_TargetOffset < 0 || s_TargetOffset > m_Length)
                throw new ArgumentException("The provided offset is out of bounds for this stream.", nameof(p_Offset));

            // Set the position.
            m_CurrentPosition = s_TargetOffset;

            return m_CurrentPosition;
        }
        
        protected override int ReadInternal(byte[] p_Data, int p_Index, int p_Count)
        {
            CheckDisposed();

            if (p_Count == 0)
                return 0;
            
            // Cap the number of bytes to read.
            if (m_CurrentPosition + p_Count > m_Length)
                p_Count = (int) (m_Length - m_CurrentPosition);

            var s_Remaining = p_Count;
            
            //Debug.WriteLine($"Multiplexed reader reading {p_Count} bytes.");

            while (s_Remaining > 0)
            {
                // Find the run we're currently in.
                var s_RunIndex = 0;
                var s_Run = m_Runs[0];
                var s_CopyBytes = s_Run.CopyBytes;

                var s_Offset = (int) m_CurrentPosition + (p_Count - s_Remaining);
                
                // Find the relative offset of this patched data run.
                var s_PatchRunOffset = s_Run.FileId == 0 ? s_Run.CopyBytes : 0;

                while (s_Offset >= s_CopyBytes)
                {
                    s_Run = m_Runs[++s_RunIndex];
                    s_CopyBytes += s_Run.CopyBytes;

                    if (s_Run.FileId == 0)
                        s_PatchRunOffset += s_Run.CopyBytes;
                }

                // Find the relative offset in this run.
                var s_RelativeOffset = s_Offset - (s_CopyBytes - s_Run.CopyBytes);

                // See how many data we can read from this run.
                var s_ToRead = s_Remaining;

                if (s_RelativeOffset + s_Remaining > s_Run.CopyBytes)
                    s_ToRead = s_Run.CopyBytes - s_RelativeOffset;

                // Seek to the appropriate offset.
                if (s_Run.FileId == 0)
                {
                    // Seek to the relevant offset based on the relative patch run offset and the rest.
                    var s_ReadOffset = m_BasePatchedOffset + (s_PatchRunOffset - s_Run.CopyBytes) + s_RelativeOffset;
                    m_PatchReader.Seek(s_ReadOffset, SeekOrigin.Begin);
                    
                    // Read the data.
                    var s_BytesRead = m_PatchReader.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining), s_ToRead);
                    s_Remaining -= s_BytesRead;
                    m_CurrentPosition += s_BytesRead;
                }
                else
                {
                    // Seek to the provided run offset + relative offset.
                    m_BaseReader.Seek((long) s_Run.Offset + s_RelativeOffset, SeekOrigin.Begin);
                    
                    // Read the data.
                    var s_BytesRead = m_BaseReader.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining), s_ToRead);
                    s_Remaining -= s_BytesRead;
                    m_CurrentPosition += s_BytesRead;
                }
            }

            return p_Count;
        }
    }
}
