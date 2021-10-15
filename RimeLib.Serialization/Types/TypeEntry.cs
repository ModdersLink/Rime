using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Serialization.Types
{
    public class TypeEntry
    {
        /// <summary>
        /// Inherited type
        /// </summary>
        public TypeEntry? InheritedType { get; set; }

        /// <summary>
        /// Frostbite specific flags
        /// </summary>
        public ushort Flags { get; set; }

        /// <summary>
        /// Size of this type
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Alignment of this type
        /// </summary>
        public int Alignment { get; set; }

        /// <summary>
        /// Name of this type
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Fields
        /// </summary>
        public List<FieldEntry> Fields { get; set; }

        public TypeEntry()
        {
            Name = string.Empty;
            InheritedType = null;
            Fields = new List<FieldEntry>();
        }
    }
}
