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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(20), ContainerStruct]
	public class MissileUnguidedData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec2 StaticPosition { get; set; } = new Vec2(); // 0x0 (0)
		
		[ContainerField(8), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec2 TargetPositionOffset { get; set; } = new Vec2(); // 0x8 (8)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool UseTargetPosition { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
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
