using System.IO;
using RimeLib.Content.Venice.Frostbite.Sb;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Venice.Frostbite.Chunks
{
    class SbChunkEntry : ChunkEntry
    {
        public long Offset { get; }
        public long Size { get; }
        public SuperbundleEntry ContainedSuperbundle { get; }
        public bool InPatch { get; }

        public SbChunkEntry(GUID p_Id, long p_Offset, long p_Size, SuperbundleEntry p_ContainedSb, bool p_InPatch) : 
            base(p_Id)
        {
            Offset = p_Offset;
            Size = p_Size;
            ContainedSuperbundle = p_ContainedSb;
            InPatch = p_InPatch;
        }

        public override RimeReader GetReader()
        {
            var s_Endianness = ContainedSuperbundle.Toc.Layout.Cas ? Endianness.LittleEndian : Endianness.BigEndian;

            if (!InPatch)
            {
                var s_Reader = new RimeReader(File.Open(ContainedSuperbundle.Path + ".sb", FileMode.Open, FileAccess.Read, FileShare.Read), s_Endianness);
                s_Reader.Seek(Offset, SeekOrigin.Begin);
                return s_Reader;
            }

            var s_PatchReader = new RimeReader(File.Open(ContainedSuperbundle.PatchPath + ".sb", FileMode.Open, FileAccess.Read, FileShare.Read), s_Endianness);
            s_PatchReader.Seek(Offset, SeekOrigin.Begin);
            return s_PatchReader;
        }

        public override long GetSize()
        {
            return Size;
        }
    }
}
