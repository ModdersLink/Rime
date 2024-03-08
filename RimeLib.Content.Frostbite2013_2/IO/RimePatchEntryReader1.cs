using System.Diagnostics;
using System.Net;
using RimeLib.Content.Frostbite2013_2.Frostbite.Patch;
using RimeLib.Frostbite.Codec;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Frostbite2013_2.IO;

public class RimePatchEntryReader1 : RimeReader
{
    private class PatchOp<T>
    {

        public T Patch { get; set; }
        public long PatchDataOffset { get; set; }
        public long BaseDataOffset { get; set; }
        public long FileOffset { get; set; }

        public long BasePatchDataOffset { get; set; } = -1;
        public long BaseBaseDataOffset { get; set; } = -1;


        public long DataLength { get; set; } = -1;
        
  

    }
    
    public override long Position => BaseStream.Position;
    public override long Length => m_Length;

    private long m_Length;

    
    private RimeReader PatchReader { get; set; }
    private RimeReader BaseReader { get; set; }
    
    
    private readonly bool m_InternalDispose;

    private List<PatchOp<PatchEntryOperation>> m_EntryPatches = new();
    private uint m_CurrentPatchIndex = 0;
    

    public RimePatchEntryReader1(RimeReader p_BaseReader, RimeReader p_PatchReader, bool p_ShouldDispose = true)
        : base(new MemoryStream(), p_PatchReader.Endianness)
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
        
        if(PatchReader.Length < 4)
            throw new InvalidDataException("Entry patch size cant be below 4. cant read operation!");
     
        
        var s_PatchDataBegin = PatchReader.Position;
        long s_BaseStreamOffset = BaseReader.Position;
        long s_OutFilePosition = 0;
        
        while (PatchReader.Position < (s_PatchDataBegin + PatchReader.Length ))
        {
            var s_Operation = new PatchEntryOperation(PatchReader);
            
            Debug.WriteLine(s_Operation);
            
            // we need to flatten operations, as they become a bit annoying if not.
            
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
                            //BasePatchDataOffset = PatchReader.Position,
                            //BaseBaseDataOffset = BaseReader.Position,

                            // Output position of file.
                            FileOffset = s_OutFilePosition
                        };

                        var s_PatchCodecReader = new CodecRimeReader(BaseReader, p_SegmentCount: 1);
                        s_OutFilePosition += s_PatchCodecReader.Length;

