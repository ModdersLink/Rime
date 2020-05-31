namespace RimeLib.Serialization.Ebx
{
    public enum FlagMasks : ushort
    {
        MemberTypeMask = 0x3,
        TypeCategoryShift = 0x2,
        TypeCategoryMask = 0x3,
        TypeCodeShift = 0x4,
        TypeCodeMask = 0x1F,
        Metadata = 0x800,
        Homogeneous = 0x1000,
        AlwaysPersist = 0x2000,
        Exposed = 0x2000,
        LayoutImmutable = 0x4000,
        Blittable = 0x8000,
    }
}
