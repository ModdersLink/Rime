using System.Diagnostics;
using System.Net;
using RimeLib.Content.Frostbite2013_2.Frostbite.Patch;
using RimeLib.Frostbite.Codec;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Frostbite2013_2.IO;

public class RimePatchEntryReader : RimeReader
{
    private class PatchOp<T>
    {

        public T Patch { get; set; }
        public long PatchDataOffset { get; set; }
        public long BaseDataOffset { get; set; }
        public long FileOffset { get; set; }


        public long DataLength { get; set; } = -1;

        public long SegmentCount { get; set; } = 1;


        public List<KeyValuePair<long, long>>? PatchPositions { get; set; } = null;
    }
    
    public override long Position => m_CurrentPosition;
    public override long Length => m_Length;

    private long m_CurrentPosition = 0;
    private long m_Length;

    
    
    
    
    private RimeReader BaseReader { get; set; }
    private RimeReader PatchReader { get; set; }
    
    
    //private readonly RimePatchReader m_PatchReaders;

    //private RimeReader BaseReader => m_PatchReaders.BaseReader;
    //private RimeReader PatchReader => m_PatchReaders.PatchReader;
    
    
    private readonly bool m_InternalDispose;

    private List<PatchOp<PatchEntryOperation>> m_EntryPatches = new();
    private uint m_CurrentPatchIndex = 0;
    

    public RimePatchEntryReader(RimePatchReader p_PatchReader, bool p_ShouldDispose = true)
        : this(p_PatchReader.BaseReader, p_PatchReader.PatchReader, p_PatchReader.PatchHeader.EntryPatchSize)
    {
    }
    