                        s_Patch.DataLength = s_PatchCodecReader.Length;
                        m_EntryPatches.Add(s_Patch);
                    }
                    break;
                }
                case PatchEntryOpType.CompressedSegment:
                {
                    var s_BasePatchOffset = BaseReader.Position;
                    var s_BaseCompressedData = new CodecRimeReader(BaseReader, p_SegmentCount: 1);
                    var s_CurrentCompressedOffset = 0;
                    
                    m_EntryPatches.Add(new PatchOp<PatchEntryOperation>()
                    {
                        Patch = s_Operation,

                        // Patch data position.
                        PatchDataOffset = PatchReader.Position,
                        BaseDataOffset = BaseReader.Position,
                            
                        BaseBaseDataOffset = s_BasePatchOffset,

                        // Output position of file.
                        FileOffset = s_OutFilePosition,
                        
                        DataLength = s_BaseCompressedData.Length
                    });
                    
                    // Theres some bullshit going on around here
                    //  something something, there can be extra bytes at the end
                    //  confirm sizes and stuff
                    for (var i = 0; i < s_Operation.OperationLength; i++)
                    {
                        

                        var s_Segment = new PatchCompressedSegment(PatchReader);

                        var s_PatchedBlock = new CodecRimeReader(PatchReader, p_SegmentCount: 1);
                        
                        
                        // UncompressedOffset is offset in s_BaseCompressedData
                        // UncompressedSize is size to skip in original data
                        
                        // get delta from current block to last position in base file should already be written. (PatchCompressedSegment should be sorted).
                        var s_CompressedReadSize = s_Segment.UncompressedOffset - s_CurrentCompressedOffset;
                        s_OutFilePosition += s_CompressedReadSize;
                        s_CurrentCompressedOffset += s_CompressedReadSize;

                        // add patched block
                        s_OutFilePosition += s_PatchedBlock.Length;
                        
                        // skip uncompressed size in base data.
                        s_CurrentCompressedOffset += s_Segment.UncompressedSize;
                    }
                    
                    
                    if(s_CurrentCompressedOffset < s_BaseCompressedData.Length)
                        s_OutFilePosition += s_BaseCompressedData.Length - s_CurrentCompressedOffset;
                    
                    
                    break;
                }
                case PatchEntryOpType.DecompressedSegment:
                {
                    //where tf is this in fb?
                    // commands are read from fb::turboMuxGetSegmentData
                    
                    var s_BaseBaseOffset = BaseReader.Position;
                    var s_BasePatchOffset = PatchReader.Position;
                    var s_BaseCompressedData = new CodecRimeReader(BaseReader, p_SegmentCount: 1);
                    
                    
                    var s_PatchedSegmentLength = PatchReader.ReadUInt16() + 1;
                    m_EntryPatches.Add( new PatchOp<PatchEntryOperation>()
                    {
                        Patch = s_Operation,

                        // Patch data position.
                        PatchDataOffset = PatchReader.Position,
                        BaseDataOffset = s_BaseBaseOffset,
                        BasePatchDataOffset = s_BasePatchOffset,
                        BaseBaseDataOffset = s_BaseBaseOffset,

                        // Output position of file.
                        FileOffset = s_OutFilePosition,
                            
                        //BaseBlockOffset = s_CurrentBaseBlockOffset,
                        
                        DataLength = s_PatchedSegmentLength
                    });
                    
                    
                    var s_CurrentBaseBlockOffset = 0;
                    var s_BaseOutFilePosition = s_OutFilePosition;
                   
                    
                    // theese operations patches data from base reader
                    // possibly read out the data,
                    // Theres some more bullshit going on around here
                    while(( PatchReader.Position - (s_BasePatchOffset+2)) < s_Operation.OperationLength)
                    {
                        var s_Segment = new PatchDecompressedSegment(PatchReader);

                        
                        // get delta from current block to last position in base file should already be written. (PatchCompressedSegment should be sorted).
                        var s_CompressedReadSize = s_Segment.BaseDataPosition - s_CurrentBaseBlockOffset;
                        
                        s_OutFilePosition += s_CompressedReadSize;
                        s_CurrentBaseBlockOffset += s_CompressedReadSize;

                        // add patched block
                        PatchReader.Seek(s_Segment.PatchSize, SeekOrigin.Current);
                        s_OutFilePosition += s_Segment.PatchSize;
                        
                        // skip uncompressed size in base data.
                        s_CurrentBaseBlockOffset += s_Segment.BaseSkip;
                    }

                    
                    var s_EndLeftData = s_PatchedSegmentLength - (s_OutFilePosition - s_BaseOutFilePosition);
                    if(s_EndLeftData > 0)
                        s_OutFilePosition += s_EndLeftData;
                    
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
                            //BasePatchDataOffset = PatchReader.Position,
                            //BaseBaseDataOffset = BaseReader.Position,

                            // Output position of file.
                            FileOffset = s_OutFilePosition
                        };


                        var s_PatchCodecReader = new CodecRimeReader(PatchReader, p_SegmentCount: 1);
                        s_OutFilePosition += s_PatchCodecReader.Length;

                        s_Patch.DataLength = s_PatchCodecReader.Length;
                        m_EntryPatches.Add(s_Patch);
                    }

                    break;
                }
                case PatchEntryOpType.Remove:
                {
                    // Skip a block
                    var s_BaseCodecReader = new CodecRimeReader(BaseReader, p_SegmentCount: 1);
                    
                    // wtf we shouldnt write outfileposition here
                    //s_OutFilePosition += s_BaseCodecReader.Length;
                    break;
                }
            }
        }

        m_Length = s_OutFilePosition;
    }

    public override long Seek(long p_Offset, SeekOrigin p_Origin)
    {
        CheckDisposed();

        if(p_Origin == SeekOrigin.Begin)
        {
            ReadUntill(p_Offset);
            return BaseStream.Seek(p_Offset, p_Origin);
        }
        else if(p_Origin == SeekOrigin.Current)
        {
            ReadUntill(Position + p_Offset);
            return BaseStream.Seek(p_Offset, p_Origin);
        }
        else if (p_Origin == SeekOrigin.End)
        {
            ReadUntill(m_Length);
            return BaseStream.Seek(p_Offset, p_Origin);
        }

        throw new Exception("Wtf");
    }

    protected override int ReadInternal(byte[] p_Data, int p_Index, int p_Count)
    {
        CheckDisposed();

        if (p_Count == 0)
            return 0;

        ReadUntill(Position + p_Count);
        
        
        
        return BaseStream.Read(p_Data, p_Index, (int) System.Math.Min(p_Count, Length-Position));
    }



    private void ReadUntill(long p_Offset)
    {
        if (BaseStream.Length >= p_Offset)
            return;
        
        var s_StartPosition = BaseStream.Position;
        BaseStream.Seek(BaseStream.Length, SeekOrigin.Begin);
        
        while (BaseStream.Length < p_Offset &&
               BaseStream.Length < Length)
        {
            if (m_CurrentPatchIndex >= m_EntryPatches.Count)
            {
                // this is a hack, fix it
                // TODO: aaa
                m_Length = BaseStream.Length;
                break;
            }
            
            var s_CurrentPatch = m_EntryPatches[(int) m_CurrentPatchIndex++];
            
            Debug.WriteLine($"{(m_CurrentPatchIndex-1)} - {s_CurrentPatch.Patch}");
            
            //if( (m_CurrentPatchIndex-1) == 580)
            //    Debugger.Break();

            switch (s_CurrentPatch.Patch.OperationType)
            {
                case PatchEntryOpType.None:
                {
                    if (BaseReader.Position != s_CurrentPatch.BaseDataOffset)
                        BaseReader.Seek(s_CurrentPatch.BaseDataOffset, SeekOrigin.Begin);
                    
                    var s_PatchCodecReader = new CodecRimeReader(BaseReader, p_SegmentCount: 1);
                    s_PatchCodecReader.CopyTo(BaseStream);
                    //BaseStream.Write(s_PatchCodecReader.ReadBytes((int)s_PatchCodecReader.Length));
                    break;
                }
                case PatchEntryOpType.CompressedSegment:
                {
                    
                    // Theres some bullshit going on around here
                    //  something something, there can be extra bytes at the end
                    
                    if (BaseReader.Position != s_CurrentPatch.BaseBaseDataOffset)
                        BaseReader.Seek(s_CurrentPatch.BaseBaseDataOffset, SeekOrigin.Begin);
                    
                    // this remakes this reader everyt time, might be able to cache it for sequenced reads
                    var s_BaseCompressedData = new CodecRimeReader(BaseReader, p_SegmentCount: 1);
                    
                    if (PatchReader.Position != s_CurrentPatch.PatchDataOffset)
                        PatchReader.Seek(s_CurrentPatch.PatchDataOffset, SeekOrigin.Begin);

                    var s_CurrentBaseBlockOffset = 0;
                    
                    for (var i = 0; i < s_CurrentPatch.Patch.OperationLength; i++)
                    {
                        

                        var s_Segment = new PatchCompressedSegment(PatchReader);

                        var s_PatchedBlock = new CodecRimeReader(PatchReader, p_SegmentCount: 1);
                        
                        
                        // UncompressedOffset is offset in s_BaseCompressedData
                        // UncompressedSize is size to skip in original data
                        
                        // get delta from current block to last position in base file should already be written. (PatchCompressedSegment should be sorted).
                        BaseStream.Write(s_BaseCompressedData.ReadBytes((int)(s_Segment.UncompressedOffset - s_BaseCompressedData.Position)));
                       
                        // add patched block
                        s_PatchedBlock.CopyTo(BaseStream);
                        
                        // skip uncompressed size in base data.
                        s_BaseCompressedData.Seek(s_Segment.UncompressedSize, SeekOrigin.Current);
                    }
                    
                    if(s_BaseCompressedData.Position < s_BaseCompressedData.Length)
                        BaseStream.Write(s_BaseCompressedData.ReadBytes((int)(s_BaseCompressedData.Length - s_BaseCompressedData.Position)));

                    break;
                }
                case PatchEntryOpType.DecompressedSegment:
                {
                    //where tf is this in fb?
                    // commands are read from fb::turboMuxGetSegmentData

                    if (BaseReader.Position != s_CurrentPatch.BaseBaseDataOffset)
                        BaseReader.Seek(s_CurrentPatch.BaseBaseDataOffset, SeekOrigin.Begin);
                    // this is also reinitialized. try to cache it for sequenced reads
                    var s_BaseCompressedData = new CodecRimeReader(BaseReader, p_SegmentCount: 1);
                    
                    // is this needed? we need to seek patch base then
                    if (PatchReader.Position != s_CurrentPatch.BasePatchDataOffset)
                        PatchReader.Seek(s_CurrentPatch.BasePatchDataOffset, SeekOrigin.Begin);
                    
                    // this patch works by reading the baecompressed data
                    var s_PatchedSegmentLength = PatchReader.ReadUInt16() + 1;

                    var s_BaseWritePosition = BaseStream.Position;
                    
                    var s_PatchesStartPosition = PatchReader.Position;
                    while(( PatchReader.Position - (s_PatchesStartPosition)) < s_CurrentPatch.Patch.OperationLength)
                    {
                        var s_Segment = new PatchDecompressedSegment(PatchReader);
                        
                        //Read base data up to patch position
                        BaseStream.Write(s_BaseCompressedData.ReadBytes(s_Segment.BaseDataPosition - (int)s_BaseCompressedData.Position));
                        
                        // write actual patch
                        BaseStream.Write(PatchReader.ReadBytes(s_Segment.PatchSize));

                        s_BaseCompressedData.Seek(s_Segment.BaseSkip, SeekOrigin.Current);
                    }
                    
                    // write end data
                    var s_EndLeftData = s_PatchedSegmentLength - (BaseStream.Position - s_BaseWritePosition);
                    if(s_EndLeftData > 0)
                        BaseStream.Write(s_BaseCompressedData.ReadBytes((int) s_EndLeftData));

                    break;
                }
                case PatchEntryOpType.New:
                {
                    if (PatchReader.Position != s_CurrentPatch.PatchDataOffset)
                        PatchReader.Seek(s_CurrentPatch.PatchDataOffset, SeekOrigin.Begin);


                    var s_PatchCodecReader = new CodecRimeReader(PatchReader, p_SegmentCount: 1);
                    
                    s_PatchCodecReader.CopyTo(BaseStream);


                    break;
                }
                case PatchEntryOpType.Remove:
                {
                    // Skip a block
                    break;
                }
            }
        }

        BaseStream.Seek(s_StartPosition, SeekOrigin.Begin);
    }
