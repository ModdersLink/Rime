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
	public class SpecialMoveInterpolatedPoint : FrostbiteContainer
	{
		[ContainerField(Name: "Value", Offset: 0, NameHash: 225375086, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Value { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "Time", Offset: 16, NameHash: 2089313744, Flags: 49469), LayoutImmutable, Blittable]
		public float Time { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 225375086:
					Value = (Vec3) p_Value;
					break;

				case 2089313744:
					Time = (float) p_Value;
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
				case 225375086:
					return Value;

				case 2089313744:
					return Time;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 225375086:
					return typeof(SpecialMoveInterpolatedPoint).GetProperty(nameof(Value));

				case 2089313744:
					return typeof(SpecialMoveInterpolatedPoint).GetProperty(nameof(Time));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
