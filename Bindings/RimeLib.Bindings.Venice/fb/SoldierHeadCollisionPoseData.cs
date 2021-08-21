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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 32)]
	public class SoldierHeadCollisionPoseData : FrostbiteContainer
	{
		[ContainerField(Name: "IdleOffset", Offset: 0, NameHash: 2890341292, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 IdleOffset { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "MovingForwardOffset", Offset: 16, NameHash: 4106472903, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MovingForwardOffset { get; set; } = new Vec3(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2890341292:
					IdleOffset = (Vec3) p_Value;
					break;

				case 4106472903:
					MovingForwardOffset = (Vec3) p_Value;
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
				case 2890341292:
					return IdleOffset;

				case 4106472903:
					return MovingForwardOffset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2890341292:
					return typeof(SoldierHeadCollisionPoseData).GetProperty(nameof(IdleOffset));

				case 4106472903:
					return typeof(SoldierHeadCollisionPoseData).GetProperty(nameof(MovingForwardOffset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
