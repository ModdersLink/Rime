using System;
using System.IO;
using RimeLib.Frostbite.Db;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite.Storage.Sb
{
    public class TableOfContents<T> where T : DbObjectSerializable, new()
    {
        public T Layout { get; }

        public TableOfContents(RimeReader p_Reader)
        {
            var s_Magic = p_Reader.ReadUInt32();

            if (s_Magic == 0x00CED100 ||
                s_Magic == 0x01CED100)
            {
                // Read the signature and enable de-obfuscation by reading the XOR table.
                var s_Signature = p_Reader.ReadBytes(292);
                p_Reader.EnableDeobfuscation();
            }
            else if (s_Magic == 0x03CED100) // Signed
            {
                // Read the signature and skip the empty XOR table.
                var s_Signature = p_Reader.ReadBytes(292);
                p_Reader.Seek(260, SeekOrigin.Current);
            }
            else
            {
                throw new Exception("Could not find valid header magic for ToC file.");
            }

            (Layout, _) = DbObjectConverter.FromDbObjectReader<T>(p_Reader);
        }

        public TableOfContents(T p_Layout)
        {
            Layout = p_Layout;
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            // Write the header and an empty signature.
            p_Writer.Write((uint) 0x00CED100);
            p_Writer.Write(new byte[292]);

            // Enable obfuscation.
            p_Writer.EnableObfuscation(new byte[260]);

            // Serialize the DbObject.
            return DbObjectConverter.ToDbObjectWriter(Layout, p_Writer);
        }
    }
}
