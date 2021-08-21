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
	public class SensingSphere : FrostbiteContainer
	{
		[ContainerField(Name: "Position", Offset: 0, NameHash: 3402582524, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "RadiusSqr", Offset: 16, NameHash: 2349614861, Flags: 49469), LayoutImmutable, Blittable]
		public float RadiusSqr { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3402582524:
					Position = (Vec3) p_Value;
					break;

				case 2349614861:
					RadiusSqr = (float) p_Value;
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
				case 3402582524:
					return Position;

				case 2349614861:
					return RadiusSqr;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3402582524:
					return typeof(SensingSphere).GetProperty(nameof(Position));

				case 2349614861:
					return typeof(SensingSphere).GetProperty(nameof(RadiusSqr));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
