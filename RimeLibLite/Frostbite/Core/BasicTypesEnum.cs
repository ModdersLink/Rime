namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Basic Frostbite Types
    /// </summary>
    public enum BasicTypesEnum
    {
        /// <summary>
        /// Void
        /// </summary>
        Void = 0x0,

        /// <summary>
        /// DbObject
        /// </summary>
        DbObject = 0x1,

        /// <summary>
        /// ValueType
        /// </summary>
        ValueType = 0x2,

        /// <summary>
        /// Class
        /// </summary>
        Class = 0x3,

        /// <summary>
        /// Array
        /// </summary>
        Array = 0x4,

        /// <summary>
        /// Fixed length array
        /// </summary>
        FixedArray = 0x5,

        /// <summary>
        /// String
        /// </summary>
        String = 0x6,

        /// <summary>
        /// C-Style string
        /// </summary>
        CString = 0x7,

        /// <summary>
        /// Enumeration
        /// </summary>
        Enum = 0x8,

        /// <summary>
        /// File reference
        /// </summary>
        FileRef = 0x9,

        /// <summary>
        /// Boolean
        /// </summary>
        Boolean = 0xA,

        /// <summary>
        /// 8 bit integer
        /// </summary>
        Int8 = 0xB,

        /// <summary>
        /// unsigned 8 bit integer
        /// </summary>
        Uint8 = 0xC,

        /// <summary>
        /// 16 bit integer
        /// </summary>
        Int16 = 0xD,

        /// <summary>
        /// unsigned 16 bit integer
        /// </summary>
        Uint16 = 0xE,

        /// <summary>
        /// 32 bit integer
        /// </summary>
        Int32 = 0xF,

        /// <summary>
        /// unsigned 32 bit integer
        /// </summary>
        Uint32 = 0x10,

        /// <summary>
        /// 64 bit integer
        /// </summary>
        Int64 = 0x11,

        /// <summary>
        /// unsigned 64 bit integer
        /// </summary>
        Uint64 = 0x12,

        /// <summary>
        /// 32 bit floating point
        /// </summary>
        Float32 = 0x13,

        /// <summary>
        /// 64 bit floating point (double)
        /// </summary>
        Float64 = 0x14,

        /// <summary>
        /// Guid
        /// </summary>
        Guid = 0x15,

        /// <summary>
        /// Sha1 hash
        /// </summary>
        Sha1 = 0x16,

        /// <summary>
        /// Type count
        /// </summary>
        BasicTypeCount = 0x17,
    }
}