    public RimePatchEntryReader(RimeReader p_BaseReader, RimeReader p_PatchReader, long p_PatchSize, bool p_ShouldDispose = true)
        : this(p_BaseReader, new LimitedRimeReader(p_PatchReader, p_PatchSize))
    {
    }
    public RimePatchEntryReader(RimeReader p_BaseReader, RimeReader p_PatchReader, bool p_ShouldDispose = true)
        : base(new MemoryStream(), p_BaseReader.Endianness)
    {
        m_InternalDispose = p_ShouldDispose;

        BaseReader = p_BaseReader;
        PatchReader = p_PatchReader;
        
        
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
            throw new InvalidDataException("Entry patch size cant be below 4. cant read operation!");


        //var s_PatchDataBegin = PatchReader.Position;
        //long s_BaseStreamOffset = BaseReader.Position;
        long s_OutFilePosition = 0;
        
        while (PatchReader.Position < PatchReader.Length)
        {
            var s_Operation = new PatchEntryOperation(PatchReader);
            
            // flatten some operations, and 
            switch (s_Operation.OperationType)
            {
                case PatchEntryOpType.None:
                {
                    for (var i = 0; i < s_Operation.OperationLength; i++)
                    {
                        var s_Patch = new PatchOp<PatchEntryOperation>()
                        {
                            Patch = s_Operation,

                            // Patch data position.
                            PatchDataOffset = PatchReader.Position,
                            BaseDataOffset = BaseReader.Position,

                            // Output position of file.
                            FileOffset = s_OutFilePosition
                        };

                        var s_PatchCodecReader = new CodecRimeReader(BaseReader, p_SegmentCount: 1);
                        s_OutFilePosition += s_PatchCodecReader.Length;

                        s_Patch.DataLength = s_OutFilePosition - s_Patch.FileOffset;
                        m_EntryPatches.Add(s_Patch);
                    }
                    break;
                }
                case PatchEntryOpType.Remove:
                {
                    // Skip a block
                    for (var i = 0; i < s_Operation.OperationLength; i++)
                        new CodecRimeReader(BaseReader, p_SegmentCount: 1);

                    break;
                }
                case PatchEntryOpType.New:
                {
                    for (var i = 0; i < s_Operation.OperationLength; i++)
                    {
                        var s_Patch = new PatchOp<PatchEntryOperation>()
                        {
                            Patch = s_Operation,

                            // Patch data position.
                            PatchDataOffset = PatchReader.Position,
                            BaseDataOffset = BaseReader.Position,

                            // Output position of file.
                            FileOffset = s_OutFilePosition
                        };


                        var s_PatchCodecReader = new CodecRimeReader(PatchReader, p_SegmentCount: 1);
                        s_OutFilePosition += s_PatchCodecReader.Length;

                        s_Patch.DataLength = s_OutFilePosition - s_Patch.FileOffset;
                        m_EntryPatches.Add(s_Patch);
                    }

                    break;
                }
                case PatchEntryOpType.CompressedSegment:
                {
                    var s_Patch = new PatchOp<PatchEntryOperation>()
                    {
                        Patch = s_Operation,

                        // Patch data position.
                        BaseDataOffset = BaseReader.Position,
                        PatchDataOffset = PatchReader.Position,
                            
                        // Output position of file.
                        FileOffset = s_OutFilePosition,
                        
                    };
                    
                    var s_BaseCompressedData = new CodecRimeReader(BaseReader, p_SegmentCount: 1);
                    long s_CurrentCompressedOffset = 0;
                    
                    
                    for (var i = 0; i < s_Operation.OperationLength; i++)
                    {
                        var s_Segment = new PatchCompressedSegment(PatchReader);

                        var s_PatchedBlock = new CodecRimeReader(PatchReader, p_SegmentCount: 1);
                        
                        if (s_Segment.UncompressedOffset < s_CurrentCompressedOffset)
                            throw new InvalidDataException();
                        if (s_Segment.UncompressedOffset > s_BaseCompressedData.Length)
                            throw new InvalidDataException();
                        
                        // assumes segments are sorted
                        // get delta from current block to last position in base file should already be written. (PatchCompressedSegment should be sorted).
                        var s_CompressedReadSize = s_Segment.UncompressedOffset - s_CurrentCompressedOffset;
                        s_OutFilePosition += s_CompressedReadSize;
                        s_CurrentCompressedOffset += s_CompressedReadSize;

                        // add patched block
                        s_OutFilePosition += s_PatchedBlock.Length;
                        
                        // skip replaced size in base data.
                        s_CurrentCompressedOffset += s_Segment.UncompressedSize;
                    }
                    
                    
                    if (s_CurrentCompressedOffset < s_BaseCompressedData.Length)
                        s_OutFilePosition += s_BaseCompressedData.Length - s_CurrentCompressedOffset;

                    s_Patch.DataLength = s_OutFilePosition - s_Patch.FileOffset;
                    m_EntryPatches.Add(s_Patch);
                    break;
                }
                case PatchEntryOpType.DecompressedSegment:
                {
                    //where tf is this in fb?
                    // commands are read from fb::turboMuxGetSegmentData
                    
                    var s_Patch = new PatchOp<PatchEntryOperation>()
                    {
                        Patch = s_Operation,

                        // Patch data position.
                        BaseDataOffset = BaseReader.Position,
                        PatchDataOffset = PatchReader.Position,
                        
                        // Output position of file.
                        FileOffset = s_OutFilePosition,
                    };
                    
                    
                    var s_BaseCompressedData = new CodecRimeReader(BaseReader, p_SegmentCount: 1);
                    var s_PatchedSegmentLength = PatchReader.ReadUInt16() + 1;
                    
                    
                    long s_CurrentBaseBlockOffset = 0;
                    //long s_SegmentReadOffset = 0;
                   
                    // +2 to offset for short above
                    while(( PatchReader.Position - (s_Patch.PatchDataOffset+2)) < s_Operation.OperationLength)
                    {
                        var s_Segment = new PatchDecompressedSegment(PatchReader);
                        
                        if (s_Segment.BaseDataPosition < s_CurrentBaseBlockOffset)
                            throw new InvalidDataException();
                        if (s_Segment.BaseDataPosition > s_BaseCompressedData.Length)
                            throw new InvalidDataException();
                        
                        // assumes segments are sorted
                        // get delta from current block to last position in base file should already be written. (PatchCompressedSegment should be sorted).
                        var s_CompressedReadSize = s_Segment.BaseDataPosition - s_CurrentBaseBlockOffset;
                        
                        s_OutFilePosition += s_CompressedReadSize;
                        s_CurrentBaseBlockOffset += s_CompressedReadSize;

                        // add patched block
                        PatchReader.Seek(s_Segment.PatchSize, SeekOrigin.Current);
                        s_OutFilePosition += s_Segment.PatchSize;
                        
                        // skip replace size in base data.
                        s_CurrentBaseBlockOffset += s_Segment.BaseSkip;
                    }

        
                    //var s_EndLeftData = s_PatchedSegmentLength - (s_OutFilePosition - s_Patch.FileOffset);
                    //if (s_EndLeftData > 0)
                    //    s_OutFilePosition += s_EndLeftData;
                    
                    var s_EndLeftDataPatch = s_PatchedSegmentLength - (s_OutFilePosition - s_Patch.FileOffset);
                    
                    var s_EndLeftData = s_BaseCompressedData.Length - s_CurrentBaseBlockOffset;
                    if (s_EndLeftData > 0)
                        s_OutFilePosition += s_EndLeftData;

                    s_Patch.DataLength = s_OutFilePosition - s_Patch.FileOffset;
                    m_EntryPatches.Add(s_Patch);
                    
                    break;
                }
                
            }
        }

        if (PatchReader.Position != PatchReader.Length)
            throw new InvalidDataException();
        
        
        // There is data at the end of patch data. add operation none for theese untill file is fully read.
        while (BaseReader.Position < BaseReader.Length)
        {
            var s_Patch = new PatchOp<PatchEntryOperation>()
            {
                Patch = new PatchEntryOperation()
                {
                    OperationType = PatchEntryOpType.None,
                    OperationLength = 1,
                },

                // Patch data position.
                PatchDataOffset = PatchReader.Position,
                BaseDataOffset = BaseReader.Position,

                // Output position of file.
                FileOffset = s_OutFilePosition
            };

            var s_PatchCodecReader = new CodecRimeReader(BaseReader, p_SegmentCount: 1);
            s_OutFilePosition += s_PatchCodecReader.Length;

            s_Patch.DataLength = s_OutFilePosition - s_Patch.FileOffset;
            m_EntryPatches.Add(s_Patch);
        }
        
        
        m_Length = s_OutFilePosition;
    }

