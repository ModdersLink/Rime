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
	public class ShootOrderEntityData : 
		BFOrderEntityData
	{
		[ContainerField(40)]
		public StrengthType StrengthType { get; set; } = new StrengthType(); // 0x28 (40)
		
		[ContainerField(44)]
		public PoseType Pose { get; set; } = new PoseType(); // 0x2C (44)
		
		[ContainerField(48)]
		public ShootType ShootType { get; set; } = new ShootType(); // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public bool PreferAlternativeWeapon { get; set; } // 0x34 (52)
		
		[ContainerField(53), LayoutImmutable, Blittable]
		public bool CompleteWhenHumanIsSensed { get; set; } // 0x35 (53)
		
		[ContainerField(54), LayoutImmutable, Blittable]
		public bool CycleTargets { get; set; } // 0x36 (54)
		
		[ContainerField(55), LayoutImmutable, Blittable]
		public bool RandomTargetOrder { get; set; } // 0x37 (55)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4037075576:
					StrengthType = (StrengthType) Enum.ToObject(typeof(StrengthType), p_Value);
					break;

				case 2089458956:
					Pose = (PoseType) Enum.ToObject(typeof(PoseType), p_Value);
					break;

				case 2888956146:
					ShootType = (ShootType) Enum.ToObject(typeof(ShootType), p_Value);
					break;

				case 2914787134:
					PreferAlternativeWeapon = (bool) p_Value;
					break;

				case 930658167:
					CompleteWhenHumanIsSensed = (bool) p_Value;
					break;

				case 2182019831:
					CycleTargets = (bool) p_Value;
					break;

				case 1044980993:
					RandomTargetOrder = (bool) p_Value;
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

				case 2089458956:
					return Pose;

				case 2888956146:
					return ShootType;

				case 2914787134:
					return PreferAlternativeWeapon;

				case 930658167:
					return CompleteWhenHumanIsSensed;

				case 2182019831:
					return CycleTargets;

				case 1044980993:
					return RandomTargetOrder;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4037075576:
					return typeof(ShootOrderEntityData).GetProperty(nameof(StrengthType));

				case 2089458956:
					return typeof(ShootOrderEntityData).GetProperty(nameof(Pose));

				case 2888956146:
					return typeof(ShootOrderEntityData).GetProperty(nameof(ShootType));

				case 2914787134:
					return typeof(ShootOrderEntityData).GetProperty(nameof(PreferAlternativeWeapon));

				case 930658167:
					return typeof(ShootOrderEntityData).GetProperty(nameof(CompleteWhenHumanIsSensed));

				case 2182019831:
					return typeof(ShootOrderEntityData).GetProperty(nameof(CycleTargets));

				case 1044980993:
					return typeof(ShootOrderEntityData).GetProperty(nameof(RandomTargetOrder));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
