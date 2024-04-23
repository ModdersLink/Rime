using System.Collections.Concurrent;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Fs;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2014_4.Frostbite.Cas;

 /// <summary>
/// Structure for content addressable storage catalogs
/// </summary>
public class Catalog
{
    /// <summary>
    /// Entries by hash within this catalog
    /// </summary>
    public ConcurrentDictionary<Sha1, CatalogEntry> Entries { get; } = new ();

    public ConcurrentDictionary<int, CatalogEntry> IndexEntries { get; } = new();

    /// <summary>
    /// Authoritative catalog
    /// </summary>
    public Catalog? AuthoritativeCatalog { get; set; }

    /// <summary>
    /// Path to this catalog
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// Constructor that parses a catalog from an opened reader
    /// </summary>
    /// <param name="p_Path">Path to the catalog file</param>
    public Catalog(string p_Path)
    {
        Path = p_Path;
        using var s_Reader = new RimeReader(File.Open(Path, FileMode.Open, FileAccess.Read));
        ParseHeader(s_Reader);
    }

    /// <summary>
    /// Parses the catalog header information
    /// </summary>
    /// <param name="p_Reader">Reader opened to the position of the catalog header</param>
    protected void ParseHeader(RimeReader p_Reader)
    {
        // read FileObfuscation, and use the output stream
        FileObfuscation.Deserialize(p_Reader, out var s_FixedReader, out _, true);
        


        var s_NyanNyan01 = s_FixedReader.ReadUInt64();
        var s_NyanNyan02 = s_FixedReader.ReadUInt64();

        // NyanNyanNyanNyan
        if (s_NyanNyan01 != 0x6E61794E6E61794E ||
            s_NyanNyan02 != 0x6E61794E6E61794E)
            throw new Exception("The provided file is not a valid catalog file.");

        ParseEntries(s_FixedReader);
    }

    /// <summary>
    /// Parses the catalog entries
    /// </summary>
    /// <param name="p_Reader">Reader opened to the position of the catalog entries</param>
    protected void ParseEntries(RimeReader p_Reader)
    {
        var s_EntryCount = p_Reader.ReadInt32();
        var s_UnkCount = p_Reader.ReadInt32();
        
        for(var s_Index = 0; s_Index < s_EntryCount; s_Index++)
        {
            var s_Entry = new CatalogEntry(p_Reader, this);
            Entries.TryAdd(s_Entry.Hash, s_Entry);
            IndexEntries.TryAdd(s_Index, s_Entry);
        }


        for (var s_Index = 0; s_Index < s_UnkCount; s_Index++)
        {
            var s_Hash1 = new Sha1(p_Reader);
            var s_Hash2 = new Sha1(p_Reader);
            var s_Hash3 = new Sha1(p_Reader);
        }
        
        // array of unkcount here
    }

    /// <summary>
    /// Does this catalog contain a certain hash
    /// </summary>
    /// <param name="p_Hash">Hash to check for</param>
    /// <returns>True if this catalog contains the specified hash, false otherwise</returns>
    public bool ContainsEntry(Sha1 p_Hash)
    {
        return Entries.ContainsKey(p_Hash);
    }


    public bool TryGetEntry(Sha1 p_Hash, out CatalogEntry p_Out)
    {
        return Entries.TryGetValue(p_Hash, out p_Out);
    }

    /// <summary>
    /// Opens a reader for a specific entry.
    /// </summary>
    /// <param name="p_Hash">Hash of the entry</param>
    /// <returns>A reader that can be used to read the contents of the entry</returns>
    public RimeReader ReadEntry(Sha1 p_Hash)
    {
        // If we have an authoritative catalog check that first.
        if (AuthoritativeCatalog != null && AuthoritativeCatalog.ContainsEntry(p_Hash))
            return AuthoritativeCatalog.ReadEntry(p_Hash);

        // Otherwise check if we have this entry.
        if (!ContainsEntry(p_Hash))
            throw new Exception("Tried opening a reader for a catalog entry with a nonexistent hash.");

        // Get the entry.
        var s_Entry = this[p_Hash];

        // Construct the path to the cas file.
        var s_Path = System.IO.Path.Join(System.IO.Path.GetDirectoryName(Path), $"cas_{s_Entry.FileNumber:D2}.cas");

        // Open a reader.
        var s_Reader = new RimeReader(File.Open(s_Path, FileMode.Open, FileAccess.Read, FileShare.Read));
        s_Reader.Seek(s_Entry.FileOffset, SeekOrigin.Begin);

        // Wrap in a limited reader.
        s_Reader = new LimitedRimeReader(s_Reader, s_Entry.FileSize);

        return s_Reader;
    }

    /// <summary>
    /// Indexer via hash
    /// </summary>
    /// <param name="p_Hash">Hash</param>
    /// <returns>CatalogEntry if hash is found, null otherwise</returns>
    public CatalogEntry this[Sha1 p_Hash]
    {
        get
        {
            if (AuthoritativeCatalog != null && AuthoritativeCatalog.ContainsEntry(p_Hash))
                return AuthoritativeCatalog[p_Hash];

            if (!Entries.TryGetValue(p_Hash, out var s_Entry))
                throw new Exception("Tried retrieving a catalog entry with an nonexistent hash.");

            return s_Entry;
        }
        set
        {
            value.ContainedCatalog = this;
            Entries.AddOrUpdate(p_Hash, value, (p_K, p_V) => value);
        }
    }
}