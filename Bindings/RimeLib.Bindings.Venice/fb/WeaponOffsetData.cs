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
	public class WeaponOffsetData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float WeaponOffsetX { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float WeaponOffsetY { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float WeaponOffsetZ { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float WeaponZoomedOffsetX { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float WeaponZoomedOffsetY { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float WeaponZoomedOffsetZ { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2991904818:
					WeaponOffsetX = (float) p_Value;
					break;

				case 2991904819:
					WeaponOffsetY = (float) p_Value;
					break;

				case 2991904816:
					WeaponOffsetZ = (float) p_Value;
					break;

				case 2753985860:
					WeaponZoomedOffsetX = (float) p_Value;
					break;

				case 2753985861:
					WeaponZoomedOffsetY = (float) p_Value;
					break;

				case 2753985862:
					WeaponZoomedOffsetZ = (float) p_Value;
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
				case 2991904818:
					return WeaponOffsetX;

				case 2991904819:
					return WeaponOffsetY;

				case 2991904816:
					return WeaponOffsetZ;

				case 2753985860:
					return WeaponZoomedOffsetX;

				case 2753985861:
					return WeaponZoomedOffsetY;

				case 2753985862:
					return WeaponZoomedOffsetZ;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2991904818:
					return typeof(WeaponOffsetData).GetProperty(nameof(WeaponOffsetX));

				case 2991904819:
					return typeof(WeaponOffsetData).GetProperty(nameof(WeaponOffsetY));

				case 2991904816:
					return typeof(WeaponOffsetData).GetProperty(nameof(WeaponOffsetZ));

				case 2753985860:
					return typeof(WeaponOffsetData).GetProperty(nameof(WeaponZoomedOffsetX));

				case 2753985861:
					return typeof(WeaponOffsetData).GetProperty(nameof(WeaponZoomedOffsetY));

				case 2753985862:
					return typeof(WeaponOffsetData).GetProperty(nameof(WeaponZoomedOffsetZ));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
