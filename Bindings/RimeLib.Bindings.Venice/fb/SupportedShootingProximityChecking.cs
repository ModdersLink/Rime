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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class SupportedShootingProximityChecking : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RayAboveGunHeightOffset { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RayAboveLength { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RayBelowGunHeightOffset { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RayBelowLength { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3036253694:
					RayAboveGunHeightOffset = (float) p_Value;
					break;

				case 3860297932:
					RayAboveLength = (float) p_Value;
					break;

				case 2261799346:
					RayBelowGunHeightOffset = (float) p_Value;
					break;

				case 421914752:
					RayBelowLength = (float) p_Value;
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
				case 3036253694:
					return RayAboveGunHeightOffset;

				case 3860297932:
					return RayAboveLength;

				case 2261799346:
					return RayBelowGunHeightOffset;

				case 421914752:
					return RayBelowLength;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3036253694:
					return typeof(SupportedShootingProximityChecking).GetProperty(nameof(RayAboveGunHeightOffset));

				case 3860297932:
					return typeof(SupportedShootingProximityChecking).GetProperty(nameof(RayAboveLength));

				case 2261799346:
					return typeof(SupportedShootingProximityChecking).GetProperty(nameof(RayBelowGunHeightOffset));

				case 421914752:
					return typeof(SupportedShootingProximityChecking).GetProperty(nameof(RayBelowLength));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
