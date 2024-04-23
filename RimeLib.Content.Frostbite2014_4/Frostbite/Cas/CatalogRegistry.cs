using System.Collections.Concurrent;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2014_4.Frostbite.Cas;

public class CatalogRegistry
{
	public ConcurrentDictionary<Sha1, MultipleCatalogEntry> CombinedEntries { get; set; } = new();
    public ConcurrentDictionary<GUID, Catalog> Catalogs { get; set; } = new();
	
	
	public void AddCatalog(GUID p_Id, Catalog p_Entry)
    {
        Catalogs.AddOrUpdate(p_Id, p_Entry, (p_K, p_V) => p_Entry);
        
		Parallel.ForEach(p_Entry.Entries, p_Pair => CombinedEntries.AddOrUpdate(p_Pair.Key, new MultipleCatalogEntry(p_Pair.Value), (p_K, p_V) =>
        {
            // does addentry need to be multithreading safe? 
            p_V.AddEntry(p_Pair.Value);
            return p_V;
        }));
	}
	
    /// <summary>
    /// Gets catalog containing a hash
    /// </summary>
    /// <param name="p_Hash">Hash to check for</param>
    /// <returns>True if this catalog contains the specified hash, false otherwise</returns>
    public Catalog? GetContainingCatalog(Sha1 p_Hash)
    {
        if (!CombinedEntries.TryGetValue(p_Hash, out var s_Entry))
            return null;

        return s_Entry.FirstEntry.ContainedCatalog;
    }
    
	/// <summary>
    /// Does this catalog contain a certain hash
    /// </summary>
    /// <param name="p_Hash">Hash to check for</param>
    /// <returns>True if this catalog contains the specified hash, false otherwise</returns>
    public bool ContainsEntry(Sha1 p_Hash)
    {
        return CombinedEntries.ContainsKey(p_Hash);
    }


    public bool TryGetEntry(Sha1 p_Hash, out MultipleCatalogEntry p_Out)
    {
        return CombinedEntries.TryGetValue(p_Hash, out p_Out);
    }
    
   

    /// <summary>
    /// Opens a reader for a specific entry.
    /// </summary>
    /// <param name="p_Hash">Hash of the entry</param>
    /// <returns>A reader that can be used to read the contents of the entry</returns>
    public RimeReader ReadEntry(Sha1 p_Hash)
    {
        //TODO: this does lookup 2 times. 
        
        if (!CombinedEntries.TryGetValue(p_Hash, out var s_Entry))
            throw new Exception($"Could not find catalog entry for {p_Hash}");

        
        return s_Entry.FirstEntry.ContainedCatalog.ReadEntry(p_Hash);
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
            return GetContainingCatalog(p_Hash)?[p_Hash] ??
                   throw new Exception("Tried retrieving a catalog entry with an nonexistent hash.");
        }
        set
        {
            throw new Exception();
        }
    }
}