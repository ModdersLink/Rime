using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using RimeLib.Content.Frostbite2013_2.Frostbite.Patch;
using RimeLib.Frostbite.Codec;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Frostbite2013_2.IO;

public class RimePatchManifestReader : RimeReader
{
    private class PatchOp<T>
    {

        public T Patch { get; set; }
        public long PatchDataOffset { get; set; }
        public long BaseDataOffset { get; set; }
        public long FileOffset { get; set; }
    }
    // manifest size is the first 4 bytes
    public override long Position => m_CurrentPosition;
    public override long Length => (m_Length + 4);

    private long m_CurrentPosition;
    private long m_Length;

    
    //private readonly RimePatchReader m_PatchReaders;
    //private RimeReader BaseReader => m_PatchReaders.BaseReader;
    //private RimeReader PatchReader => m_PatchReaders.PatchReader;
    
    private RimeReader BaseReader { get; set; }
    private RimeReader PatchReader { get; set; }
    
    
    private readonly bool m_InternalDispose;

    private List<PatchOp<PatchManifestOperation>> m_ManifestPatches = new();
    private uint m_CurrentPatchIndex = 0;

    public RimePatchManifestReader(RimePatchReader p_PatchReader, bool p_ShouldDispose = true)
        : this(p_PatchReader.BaseReader, p_PatchReader.PatchReader, p_PatchReader.PatchHeader.ManifestPatchSize)
    {
    }
    
    public RimePatchManifestReader(RimeReader p_BaseReader, RimeReader p_PatchReader, long p_PatchSize, bool p_ShouldDispose = true)
        : this(p_BaseReader, new LimitedRimeReader(p_PatchReader, p_PatchSize))
    {
    }
        
    public RimePatchManifestReader(RimeReader p_BaseReader, RimeReader p_PatchReader, bool p_ShouldDispose = true)
        : base(new MemoryStream(), p_BaseReader.Endianness)
    {
        m_InternalDispose = p_ShouldDispose;

        BaseReader = p_BaseReader;
        PatchReader = p_PatchReader;
        m_CurrentPosition = 0;
        m_Length = 0;

        ReadEntries();
    }

    public override void Dispose()
    {
        base.Dispose();

        if (!m_InternalDispose) 
            return;
    }

    private void ReadEntries()
    {
        if (PatchReader.Length < 4)
            throw new InvalidDataException("Manifest patch size cant be below 4. cant read manifest size!");
        
        // TODO: this might need to be written out. 
        var s_OrigManifestDataRemaining = BaseReader.ReadUInt32();
        var s_BaseReaderStartPos = BaseReader.Position;
        
        //var s_PatchManifestDataBegin = PatchReader.Position;
        m_Length = PatchReader.ReadUInt32();


        long s_BaseStreamOffset = BaseReader.Position;
        long s_CurrentFilePosition = 0;
        
        while (PatchReader.Position < PatchReader.Length)
        {
            var s_Operation = new PatchManifestOperation(PatchReader);
            
            //Debug.WriteLine(s_Operation);
            
            // we dont want to add skips in the patch arrays, as they cause issues
            // out file offset 
            if (s_Operation.OperationOpType != PatchManifestOpType.Skip)
            {
                m_ManifestPatches.Add(new()
                {
                    Patch = s_Operation,

                    // Patch data position.
                    PatchDataOffset = PatchReader.Position,
                    BaseDataOffset = s_BaseStreamOffset,

                    // Output position of file.
                    FileOffset = s_CurrentFilePosition
                });
            }



            switch (s_Operation.OperationOpType)
            {
                case PatchManifestOpType.Read:
                    s_BaseStreamOffset += s_Operation.OperationLength;
                    //TODO: Seek in patch here?
                    
                    // if reading, update original size
                    s_CurrentFilePosition += s_Operation.OperationLength;
                    break;
                case PatchManifestOpType.Skip:
                    // Skip should seek in basestream.
                    s_BaseStreamOffset += s_Operation.OperationLength;
                    
                    // skipping doesn not need to update file position
                    break;
                case PatchManifestOpType.Insert:
                    PatchReader.Seek(s_Operation.OperationLength, SeekOrigin.Current);
                    
                    
                    // if reading, update original size
                    s_CurrentFilePosition += s_Operation.OperationLength;
                    break;
            }
        }

        if (s_CurrentFilePosition != m_Length)
            throw new InvalidDataException("Operation size mismatch. somethings wrong around here");
        
        // this is wrong, rmeove
        //if (s_BaseStreamOffset != s_OrigManifestDataRemaining)
        //    throw new InvalidDataException("Operation size mismatch. somethings wrong around here");

        BaseReader.Seek(s_BaseReaderStartPos + s_OrigManifestDataRemaining, SeekOrigin.Begin);
        PatchReader.Seek(PatchReader.Length, SeekOrigin.Begin);
    }

