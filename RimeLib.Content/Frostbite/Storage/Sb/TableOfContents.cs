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
                p_Reader.EnableDeobfuscation();
            }
            else if (s_Magic == 0x03CED100) // Signed
            {
                p_Reader.Seek(0x228, SeekOrigin.Current);
            }
            else
            {
                throw new Exception("Could not find valid header magic for ToC file.");
            }

            (Layout, _) = DbObjectConverter.FromDbObjectReader<T>(p_Reader);
        }
    }
}
