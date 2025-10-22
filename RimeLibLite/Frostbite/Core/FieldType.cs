namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Ebx field types
    /// </summary>
    public enum FieldType
    {
        /// <summary>
        /// TODO
        /// </summary>
        Void,

        /// <summary>
        /// DbObject field type
        /// </summary>
        DbObject,

        /// <summary>
        /// Value type
        /// </summary>
        ValueType,

        /// <summary>
        /// Class type
        /// </summary>
        Class,

        /// <summary>
        /// Array type
        /// </summary>
        Array,

        /// <summary>
        /// Fixed size array type
        /// </summary>
        FixedArray,

        /// <summary>
        /// String type
        /// </summary>
        String,

        /// <summary>
        /// TODO
        /// </summary>
        CString,

        /// <summary>
        /// Enumeration type
        /// </summary>
        Enum,

        /// <summary>
        /// File reference type
        /// </summary>
        FileRef,

        /// <summary>
        /// Boolean type
        /// </summary>
        Boolean,

        /// <summary>
        /// 8 bit signed integer type
        /// </summary>
        Int8,

        /// <summary>
        /// 8 bit unsigned integer type
        /// </summary>
        UInt8,

        /// <summary>
        /// 16 bit signed integer type
        /// </summary>
        Int16,

        /// <summary>
        /// 16 bit unsigned integer type
        /// </summary>
        UInt16,

        /// <summary>
        /// 32 bit integer type
        /// </summary>
        Int32,

        /// <summary>
        /// 32 bit unsigned integer type
        /// </summary>
        UInt32,

        /// <summary>
        /// 64 bit signed integer type
        /// </summary>
        Int64,

        /// <summary>
        /// 64 bit unsigned integer type
        /// </summary>
        UInt64,

        /// <summary>
        /// 32 bit floating point type
        /// </summary>
        Float32,

        /// <summary>
        /// 64 bit floating point type
        /// </summary>
        Float64,

        /// <summary>
        /// Globally unique identifier type
        /// </summary>
        Guid,

        /// <summary>
        /// Hash type
        /// </summary>
        Sha1,

        /// <summary>
        /// Resource reference type
        /// Added in Warsaw/fb2013
        /// </summary>
        ResourceRef,

        
        /// <summary>
        /// Function/Delegate | Functiontypeinfo stuff
        /// Added around fb2017
        /// </summary>
        Function,
        
        /// <summary>
        /// Type reference type
        /// Added around fb2017
        /// </summary>
        TypeRef,

        /// <summary>
        /// Boxed value refrerence
        /// Added around fb2017
        /// </summary>
        BoxedValueRef,
        

        /// <summary>
        /// interface
        /// Added around fb2017 or fb2018
        /// </summary>
        Interface,
        
        /// <summary>
        /// Delegate 
        /// Added around fb2017 or fb2018
        /// </summary>
        Delegate,
    }
}
