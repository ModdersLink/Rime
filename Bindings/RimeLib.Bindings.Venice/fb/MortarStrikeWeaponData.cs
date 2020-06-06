///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MortarStrikeWeaponData : 
		WeaponData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float HoldingTolerance { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MaxStrikeDistance { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float StrikeRadius { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxRandomSpawnHeight { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1278440067:
					HoldingTolerance = (float) p_Value;
					break;

				case 3419412896:
					MaxStrikeDistance = (float) p_Value;
					break;

				case 4030357871:
					StrikeRadius = (float) p_Value;
					break;

				case 2881356526:
					MaxRandomSpawnHeight = (float) p_Value;
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
				case 1278440067:
					return HoldingTolerance;

				case 3419412896:
					return MaxStrikeDistance;

				case 4030357871:
					return StrikeRadius;

				case 2881356526:
					return MaxRandomSpawnHeight;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1278440067:
					return typeof(MortarStrikeWeaponData).GetProperty(nameof(HoldingTolerance));

				case 3419412896:
					return typeof(MortarStrikeWeaponData).GetProperty(nameof(MaxStrikeDistance));

				case 4030357871:
					return typeof(MortarStrikeWeaponData).GetProperty(nameof(StrikeRadius));

				case 2881356526:
					return typeof(MortarStrikeWeaponData).GetProperty(nameof(MaxRandomSpawnHeight));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
