using System;
using System.Collections.Concurrent;
using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Frostbite.Bundles
{
    /// <summary>
    /// Base abstract class for representing a generic Frostbite superbundle object
    /// </summary>
    public abstract class SuperbundleBase : IDisposable
    {
        /// <summary>
        /// The chunk entry information, linked by guid
        /// </summary>
        public ConcurrentDictionary<GUID, ChunkEntry> ChunkEntries { get; set; }

        /// <summary>
        /// Bundle entry information, linked by bundle name (path)
        /// </summary>
        public ConcurrentDictionary<string, BundleEntry> BundleEntries { get; set; }

        /// <summary>
        /// Bundles collection, linked by bundle name (path)
        /// </summary>
        public ConcurrentDictionary<string, BundleBase> Bundles { get; set; } 

        /// <summary>
        /// The base layout for this superbundle
        /// </summary>
        public SuperbundleLayout BaseLayout { get; set; }

        /// <summary>
        /// The authoritative layout for this superbundle (patched)
        /// </summary>
        public SuperbundleLayout? AuthoritativeLayout { get; set; }

        /// <summary>
        /// The base path for this superbundle
        /// </summary>
        public string BasePath => BaseLayout.Entry.BasePath;

        /// <summary>
        /// The patched path for this superbundle
        /// </summary>
        public string PatchPath => BaseLayout.Entry.PatchPath;

        /// <summary>
        /// The name (path) of this superbundle
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Constructor for a superbundle object
        /// </summary>
        /// <param name="p_BaseLayout">The layout for describing this superbundle</param>
        /// <param name="p_AuthoritativeLayout">The authoritative layout for describing the superbundle patch</param>
        protected SuperbundleBase(SuperbundleLayout p_BaseLayout, SuperbundleLayout? p_AuthoritativeLayout = null)
        {
            BaseLayout = p_BaseLayout;
            AuthoritativeLayout = p_AuthoritativeLayout;

            ChunkEntries = new ConcurrentDictionary<GUID, ChunkEntry>();
            BundleEntries = new ConcurrentDictionary<string, BundleEntry>();

            Bundles = new ConcurrentDictionary<string, BundleBase>();

            Name = BaseLayout.Name;
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>Returns the name of the superbundle</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Frees resources used by this superbundle
        /// </summary>
        public abstract void Dispose();

        /// <summary>
        /// Superbundle equals comparison
        /// </summary>
        /// <param name="other">Other superbundle to compare to</param>
        /// <returns>True if equal, false otherwise</returns>
        protected bool Equals(SuperbundleBase other)
        {
            return string.Equals(Name, other.Name);
        }

        /// <summary>
        /// Superbundle equals comparison
        /// </summary>
        /// <param name="p_Obj">Other superbundle to compare to</param>
        /// <returns>True if equal, false otherwise</returns>
        public override bool Equals(object p_Obj)
        {
            if (ReferenceEquals(null, p_Obj))
                return false;

            if (ReferenceEquals(this, p_Obj))
                return true;

            if (p_Obj.GetType() != GetType())
                return false;

            return Equals((SuperbundleBase) p_Obj);
        }

        /// <summary>
        /// Gets the hash code of the superbundle name
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }

        /// <summary>
        /// Superbundle equals operator
        /// </summary>
        /// <param name="p_Left">Superbundle</param>
        /// <param name="p_Right">Superbundle</param>
        /// <returns>True if equal, false otherwise</returns>
        public static bool operator ==(SuperbundleBase p_Left, SuperbundleBase p_Right)
        {
            return Equals(p_Left, p_Right);
        }

        /// <summary>
        /// Superbundle not equals operator
        /// </summary>
        /// <param name="p_Left">Superbundle</param>
        /// <param name="p_Right">Superbundle</param>
        /// <returns>True if not equal, false otherwise</returns>
        public static bool operator !=(SuperbundleBase p_Left, SuperbundleBase p_Right)
        {
            return !Equals(p_Left, p_Right);
        }
    }
}
