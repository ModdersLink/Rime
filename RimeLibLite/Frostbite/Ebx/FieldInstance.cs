using System;

namespace RimeLib.Serialization.Ebx
{
    /// <summary>
    /// Field instance
    /// </summary>
    public class FieldInstance
    {
        /// <summary>
        /// Field descriptor
        /// </summary>
        public FieldDescriptor? Descriptor { get; set; }

        /// <summary>
        /// Value of this field
        /// </summary>
        public Object? Value { get; set; }
    }
}
