using System.IO;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite.Storage
{
    public class CatalogEntry : IFbSerializable
    {
        public Sha1 Hash { get; set; }
        public uint FileOffset { get; set; }
        public uint FileSize { get; set; }
        public uint FileNumber { get; set; }
        public Catalog ContainedCatalog { get; set; }
        public string FilePath => GetFilePath();

        public CatalogEntry()
        {
            Hash = new Sha1();
            FileOffset = 0;
            FileSize = 0;
            FileNumber = 0;
        }

        public CatalogEntry(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        protected string GetFilePath()
        {
            var s_CatalogName = (string.IsNullOrWhiteSpace(ContainedCatalog.Name) ? "cas" : ContainedCatalog.Name);

            if (ContainedCatalog.AuthoritativePackage == null)
                return "/game/Data/" + s_CatalogName + "_" + FileNumber.ToString("D2") + ".cas";

            return "/game" + ContainedCatalog.AuthoritativePackage.Path + "/Data/" + s_CatalogName + "_" + FileNumber.ToString("D2") + ".cas";
        }

        public void Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(Hash.Serialize());
            p_Writer.Write(FileOffset);
            p_Writer.Write(FileSize);
            p_Writer.Write(FileNumber);
        }

        public byte[] Serialize()
        {
            byte[] s_Data;
            using (var s_Writer = new RimeWriter(new MemoryStream()))
            {
                s_Writer.Write(Hash.Serialize());
                s_Writer.Write(FileOffset);
                s_Writer.Write(FileSize);
                s_Writer.Write(FileNumber);
                s_Data = ((MemoryStream)s_Writer.BaseStream).ToArray();
            }
            return s_Data;
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