    public override long Seek(long p_Offset, SeekOrigin p_Origin)
    {
        CheckDisposed();

        if (p_Origin == SeekOrigin.Begin)
        {
            var s_ResultIndex = -1;
            for (var s_Index = 0; s_Index < m_ManifestPatches.Count; s_Index++)
            {
                var s_Patch = m_ManifestPatches[s_Index];

                // if its under, then skip.
                // under should never happen, maybe add an exception?
                if (p_Offset < s_Patch.FileOffset)
                    continue;

                if (p_Offset >= (s_Patch.FileOffset + s_Patch.Patch.OperationLength))
                    continue;

                // found data. breaking
                s_ResultIndex = s_Index;
                break;
            }

            if (s_ResultIndex == -1)
                throw new Exception("Could not find patch that includes this offset...");

            m_CurrentPatchIndex = (uint)s_ResultIndex;
            m_CurrentPosition = p_Offset;

        }
        else if (p_Origin == SeekOrigin.Current)
        {
            var s_CurrentLeft = p_Offset;
            while (true)
            {
                s_CurrentLeft -= m_ManifestPatches[(int)m_CurrentPatchIndex].Patch.OperationLength;

                // if we dont have any data left, break
                if (s_CurrentLeft < 0)
                    break;
                
                
                // set next, and break
                if (s_CurrentLeft == 0)
                {
                    m_CurrentPatchIndex++;
                    break;
                }

                m_CurrentPatchIndex++;
            }
        }

        return this.Position;
    }

    protected override int ReadInternal(byte[] p_Data, int p_Index, int p_Count)
    {
        CheckDisposed();

        if (p_Count == 0)
            return 0;

        // Cap the number of bytes to read.
        if (m_CurrentPosition + p_Count > Length)
            p_Count = (int)(Length - m_CurrentPosition);

        // first 4 bytes should be manifest length.

        
        
        var s_Remaining = p_Count;


        // add a way to read manifest size at start
        if (m_CurrentPosition >= 0 &&
            m_CurrentPosition < 4)
        {

            var s_SizeBytes = BitConverter.GetBytes((uint)m_Length);
            using var s_TempStream = new MemoryStream(s_SizeBytes);

            s_TempStream.Seek(m_CurrentPosition, SeekOrigin.Begin);

            var s_ReadSize = System.Math.Min(s_Remaining, s_SizeBytes.Length-m_CurrentPosition);
            var s_ReadBytes = s_TempStream.Read(p_Data, p_Index + (p_Count - s_Remaining), (int) s_ReadSize);
            
            s_Remaining -= s_ReadBytes;
            m_CurrentPosition += s_ReadBytes;
        }

        
        while (s_Remaining > 0)
        {
            var s_CurrentPatchPosition = m_CurrentPosition - 4;
            
            if (s_CurrentPatchPosition >= m_Length)
                break;

            if (m_CurrentPatchIndex >= m_ManifestPatches.Count)
                break;

            var s_CurrentPatch = m_ManifestPatches[(int)m_CurrentPatchIndex];

            if (m_CurrentPosition < 4)
                throw new Exception("this shouldnt happen, and if it does then idk whats up");
            var s_OffsetInBlock = s_CurrentPatchPosition - s_CurrentPatch.FileOffset;
            
            
            long s_ReadSize = System.Math.Min(s_Remaining, s_CurrentPatch.Patch.OperationLength - s_OffsetInBlock);
            long s_BlockRead = 0;
            
            //Debug.WriteLine($"{m_CurrentPatchIndex} - {s_CurrentPatch.Patch}");
            
            
            switch (s_CurrentPatch.Patch.OperationOpType)
            {
                case PatchManifestOpType.Read:
                    // avoid calling seek
                    if ((s_CurrentPatch.BaseDataOffset + s_OffsetInBlock) != BaseReader.Position)
                        BaseReader.Seek(s_CurrentPatch.BaseDataOffset + s_OffsetInBlock, SeekOrigin.Begin);

                    s_BlockRead = BaseReader.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining), (int) s_ReadSize);
                    break;
                case PatchManifestOpType.Skip:
                    //BaseReader.Seek(s_CurrentPatch.Patch.OperationLength, SeekOrigin.Current);
                    throw new Exception("Seek is skipped on read. this should never be reached when reading");
                    break;
                case PatchManifestOpType.Insert:
                    
                    if ((s_CurrentPatch.PatchDataOffset + s_OffsetInBlock) != PatchReader.Position)
                        PatchReader.Seek(s_CurrentPatch.PatchDataOffset + s_OffsetInBlock, SeekOrigin.Begin);
                    
                    s_BlockRead = PatchReader.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining), (int) s_ReadSize);
                    break;
            }
            
            s_Remaining -= (int) s_BlockRead;
            m_CurrentPosition += s_BlockRead;
            
            // Go to next patch if theres more bytes remaining
            if ((m_CurrentPosition-4) >= (s_CurrentPatch.FileOffset + s_CurrentPatch.Patch.OperationLength))
                m_CurrentPatchIndex++;
        }

        /*
        if (m_CurrentPosition >= (m_Length + 4) &&
            m_CurrentPosition < Length)
        {
            using var s_TempStream = new MemoryStream(new byte[0x10]);
            
            var s_ReadSize = System.Math.Min(s_Remaining, 0x10);

            var s_ReadBytes = s_TempStream.Read(p_Data, p_Index + (p_Count - s_Remaining), s_ReadSize);
            
            s_Remaining -= s_ReadBytes;
            m_CurrentPosition += s_ReadBytes;
        }
        */
        
        // if we have more bytes remaining, we might need to read patch entries.
        // return actual bytes read
        if (s_Remaining <= 0)
            return p_Count;

        return p_Count - s_Remaining;
    }
}