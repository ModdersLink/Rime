using System;
using System.IO;
using RimeLib.Frostbite.Db;
using RimeLib.Frostbite.Fs;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2_0.Frostbite.Sb
{
    public class TableOfContents<T> where T : DbObjectSerializable, new()
    {
        public T Layout { get; }

        public TableOfContents(RimeReader p_Reader)
        {

            var s_Obfuscation = new FileObfuscation(p_Reader, out var s_FixedReader);

            // this should not always throw, as old toc files doesnt have header (bf3 beta/alpha)
            if (!s_Obfuscation.HasHeader)
                throw new Exception("Could not find valid header magic for ToC file.");
            /*
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
            */

            (Layout, _) = DbObjectConverter.FromDbObjectReader<T>(s_FixedReader);
        }

        public TableOfContents(T p_Layout)
        {
            Layout = p_Layout;
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            var s_Obfuscation = new FileObfuscation();

            if (!DbObjectConverter.ToDbObjectBytes(Layout, out var s_Data))
                return false;

            s_Obfuscation.Serialize(p_Writer, s_Data);

            return true;

            /*
            // Write the header and an empty signature.
            p_Writer.Write((uint) 0x01CED100);
            p_Writer.Write(new byte[292]);

            // Enable obfuscation.
            var s_XorTable = new byte[260];
            
            // We fill this with 123 because that results in the obfuscation
            // not taking place, leaving the data in the file as-is. This is
            // primarily for readability purposes, so it's easier to look at
            // the file in a hex editor or otherwise. It also has the added
            // benefit of making files reproducible.
            for (var i = 0; i < s_XorTable.Length; ++i)
                s_XorTable[i] = 123;
            
            p_Writer.EnableObfuscation(s_XorTable);

            // Serialize the DbObject.
            return DbObjectConverter.ToDbObjectWriter(Layout, p_Writer);
            */
        }
    }
}
