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

            RimeReader s_Reader;

            if (!InPatch)
            {
                s_Reader = new RimeReader(File.Open(ContainedSuperbundle.Path + ".sb", FileMode.Open, FileAccess.Read, FileShare.Read), s_Endianness);
                s_Reader.Seek(Offset, SeekOrigin.Begin);
            }
            else
            {
                s_Reader = new RimeReader(
                    File.Open(ContainedSuperbundle.PatchPath + ".sb", FileMode.Open, FileAccess.Read, FileShare.Read), 
                    s_Endianness
                );

                s_Reader.Seek(Offset, SeekOrigin.Begin);
            }

            // Wrap in a limited reader.
            s_Reader = new LimitedRimeReader(s_Reader, Size);

            // If we're compressed, wrap in a Zlib reader.
            if (Compressed)
            {
                s_Reader = new ZlibRimeReader(s_Reader);

                // Wrap this inside a limited reader as well.
                s_Reader = new LimitedRimeReader(s_Reader, s_Reader.Length);;
            }

            return s_Reader;
        }

        public override long GetSize()
        {
            if (!Compressed)
                return Size;

            using var s_Reader = GetReader();
            return s_Reader.Length;
        }

        public override Sha1? GetSha1()
        {
            return null;
        }
    }
}
