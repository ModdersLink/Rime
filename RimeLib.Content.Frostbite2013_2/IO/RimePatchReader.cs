using System.Net;
using RimeLib.Content.Frostbite2013_2.Frostbite.Patch;
using RimeLib.Frostbite.Codec;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Frostbite2013_2.IO;

public class RimePatchReader : RimeReader
{
   

    public override long Position => m_CurrentPosition;
    public override long Length => (ManifestReader?.Length ?? 0) + (EntryReader?.Length ?? 0);
    
    // override endianess
    public new Endianness Endianness
    {
        get => base.Endianness;
        set
        {
            base.Endianness = value;
            
            BaseReader.Endianness = value;
            PatchReader.Endianness = value;            
            
            // TODO: Replace with "[reader]?.Endianess ??= value;" in c#8
            ManifestReader!.Endianness = value;
            EntryReader!.Endianness = value;
        }
    }

    private long m_CurrentPosition;

    public PatchManifest? PatchHeader { get; set; } = null;
    public RimeReader BaseReader { get; set; }
    public RimeReader PatchReader { get; set; }

    public RimePatchManifestReader? ManifestReader { get; set; } = null; 
    public RimePatchEntryReader? EntryReader { get; set; } = null;


    private readonly bool m_InternalDispose;

    //private List<PatchOp<PatchManifestOperation>> m_ManifestPatches;
    //private List<PatchOp<PatchEntryOperation>> m_EntryPatches;


    
    
    public RimePatchReader(RimeReader p_BaseReader, RimeReader p_PatchReader, bool p_ShouldDispose = true)
        : this(p_BaseReader, p_PatchReader, p_BaseReader.Endianness)
    {
    }
    public RimePatchReader(RimeReader p_BaseReader, RimeReader p_PatchReader, Endianness p_Endianness, bool p_ShouldDispose = true)
        : base(new MemoryStream(), p_Endianness)
    {
        m_InternalDispose = p_ShouldDispose;

        BaseReader = p_BaseReader;
        PatchReader = p_PatchReader;
        

        m_CurrentPosition = 0;

        ReadManifest();
    }

    public override void Dispose()
    {
        base.Dispose();

        if (!m_InternalDispose) 
            return;

        BaseReader.Dispose();
        PatchReader.Dispose();
    }

    private void ReadManifest()
    {
        // Do we have enough data for reading the patch header?
        if (PatchReader.BaseStream.Position + 16 > PatchReader.BaseStream.Length)
            throw new Exception("Not enough data found to read patch header. This is probably caused because we tried to parse a non-patch file.");

        

        PatchHeader = new PatchManifest(PatchReader);

        if (PatchHeader.Version != 1)
            throw new InvalidDataException($"Expected patch manifest 1, instead got {PatchHeader.Version}");

        if (PatchHeader.ManifestPatchSize < 4)
            throw new InvalidDataException("Manifest patch size cant be below 4. cant read manifest size!");


        var s_BasePatchPosition = PatchReader.Position;
      
        // Section 1 - Manifest | reads manifest info
        ManifestReader = new RimePatchManifestReader(BaseReader, new LimitedRimeReader(PatchReader, PatchHeader.ManifestPatchSize));

        // Section 2 - Patch    | pached data
        PatchReader.Seek(s_BasePatchPosition + PatchHeader.ManifestPatchSize, SeekOrigin.Begin);
        EntryReader = new RimePatchEntryReader(BaseReader, new LimitedRimeReader(PatchReader, PatchHeader.EntryPatchSize));
    }

    public override long Seek(long p_Offset, SeekOrigin p_Origin)
    {
        CheckDisposed();

        // wtf is this state machinery. Probably needs a cleanup
        if (p_Origin == SeekOrigin.Begin)
        {
            m_CurrentPosition = p_Offset;
            if (p_Offset < ManifestReader.Length)
            {
                EntryReader.Seek(0, SeekOrigin.Begin);
                return ManifestReader.Seek(p_Offset, p_Origin);
            }

            return EntryReader.Seek(p_Offset - ManifestReader.Length, p_Origin) + ManifestReader.Length;
        }
        else if (p_Origin == SeekOrigin.Current)
        {
            m_CurrentPosition += p_Offset;
            
            if (m_CurrentPosition < ManifestReader.Length)
            {
                if (ManifestReader.Position + p_Offset < ManifestReader.Length)
                {
                    EntryReader.Seek(0, SeekOrigin.Begin);
                    return ManifestReader.Seek(p_Offset, p_Origin);
                }

                return EntryReader.Seek(p_Offset - (ManifestReader.Length - ManifestReader.Position), p_Origin) + ManifestReader.Length;
            }
            else
            {
                return EntryReader.Seek(p_Offset, p_Origin) + ManifestReader.Length;
            }
        }

        throw new NotImplementedException();
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

        while (s_Remaining > 0 && 
               Position < Length)
        {
            
            // read what we can, and loop it
            if (m_CurrentPosition < ManifestReader.Length)
            {
                var s_ReadCount = ManifestReader.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining), s_Remaining);

                m_CurrentPosition += s_ReadCount;
                s_Remaining -= s_ReadCount;
            }
            else
            {
                var s_ReadCount = EntryReader.ReadBytes(p_Data, p_Index + (p_Count - s_Remaining),   s_Remaining);

                m_CurrentPosition += s_ReadCount;
                s_Remaining -= s_ReadCount;
            }
        }


        return p_Count - s_Remaining;
    }

}