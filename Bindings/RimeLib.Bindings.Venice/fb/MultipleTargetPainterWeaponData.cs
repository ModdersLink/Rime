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
	public class MultipleTargetPainterWeaponData : 
		WeaponData
	{
		[ContainerField(16)]
		public SpottingType SpottingBehavior { get; set; } = new SpottingType(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float TimeObjectIsPainted { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Angle { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float TimeObjectIsSpotted { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float Range { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool UseSpotting { get; set; } // 0x24 (36)
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool UseLaserPainting { get; set; } // 0x25 (37)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3595491045:
					SpottingBehavior = (SpottingType) Enum.ToObject(typeof(SpottingType), p_Value);
					break;

				case 641195484:
					TimeObjectIsPainted = (float) p_Value;
					break;

				case 205597860:
					Angle = (float) p_Value;
					break;

				case 3440952178:
					TimeObjectIsSpotted = (float) p_Value;
					break;

				case 230112826:
					Range = (float) p_Value;
					break;

				case 3045673834:
					UseSpotting = (bool) p_Value;
					break;

				case 952732621:
					UseLaserPainting = (bool) p_Value;
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
				case 3595491045:
					return SpottingBehavior;

				case 641195484:
					return TimeObjectIsPainted;

				case 205597860:
					return Angle;

				case 3440952178:
					return TimeObjectIsSpotted;

				case 230112826:
					return Range;

				case 3045673834:
					return UseSpotting;

				case 952732621:
					return UseLaserPainting;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3595491045:
					return typeof(MultipleTargetPainterWeaponData).GetProperty(nameof(SpottingBehavior));

				case 641195484:
					return typeof(MultipleTargetPainterWeaponData).GetProperty(nameof(TimeObjectIsPainted));

				case 205597860:
					return typeof(MultipleTargetPainterWeaponData).GetProperty(nameof(Angle));

				case 3440952178:
					return typeof(MultipleTargetPainterWeaponData).GetProperty(nameof(TimeObjectIsSpotted));

				case 230112826:
					return typeof(MultipleTargetPainterWeaponData).GetProperty(nameof(Range));

				case 3045673834:
					return typeof(MultipleTargetPainterWeaponData).GetProperty(nameof(UseSpotting));

				case 952732621:
					return typeof(MultipleTargetPainterWeaponData).GetProperty(nameof(UseLaserPainting));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
