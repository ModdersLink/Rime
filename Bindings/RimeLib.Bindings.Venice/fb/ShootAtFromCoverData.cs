///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ShootAtFromCoverData : 
		EntityData
	{
		[ContainerField(12)]
		public StrengthType StrengthType { get; set; } = new StrengthType(); // 0xC (12)
		
		[ContainerField(16)]
		public ShootType ShootType { get; set; } = new ShootType(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool CycleTargets { get; set; } // 0x14 (20)
		
		[ContainerField(21), LayoutImmutable, Blittable]
		public bool RandomTargetOrder { get; set; } // 0x15 (21)
		
		[ContainerField(22), LayoutImmutable, Blittable]
		public bool PreferAlternativeWeapon { get; set; } // 0x16 (22)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4037075576:
					StrengthType = (StrengthType) Enum.ToObject(typeof(StrengthType), p_Value);
					break;

				case 2888956146:
					ShootType = (ShootType) Enum.ToObject(typeof(ShootType), p_Value);
					break;

				case 2182019831:
					CycleTargets = (bool) p_Value;
					break;

				case 1044980993:
					RandomTargetOrder = (bool) p_Value;
					break;

				case 2914787134:
					PreferAlternativeWeapon = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4037075576:
					return StrengthType;

				case 2888956146:
					return ShootType;

				case 2182019831:
					return CycleTargets;

				case 1044980993:
					return RandomTargetOrder;

				case 2914787134:
					return PreferAlternativeWeapon;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4037075576:
					return typeof(ShootAtFromCoverData).GetProperty(nameof(StrengthType));

				case 2888956146:
					return typeof(ShootAtFromCoverData).GetProperty(nameof(ShootType));

				case 2182019831:
					return typeof(ShootAtFromCoverData).GetProperty(nameof(CycleTargets));

				case 1044980993:
					return typeof(ShootAtFromCoverData).GetProperty(nameof(RandomTargetOrder));

				case 2914787134:
					return typeof(ShootAtFromCoverData).GetProperty(nameof(PreferAlternativeWeapon));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
