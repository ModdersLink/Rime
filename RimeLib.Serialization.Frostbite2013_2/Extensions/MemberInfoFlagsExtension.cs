using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Serialization.Frostbite2013_2.Extensions;

public static class MemberInfoFlagsExtension
{
	public enum MemberInfoFlagsEnum
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
	};



	public static void SetFromFlagBits(this MemberInfoFlags p_Flags, ushort p_FlagBits)
	{
		p_Flags.Member = (MemberType)((p_FlagBits >> 0) & (uint)MemberInfoFlagsEnum.MemberTypeMask);
		p_Flags.Category = (TypeCategory)((p_FlagBits >> (int)MemberInfoFlagsEnum.TypeCategoryShift) & (uint)MemberInfoFlagsEnum.TypeCategoryMask);
		p_Flags.Type = (FieldType)((p_FlagBits >> (int)MemberInfoFlagsEnum.TypeCodeShift) & (uint)MemberInfoFlagsEnum.TypeCodeMask);

		p_Flags.Metadata = (p_FlagBits & (uint)MemberInfoFlagsEnum.Metadata) != 0;
		p_Flags.Homogeneous = (p_FlagBits & (uint)MemberInfoFlagsEnum.Homogeneous) != 0;
		p_Flags.AlwaysPersist = (p_FlagBits & (uint)MemberInfoFlagsEnum.AlwaysPersist) != 0;
		p_Flags.Exposed = (p_FlagBits & (uint)MemberInfoFlagsEnum.Exposed) != 0;
		p_Flags.LayoutImmutable = (p_FlagBits & (uint)MemberInfoFlagsEnum.LayoutImmutable) != 0;
		p_Flags.Blittable = (p_FlagBits & (uint)MemberInfoFlagsEnum.Blittable) != 0;
	}
	
	public static ushort ToFlagBits(this MemberInfoFlags p_Flags)
	{
		ushort s_FlagBits = 0;

		s_FlagBits |=  (ushort)(((uint)p_Flags.Member & (uint)MemberInfoFlagsEnum.MemberTypeMask) << 0);
		s_FlagBits |=  (ushort)(((uint)p_Flags.Category & (uint)MemberInfoFlagsEnum.TypeCategoryMask) << (int)MemberInfoFlagsEnum.TypeCategoryShift);
		s_FlagBits |=  (ushort)(((uint)p_Flags.Type & (uint)MemberInfoFlagsEnum.TypeCodeMask) << (int)MemberInfoFlagsEnum.TypeCodeShift);
		
		s_FlagBits |= p_Flags.Metadata ?  (ushort)MemberInfoFlagsEnum.Metadata : (ushort)0;
		s_FlagBits |= p_Flags.Homogeneous ? (ushort)MemberInfoFlagsEnum.Homogeneous : (ushort)0;
		s_FlagBits |= p_Flags.AlwaysPersist ? (ushort)MemberInfoFlagsEnum.AlwaysPersist : (ushort)0;
		s_FlagBits |= p_Flags.Exposed ? (ushort)MemberInfoFlagsEnum.Exposed : (ushort)0;
		s_FlagBits |= p_Flags.LayoutImmutable ? (ushort)MemberInfoFlagsEnum.LayoutImmutable : (ushort)0;
		s_FlagBits |= p_Flags.Blittable ? (ushort)MemberInfoFlagsEnum.Blittable : (ushort)0;

		return s_FlagBits;
	}

	public static void Deserialize(this MemberInfoFlags p_Flags, RimeReader p_Reader)
	{
		var s_FlagBits = p_Reader.ReadUInt16();

		p_Flags.SetFromFlagBits(s_FlagBits);
	}
	
	public static void Serialize(this MemberInfoFlags p_Flags, RimeWriter p_Writer)
	{
		p_Writer.Write(p_Flags.ToFlagBits());
	}
}