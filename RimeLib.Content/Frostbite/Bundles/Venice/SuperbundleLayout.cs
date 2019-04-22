using RimeLib.Frostbite.Db;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite.Bundles.Venice
{
    /// <summary>
    /// Implementation for a Venice (Battlefield 3) SuperbundleLayout
    /// </summary>
    public class SuperbundleLayout : Bundles.SuperbundleLayout
    {
        /// <summary>
        /// Constructor for handling Venice specific superbundles
        /// </summary>
        /// <param name="p_Reader">Opened reader to the superbundle layout data</param>
        /// <param name="p_Entry">Entry information for this superbundle layout</param>
        /// <param name="p_Authoritative">Is this superbundle layout authoritative</param>
        public SuperbundleLayout(RimeReader p_Reader, SuperbundleEntry p_Entry, bool p_Authoritative)
            : base(p_Reader, p_Entry, p_Authoritative)
        {
        }

        /// <summary>
        /// Parses the superbundle layout for Venice (Battlefield 3) superbundles
        /// Reads out the bundle, chunk entries (things that are in a superbundle)
        /// </summary>
        /// <param name="p_Object"></param>
        protected override void ParseLayout(DbObject p_Object)
        {
            if (p_Object.HasKey("bundles") && p_Object["bundles"].Value is DbObject s_Bundles)
            {
                for (var i = 0; i < s_Bundles.Count; ++i)
                {
                    var s_BundleEntry = new BundleEntry(s_Bundles[i].Value as DbObject, this);
                    BundleEntries.TryAdd(s_BundleEntry.Id.ToLowerInvariant(), s_BundleEntry);
                }
            }
            
            if (p_Object.HasKey("chunks") && p_Object["chunks"].Value is DbObject s_Chunks)
            {
                for (var i = 0; i < s_Chunks.Count; ++i)
                {
                    var s_ChunkEntry = new ChunkEntry(s_Chunks[i].Value as DbObject, this);
                    ChunkEntries.TryAdd(s_ChunkEntry.ID, s_ChunkEntry);
                }
            }
        }
    }
}
