using System.IO;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite.Storage.Cas
{
    public class CatalogEntry : IFbSerializable
    {
        public Sha1 Hash { get; set; }
        public uint FileOffset { get; set; }
        public uint FileSize { get; set; }
        public uint FileNumber { get; set; }
        public Catalog ContainedCatalog { get; set; }

        public CatalogEntry(Catalog p_ContainedCatalog)
        {
            Hash = new Sha1();
            FileOffset = 0;
            FileSize = 0;
            FileNumber = 0;
            ContainedCatalog = p_ContainedCatalog;
        }

        public CatalogEntry(RimeReader p_Reader, Catalog p_ContainedCatalog)
        {
            Hash = new Sha1();
            ContainedCatalog = p_ContainedCatalog;
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            if (!Hash.Serialize(p_Writer))
                return false;

            p_Writer.Write(FileOffset);
            p_Writer.Write(FileSize);
            p_Writer.Write(FileNumber);

            return true;
        }

        public bool Serialize(out byte[] p_Data)
        {
            p_Data = new byte[0];

            using (var s_Writer = new RimeWriter(new MemoryStream()))
            {
                if (!Hash.Serialize(s_Writer))
                    return false;

                s_Writer.Write(FileOffset);
                s_Writer.Write(FileSize);
                s_Writer.Write(FileNumber);

                p_Data = ((MemoryStream) s_Writer.BaseStream).ToArray();
            }

            return true;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            Hash = new Sha1(p_Reader);
            FileOffset = p_Reader.ReadUInt32();
            FileSize = p_Reader.ReadUInt32();
            FileNumber = p_Reader.ReadUInt32(); // BF4 its char with 3 bytes padding?
        }

        public void Deserialize(byte[] p_Data)
        {
            Deserialize(new RimeReader(new MemoryStream(p_Data)));
        }
    }
}
