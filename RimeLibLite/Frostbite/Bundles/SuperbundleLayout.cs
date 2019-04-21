using System.Collections.Concurrent;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;

namespace RimeLib.Frostbite.Bundles
{
    /// <summary>
    /// Base class for describing a superbundle layout
    /// This should be inherited and parsing should be tweaked per-game/engine
    /// </summary>
    public abstract class SuperbundleLayout
    {
        /// <summary>
        /// This this a content addressable superbundle layout
        /// </summary>
        public bool Cas { get; set; }
        
        /// <summary>
        /// Name of the superbundle
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Unknown what this actually does or is
        /// Is present in the superbundle object
        /// </summary>
        public bool AlwaysEmitSuperbundle { get; set; }

        /// <summary>
        /// Chunk entries by guid
        /// </summary>
        public ConcurrentDictionary<GUID, ChunkEntry> ChunkEntries { get; private set; }

        /// <summary>
        /// Bundle entries by name
        /// </summary>
        public ConcurrentDictionary<string, BundleEntry> BundleEntries { get; private set; }

        /// <summary>
        /// Entry information of this superbundle
        /// </summary>
        public SuperbundleEntry Entry { get; set; }

        /// <summary>
        /// Is this superbundle authoritative
        /// </summary>
        public bool Authoritative { get; set; }

        /// <summary>
        /// Constructor for reading a DbObject with a reader, information is provided by the superbundle entry
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of the superbundle layout object</param>
        /// <param name="p_Entry">Entry information about this superbundle</param>
        /// <param name="p_Authoritative">Is this superbundle authoritative (patch)</param>
        protected SuperbundleLayout(RimeReader p_Reader, SuperbundleEntry p_Entry, bool p_Authoritative)
        {
            Entry = p_Entry;
            Authoritative = p_Authoritative;

            ParseBasicLayout(new DbObject(p_Reader)[0].Value as DbObject);
        }

        /// <summary>
        /// Constructor for parsing a DbObject, information is provided by the superbundle entry
        /// </summary>
        /// <param name="p_Object">DbObject containing the superbundle layout information</param>
        /// <param name="p_Entry">Entry information about this superbundle</param>
        /// <param name="p_Authoritative">Is this superbundle authoritative (patch)</param>
        protected SuperbundleLayout(DbObject p_Object, SuperbundleEntry p_Entry, bool p_Authoritative)
        {
            Entry = p_Entry;
            Authoritative = p_Authoritative;

            ParseBasicLayout(p_Object[0].Value as DbObject);
        }

        /// <summary>
        /// Parses the superbundle layout, reads out if this is a cas sb, name, alwaysEmitSuperbundle then parses the layout
        /// </summary>
        /// <param name="p_Object">DbObject containing the superbundle layout information</param>
        private void ParseBasicLayout(DbObject p_Object)
        {
            ChunkEntries = new ConcurrentDictionary<GUID, ChunkEntry>();
            BundleEntries = new ConcurrentDictionary<string, BundleEntry>();

            var s_CasObject = p_Object["cas"];
            Cas = s_CasObject != null && (bool)s_CasObject.Value;

            var s_NameObject = p_Object["name"];

            if (s_NameObject != null)
                Name = (string)s_NameObject.Value;

            var s_EmitObject = p_Object["alwaysEmitSuperbundle"];

            if (s_EmitObject != null)
                AlwaysEmitSuperbundle = (bool)s_EmitObject.Value;

            ParseLayout(p_Object);
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>Returns the name of the superbundle, or a representation of this object</returns>
        public override string ToString()
        {
            return !string.IsNullOrWhiteSpace(Name) ? Name : base.ToString();
        }

        /// <summary>
        /// Gets the path of this superbundle
        /// </summary>
        /// <returns></returns>
        public string GetPath()
        {
            return Authoritative ? Entry.PatchPath : Entry.BasePath;
        }

        /// <summary>
        /// This parses the actual layout information, this can vary from game/engine
        /// </summary>
        /// <param name="p_Object">DbObject containing the superbundle layout information</param>
        protected abstract void ParseLayout(DbObject p_Object);
    }
}