    public override long Seek(long p_Offset, SeekOrigin p_Origin)
    {
        CheckDisposed();

        if (p_Origin == SeekOrigin.Current)
        {
            p_Offset = m_CurrentPosition + p_Offset;
            p_Origin = SeekOrigin.Begin;
        }

        if (p_Origin == SeekOrigin.Begin)
        {
            if (p_Offset > Length)
                throw new IOException("Seeked beyond end!");

            if (p_Offset == Length)
            {
                m_CurrentPatchIndex = (uint) m_EntryPatches.Count;
                m_CurrentPosition = p_Offset;

                return Position;
            }
            
            var s_ResultIndex = -1;
            for (var s_Index = 0; s_Index < m_EntryPatches.Count; s_Index++)
            {
                var s_Patch = m_EntryPatches[s_Index];

                // if its under, then skip.
                // under should never happen, maybe add an exception?
                if (p_Offset < s_Patch.FileOffset)
                    break;

                if (p_Offset >= (s_Patch.FileOffset + s_Patch.DataLength))
                    continue;

                // found data. breaking
                s_ResultIndex = s_Index;
                break;
            }

            if (s_ResultIndex == -1)
                throw new Exception("Could not find patch that includes this offset...");

            m_CurrentPatchIndex = (uint)s_ResultIndex;
            m_CurrentPosition = p_Offset;

            return Position;
        }

        throw new Exception("Wtf");
    }

    protected override int ReadInternal(byte[] p_Data, int p_Index, int p_Count)
    {
        CheckDisposed();

        if (p_Count == 0)
            return 0;

        // Cap the number of bytes to read.
        if (m_CurrentPosition + p_Count > Length)
            p_Count = (int)(Length - m_CurrentPosition);

        var s_Remaining = p_Count;

        while (s_Remaining > 0)
        {
             if (m_CurrentPatchIndex >= m_EntryPatches.Count)
                break;
            
            var s_CurrentPatch = m_EntryPatches[(int) m_CurrentPatchIndex];

            var s_OffsetInPatch = m_CurrentPosition - s_CurrentPatch.FileOffset;
            if (s_OffsetInPatch < 0)
                throw new Exception("This is an easy fix to auto seek m_CurrentPatchIndex, but i havent done it for testing.");

            if (s_OffsetInPatch >= s_CurrentPatch.DataLength)
            {
                m_CurrentPatchIndex++;
                continue;
            }
            switch (s_CurrentPatch.Patch.OperationType)
            {
                case PatchEntryOpType.None:
                {
                    if (BaseReader.Position != s_CurrentPatch.BaseDataOffset)
                        BaseReader.Seek(s_CurrentPatch.BaseDataOffset, SeekOrigin.Begin);
                    
                    var s_PatchCodecReader = new CodecRimeReader(BaseReader, p_SegmentCount: 1);
                    s_PatchCodecReader.Seek(s_OffsetInPatch, SeekOrigin.Begin);

                    var s_ReadSize = System.Math.Min(s_Remaining, s_PatchCodecReader.Length - s_OffsetInPatch);

                    var s_ReadBytes = s_PatchCodecReader.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining), (int) s_ReadSize);
                    s_Remaining -= s_ReadBytes;
                    m_CurrentPosition += s_ReadBytes;
                    break;
                }
                case PatchEntryOpType.Remove:
                {
                    // Skip a block | should never happen here
                    break;
                }
                case PatchEntryOpType.New:
                {
                    if (PatchReader.Position != s_CurrentPatch.PatchDataOffset)
                        PatchReader.Seek(s_CurrentPatch.PatchDataOffset, SeekOrigin.Begin);

                    var s_PatchCodecReader = new CodecRimeReader(PatchReader, p_SegmentCount: 1);
                    
                    s_PatchCodecReader.Seek(s_OffsetInPatch, SeekOrigin.Begin);
                    
                    var s_ReadSize = System.Math.Min(s_Remaining, s_PatchCodecReader.Length - s_OffsetInPatch);
                    var s_ReadBytes = s_PatchCodecReader.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining), (int) s_ReadSize);
                    s_Remaining -= s_ReadBytes;
                    m_CurrentPosition += s_ReadBytes;
                    