/*
    bool ReadManifestOperation(PatchManifestOperation p_ManifestOp, out byte[]? p_Data)
    {
        p_Data = null;
        switch (p_ManifestOp.OperationOpType)
        {
            case PatchManifestOpType.Read:
                p_Data = m_BaseReader.ReadBytes((int) p_ManifestOp.OperationLength);
                break;
            case PatchManifestOpType.Skip:
                // Replace with readbytes?
                m_BaseReader.Seek(p_ManifestOp.OperationLength, SeekOrigin.Current);
                break;
            case PatchManifestOpType.Insert:
                p_Data = m_PatchReader.ReadBytes((int) p_ManifestOp.OperationLength);
                break;
        }  

        return p_Data != null;
    }

    bool ReadDataOperation(PatchEntryOperation p_Op, out byte[]? p_Data)
    {
        p_Data = null;

        switch (p_Op.OperationType)
        {
            case PatchEntryOpType.None:
            {
                break;
            }
            case PatchEntryOpType.CompressedSegment: 
            {
                
                
                break;
            }
            case PatchEntryOpType.DecompressedSegment:
            {
                
                var s_BaseCodecReader = new CodecRimeReader(m_BaseReader, p_SegmentCount: 1);

                var s_PatchedSegmentLength = m_PatchReader.ReadUInt16() + 1;
                
                
                
                break;
            }
            case PatchEntryOpType.New:
            {
                var s_PatchCodecReader = new CodecRimeReader(m_PatchReader, p_SegmentCount: 1);
                // TODO: Read and fix compression. Look at CodecRimeReader, but the reader reads the whole size.
                // we just want to read 1 entry
                
                
                //TODO: Decrease patchoplength by 1
                break;
            }
            case PatchEntryOpType.Remove:
            {
                // Skip block
                var s_Header = new CodecHeader(m_BaseReader);
                m_BaseReader.Seek(s_Header.PackedSize, SeekOrigin.Current);
                
                //TODO: Decrease patchoplength by 1
                break;
            }
        }

        return p_Data != null;
    }
    */
}