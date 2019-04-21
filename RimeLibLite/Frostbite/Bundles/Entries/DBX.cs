using System;

namespace RimeLib.Frostbite.Bundles.Entries
{
    /// <summary>
    /// Abstract class for dbx entries
    /// </summary>
    public abstract class Dbx : EntryBase
    {
        /// <summary>
        /// Name of the dbx
        /// </summary>
        public String Name { get; set; }
    }
}
