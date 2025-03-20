using RimeLib.Frostbite.Db;
using RimeLib.Frostbite.Fs;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2013_2.Frostbite.Sb;

public class TableOfContents<T> where T : DbObjectSerializable, new()
{
    public T Layout { get; }

    public TableOfContents(RimeReader p_Reader)
    {

        FileObfuscation.Deserialize(p_Reader, out var s_FixedReader, out _);


        (Layout, _) = DbObjectConverter.FromDbObjectReader<T>(s_FixedReader);
    }

    public TableOfContents(T p_Layout)
    {
        Layout = p_Layout;
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        if (!DbObjectConverter.ToDbObjectBytes(Layout, out var s_Data))
            return false;

        FileObfuscation.Serialize(p_Writer, s_Data);

        return true;
    }
}