using System;

namespace RimeLib.Frostbite.Db
{
    /// <summary>
    /// Database object types
    /// </summary>
    [Flags]
    public enum DbObjectType : byte
    {
        /// <summary>
        /// End of object marker
        /// </summary>
        Eoo = 0x00,

        /// <summary>
        /// TODO
        /// </summary>
        InternalMin = 0x00,

        /// <summary>
        /// Array object maker
        /// </summary>
        Array = 0x01,

        /// <summary>
        /// Object maker
        /// </summary>
        Object = 0x02,

        /// <summary>
        /// TODO
        /// </summary>
        HomoArray = 0x03,

        /// <summary>
        /// Null marker
        /// </summary>
        Null = 0x04,            // Size: 0

        /// <summary>
        /// Object identifier maker
        /// </summary>
        ObjectId = 0x05,        // Size: 12

        /// <summary>
        /// Boolean marker
        /// </summary>
        Bool = 0x06,            // Size: 1

        /// <summary>
        /// String maker
        /// </summary>
        String = 0x07,

        /// <summary>
        /// 32-bit integer marker
        /// </summary>
        Integer = 0x08,         // Size: 4

        /// <summary>
        /// 64-bit integer maker
        /// </summary>
        Long = 0x09,            // Size: 8

        /// <summary>
        /// Variable integer marker
        /// </summary>
        VarInt = 0x0A,

        /// <summary>
        /// 32-bit floating point marker
        /// </summary>
        Float = 0x0B,           // Size: 4

        /// <summary>
        /// 64-bit floating point marker
        /// </summary>
        Double = 0x0C,          // Size: 8

        /// <summary>
        /// Timestamp marker
        /// </summary>
        Timestamp = 0x0D,       // Size: 8

        /// <summary>
        /// Record identifier marker
        /// </summary>
        RecordId = 0x0E,        // Size: 6

        /// <summary>
        /// Globally unique identifier marker
        /// </summary>
        Guid = 0x0F,            // Size: 16

        /// <summary>
        /// Hash marker
        /// </summary>
        Sha1 = 0x10,            // Size: 20

        /// <summary>
        /// 4x4 matrix marker
        /// </summary>
        Matrix44 = 0x11,      
        
        /// <summary>
        /// Vec4 marker
        /// </summary>
        Vector4 = 0x12,     
        
        /// <summary>
        /// Data blob marker
        /// </summary>
        Blob = 0x13,

        /// <summary>
        /// TODO
        /// </summary>
        Attachment = 0x14,      // Size: 20

        /// <summary>
        /// Timespan marker
        /// </summary>
        Timespan = 0x15,
        
        /// <summary>
        /// TODO
        /// </summary>
        StrongAtom = 0x16, 
        
        /// <summary>
        /// TODO
        /// </summary>
        TypedBlob = 0x17, 
        
        /// <summary>
        /// TODO
        /// </summary>
        Environment = 0x18, 
        

        /// <summary>
        /// TODO
        /// </summary>
        InternalMax = 0x1F,

        /// <summary>
        /// General object type mask
        /// </summary>
        Mask = 0x1F,

        /// <summary>
        /// This is a set for anonymous type
        /// </summary>
        Anonymous = 0x80
    }
}