                    break;
                }
                case PatchEntryOpType.CompressedSegment:
                {
                    
                    if (BaseReader.Position != s_CurrentPatch.BaseDataOffset)
                        BaseReader.Seek(s_CurrentPatch.BaseDataOffset, SeekOrigin.Begin);
                    if (PatchReader.Position != s_CurrentPatch.PatchDataOffset)
                        PatchReader.Seek(s_CurrentPatch.PatchDataOffset, SeekOrigin.Begin);
                    
                    // this remakes this reader everyt time, might be able to cache it for sequenced reads
                    var s_BaseCompressedData = new CodecRimeReader(BaseReader, p_SegmentCount: 1);


                    long s_CurrentCompressedOffset = 0;
                    long s_CurrentOutOffset = 0;
                    
                    // loop operations, and check if theres data remaining
                    for (var i = 0; i < s_CurrentPatch.Patch.OperationLength && s_Remaining > 0; i++)
                    {
                        
                        var s_Segment = new PatchCompressedSegment(PatchReader);


                        var s_PatchedBlock = new CodecRimeReader(PatchReader, p_SegmentCount: 1);

                        if (s_Segment.UncompressedOffset < s_CurrentCompressedOffset)
                            throw new InvalidDataException();
                        if (s_Segment.UncompressedOffset > s_BaseCompressedData.Length)
                            throw new InvalidDataException();
                        
                        // UncompressedOffset is offset in s_BaseCompressedData
                        // UncompressedSize is size to skip in original data
                        
                        // get delta from current block to last position in base file should already be written. (PatchCompressedSegment should be sorted).
                        var s_PrefixOffset = (s_OffsetInPatch - s_CurrentOutOffset);
                        var s_PrefixReadSize = System.Math.Max(0, (s_Segment.UncompressedOffset - s_CurrentCompressedOffset) - s_PrefixOffset);
                        
                        if (s_Remaining > 0 &&
                            s_PrefixReadSize > 0)
                        {
                            s_BaseCompressedData.Seek(
                                s_CurrentCompressedOffset + s_PrefixOffset,
                                SeekOrigin.Begin);
                            
                            var s_ReadSize =  System.Math.Min(s_Remaining, s_PrefixReadSize);

                            var s_ReadBytes  = s_BaseCompressedData.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining), (int)s_ReadSize);
                            s_Remaining -= s_ReadBytes;
                            m_CurrentPosition += s_ReadBytes;
                            s_OffsetInPatch += s_ReadBytes;
                            
                            s_CurrentOutOffset += s_ReadBytes;
                            s_CurrentCompressedOffset += s_ReadBytes;
                        }
                        else
                        {
                            var s_FullCompressedSize = (s_Segment.UncompressedOffset - s_CurrentCompressedOffset);
                            
                            s_CurrentOutOffset += s_FullCompressedSize;
                            s_CurrentCompressedOffset += s_FullCompressedSize;
                        }

                        // add patched block
                        var s_PatchOffset  = (s_OffsetInPatch - s_CurrentOutOffset);
                        var s_PatchReadSize = System.Math.Max(0, s_PatchedBlock.Length - s_PatchOffset);

                        if (s_Remaining > 0 &&
                            s_PatchReadSize > 0)
                        {
                            s_PatchedBlock.Seek(s_PatchOffset, SeekOrigin.Begin);
                            
                            var s_ReadSize =  System.Math.Min(s_Remaining, s_PatchReadSize);

                            var s_ReadBytes  = s_PatchedBlock.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining), (int)s_ReadSize);
                            s_Remaining -= s_ReadBytes;
                            m_CurrentPosition += s_ReadBytes;
                            s_OffsetInPatch += s_ReadBytes;
                            
                            s_CurrentOutOffset += s_ReadBytes;
                        }
                        else
                        {
                            s_CurrentOutOffset += s_PatchedBlock.Length;
                        }

                        // skip uncompressed size in base data.
                        s_CurrentCompressedOffset += s_Segment.UncompressedSize;
                    }
                    
                    
                    var s_FooterOffset   = (s_OffsetInPatch - s_CurrentOutOffset);
                    var s_FooterReadSize = System.Math.Max(0, (s_BaseCompressedData.Length - s_CurrentCompressedOffset) - s_FooterOffset);
                    if (s_Remaining > 0 &&
                        s_FooterReadSize > 0)
                    {
                        s_BaseCompressedData.Seek(s_CurrentCompressedOffset  + (s_OffsetInPatch - s_CurrentOutOffset), SeekOrigin.Begin);
                        
                        var s_ReadSize =  System.Math.Min(s_Remaining, s_FooterReadSize);

                        var s_ReadBytes  = s_BaseCompressedData.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining), (int)s_ReadSize);
                        s_Remaining -= s_ReadBytes;
                        m_CurrentPosition += s_ReadBytes;

                        // needed, but could be kept for consistency
                        //s_CurrentCompressedOffset += s_ReadBytes;
                        //s_CurrentPatchFileOffset += s_ReadBytes;
                    }

                    break;
                }
                case PatchEntryOpType.DecompressedSegment:
                {
                    // where is this in fb?
                    // commands are read from fb::turboMuxGetSegmentData, but see no segments

                    if (BaseReader.Position != s_CurrentPatch.BaseDataOffset)
                        BaseReader.Seek(s_CurrentPatch.BaseDataOffset, SeekOrigin.Begin);
                  
                    if (PatchReader.Position != s_CurrentPatch.PatchDataOffset)
                        PatchReader.Seek(s_CurrentPatch.PatchDataOffset, SeekOrigin.Begin);

                    // this is reinitialized every read, possibly keep it cached while in range?
                    var s_BaseCompressedData = new CodecRimeReader(BaseReader, p_SegmentCount: s_CurrentPatch.SegmentCount);
                    
                  
                    var s_PatchedSegmentLength = PatchReader.ReadUInt16() + 1;

                    long s_CurrentOutFilePos = 0;
                    long s_CurrentBaseDataPos = 0;

                    var s_PatchesStartPosition = PatchReader.Position;
                    while(s_Remaining > 0 &&
                          (PatchReader.Position - (s_PatchesStartPosition)) < s_CurrentPatch.Patch.OperationLength)
                    {
                        var s_Segment = new PatchDecompressedSegment(PatchReader);

                        if (s_Segment.BaseDataPosition < s_CurrentBaseDataPos)
                            throw new InvalidDataException();

                        if (s_Segment.BaseDataPosition > s_BaseCompressedData.Length)
                            throw new InvalidDataException();

                        var s_CompressedOffset = s_OffsetInPatch - s_CurrentOutFilePos;
                        var s_ReadSize1 = System.Math.Max(0, (s_Segment.BaseDataPosition - s_CurrentBaseDataPos) - s_CompressedOffset);
                        
                        if (s_Remaining > 0 &&
                            
                            s_ReadSize1 > 0)
                        {
                            // update base data position, and seek to it
                            s_CurrentBaseDataPos += (int) s_CompressedOffset;
                            if (s_BaseCompressedData.Position != s_CurrentBaseDataPos)
                                s_BaseCompressedData.Seek(s_CurrentBaseDataPos, SeekOrigin.Begin);
                            
                            // clamp read size and read
                            var s_ReadSize =  System.Math.Min(s_Remaining, s_ReadSize1);
                            var s_ReadBytes = s_BaseCompressedData.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining), (int)s_ReadSize);
                            
                            // update positions with actual read bytes
                            s_Remaining -= s_ReadBytes;
                            m_CurrentPosition += s_ReadBytes;
                            
                            s_OffsetInPatch += s_ReadBytes;
                            
                            s_CurrentBaseDataPos += s_ReadBytes;
                            s_CurrentOutFilePos += s_ReadBytes;
                        }
                        else
                        {
                            var s_ReadSize = (s_Segment.BaseDataPosition - s_CurrentBaseDataPos);
                            
                            s_CurrentBaseDataPos += s_ReadSize;
                            s_CurrentOutFilePos += s_ReadSize;
                        }
                        
                        // write actual patch
                        var s_PatchOffset = s_OffsetInPatch - s_CurrentOutFilePos;
                        var s_PatchSize = System.Math.Max(0, s_Segment.PatchSize - s_PatchOffset);
                        if (s_Remaining > 0 &&
                            
                            s_PatchSize > 0)
                        {
                            
                            // seek to relative patchoffset
                            PatchReader.Seek(s_PatchOffset, SeekOrigin.Current);

                            
                            //PatchReader.Seek(s_DeltaPayloadSize, SeekOrigin.Current);
                            var s_ReadSize =  System.Math.Min(s_Remaining, s_PatchSize);

                            var s_ReadBytes  = PatchReader.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining), (int)s_ReadSize);
                            
                            
                            // update positions with actual read bytes
                            s_Remaining -= s_ReadBytes;
                            m_CurrentPosition += s_ReadBytes;
                            
                            s_OffsetInPatch += s_ReadBytes;
                            s_CurrentOutFilePos += s_ReadBytes;
                        }
                        else
                        {
                            PatchReader.Seek(s_Segment.PatchSize, SeekOrigin.Current);
                            
                            s_CurrentOutFilePos += s_Segment.PatchSize;
                            
                        }
                        
                        // skip patched data from base
                        s_CurrentBaseDataPos += s_Segment.BaseSkip;

                    }
                    
                    
                    
                    // write footer da data
                    var s_FooterOffset = System.Math.Max(0, s_OffsetInPatch - s_CurrentOutFilePos);
                    
                    
                    var s_PatchEndLeftData = System.Math.Max(0, (s_PatchedSegmentLength - s_CurrentOutFilePos) - s_FooterOffset);
                    
                    var s_EndLeftData = System.Math.Max(0, (s_BaseCompressedData.Length - s_CurrentBaseDataPos) - s_FooterOffset);
                    if (s_Remaining > 0 &&
                        
                        s_EndLeftData > 0)
                    {
                        s_CurrentBaseDataPos += s_FooterOffset;
                        if (s_BaseCompressedData.Position != s_CurrentBaseDataPos )
                            s_BaseCompressedData.Seek(s_CurrentBaseDataPos, SeekOrigin.Begin);

                        var s_EndReadSize = (int)System.Math.Min(s_Remaining, s_EndLeftData);
                        var s_EndReadBytes = s_BaseCompressedData.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining), (int)s_EndReadSize);

                        m_CurrentPosition += s_EndReadBytes;
                        s_Remaining -= s_EndReadBytes;
                    }
                    /*
                    var s_FooterOffset = System.Math.Max(0, s_OffsetInPatch - s_CurrentOutFilePos);
                    var s_EndLeftData = System.Math.Max(0, (s_PatchedSegmentLength - s_CurrentOutFilePos) - s_FooterOffset);
                    if (s_Remaining > 0 &&
                        
                        s_EndLeftData > 0)
                    {
                        s_CurrentBaseDataPos += s_FooterOffset;
                        if (s_BaseCompressedData.Position != s_CurrentBaseDataPos )
                            s_BaseCompressedData.Seek(s_CurrentBaseDataPos, SeekOrigin.Begin);

                        var s_EndReadSize = (int)System.Math.Min(s_Remaining, s_EndLeftData);
                        var s_EndReadBytes = s_BaseCompressedData.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining), (int)s_EndReadSize);

                        m_CurrentPosition += s_EndReadBytes;
                        s_Remaining -= s_EndReadBytes;
                    }
                    */

                    break;
                }
               
            }
            
            
            if (m_CurrentPosition >= s_CurrentPatch.FileOffset + s_CurrentPatch.DataLength)
                m_CurrentPatchIndex++;
        }

        return p_Count - s_Remaining; 
        //return BaseStream.Read(p_Data, p_Index, (int) System.Math.Min(p_Count, Length-Position));
    }


}