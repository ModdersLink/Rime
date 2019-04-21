using System;

namespace RimeLib.Frostbite.Bundles.Entries
{
    /// <summary>
    /// Abstract class for ebx entry
    /// </summary>
    public abstract class EBX : EntryBase
    {
        /// <summary>
        /// Name of the ebx
        /// </summary>
        public String Name { get; set; }
    }
}
