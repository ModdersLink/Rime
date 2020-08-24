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
	[ContainerType(16), MemberInfoFlag(41), ContainerStruct]
	public class AutoAimData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec3 AutoAimOuterBoxOffset { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec3 AutoAimOuterBoxExtends { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec3 AutoAimInnerBoxOffset { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec3 AutoAimInnerBoxExtends { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), MemberInfoFlag(137)]
		public CharacterPoseType PoseType { get; set; } = new CharacterPoseType(); // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 139244878:
					AutoAimOuterBoxOffset = (Vec3) p_Value;
					break;

				case 1265999350:
					AutoAimOuterBoxExtends = (Vec3) p_Value;
					break;

				case 2561090505:
					AutoAimInnerBoxOffset = (Vec3) p_Value;
					break;

				case 301487121:
					AutoAimInnerBoxExtends = (Vec3) p_Value;
					break;

				case 3415409588:
						PoseType = (CharacterPoseType) Enum.ToObject(typeof(CharacterPoseType), p_Value);
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
				case 139244878:
					return AutoAimOuterBoxOffset;

				case 1265999350:
					return AutoAimOuterBoxExtends;

				case 2561090505:
					return AutoAimInnerBoxOffset;

				case 301487121:
					return AutoAimInnerBoxExtends;

				case 3415409588:
					return PoseType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 139244878:
					return typeof(AutoAimData).GetProperty(nameof(AutoAimOuterBoxOffset));

				case 1265999350:
					return typeof(AutoAimData).GetProperty(nameof(AutoAimOuterBoxExtends));

				case 2561090505:
					return typeof(AutoAimData).GetProperty(nameof(AutoAimInnerBoxOffset));

				case 301487121:
					return typeof(AutoAimData).GetProperty(nameof(AutoAimInnerBoxExtends));

				case 3415409588:
					return typeof(AutoAimData).GetProperty(nameof(PoseType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
