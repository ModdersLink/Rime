///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4)]
	public class SoldierWeaponDispersion : FrostbiteContainer
	{
		[ContainerField(0)]
		public FiringDispersionData StandDispersion { get; set; } = new FiringDispersionData(); // 0x0 (0)
		
		[ContainerField(16)]
		public FiringDispersionData CrouchDispersion { get; set; } = new FiringDispersionData(); // 0x10 (16)
		
		[ContainerField(32)]
		public FiringDispersionData ProneDispersion { get; set; } = new FiringDispersionData(); // 0x20 (32)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float JumpDispersionAngle { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float ProneTransitionDispersionAngle { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float MoveDispersionAngle { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float MoveZoomedDispersionAngle { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float DecreasePerSecond { get; set; } // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1584552523:
					StandDispersion = (FiringDispersionData) p_Value;
					break;

				case 429011943:
					CrouchDispersion = (FiringDispersionData) p_Value;
					break;

				case 1226401409:
					ProneDispersion = (FiringDispersionData) p_Value;
					break;

				case 1831944196:
					JumpDispersionAngle = (float) p_Value;
					break;

				case 4178809039:
					ProneTransitionDispersionAngle = (float) p_Value;
					break;

				case 371686199:
					MoveDispersionAngle = (float) p_Value;
					break;

				case 2897726465:
					MoveZoomedDispersionAngle = (float) p_Value;
					break;

				case 3208554608:
					DecreasePerSecond = (float) p_Value;
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
				case 1584552523:
					return StandDispersion;

				case 429011943:
					return CrouchDispersion;

				case 1226401409:
					return ProneDispersion;

				case 1831944196:
					return JumpDispersionAngle;

				case 4178809039:
					return ProneTransitionDispersionAngle;

				case 371686199:
					return MoveDispersionAngle;

				case 2897726465:
					return MoveZoomedDispersionAngle;

				case 3208554608:
					return DecreasePerSecond;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1584552523:
					return typeof(SoldierWeaponDispersion).GetProperty(nameof(StandDispersion));

				case 429011943:
					return typeof(SoldierWeaponDispersion).GetProperty(nameof(CrouchDispersion));

				case 1226401409:
					return typeof(SoldierWeaponDispersion).GetProperty(nameof(ProneDispersion));

				case 1831944196:
					return typeof(SoldierWeaponDispersion).GetProperty(nameof(JumpDispersionAngle));

				case 4178809039:
					return typeof(SoldierWeaponDispersion).GetProperty(nameof(ProneTransitionDispersionAngle));

				case 371686199:
					return typeof(SoldierWeaponDispersion).GetProperty(nameof(MoveDispersionAngle));

				case 2897726465:
					return typeof(SoldierWeaponDispersion).GetProperty(nameof(MoveZoomedDispersionAngle));

				case 3208554608:
					return typeof(SoldierWeaponDispersion).GetProperty(nameof(DecreasePerSecond));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
