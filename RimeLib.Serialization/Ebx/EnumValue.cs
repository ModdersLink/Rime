using System;

namespace RimeLib.Serialization.Ebx
{
    /// <summary>
    /// Enumeration value
    /// </summary>
    public class EnumValue
    {
        /// <summary>
        /// Value type
        /// </summary>
        public UInt16 Type { get; set; }

        /// <summary>
        /// Values value
        /// </summary>
        public UInt32 Value { get; set; }
    }
}
