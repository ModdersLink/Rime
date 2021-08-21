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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 20)]
	public class MissileUnguidedData : FrostbiteContainer
	{
		[ContainerField(Name: "StaticPosition", Offset: 0, NameHash: 242876836, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 StaticPosition { get; set; } = new Vec2(); // 0x0 (0)
		
		[ContainerField(Name: "TargetPositionOffset", Offset: 8, NameHash: 3190891072, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 TargetPositionOffset { get; set; } = new Vec2(); // 0x8 (8)
		
		[ContainerField(Name: "UseTargetPosition", Offset: 16, NameHash: 1827844270, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseTargetPosition { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "UseStaticPosition", Offset: 17, NameHash: 753327591, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseStaticPosition { get; set; } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 242876836:
					StaticPosition = (Vec2) p_Value;
					break;

				case 3190891072:
					TargetPositionOffset = (Vec2) p_Value;
					break;

				case 1827844270:
					UseTargetPosition = (bool) p_Value;
					break;

				case 753327591:
					UseStaticPosition = (bool) p_Value;
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
				case 242876836:
					return StaticPosition;

				case 3190891072:
					return TargetPositionOffset;

				case 1827844270:
					return UseTargetPosition;

				case 753327591:
					return UseStaticPosition;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 242876836:
					return typeof(MissileUnguidedData).GetProperty(nameof(StaticPosition));

				case 3190891072:
					return typeof(MissileUnguidedData).GetProperty(nameof(TargetPositionOffset));

				case 1827844270:
					return typeof(MissileUnguidedData).GetProperty(nameof(UseTargetPosition));

				case 753327591:
					return typeof(MissileUnguidedData).GetProperty(nameof(UseStaticPosition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
