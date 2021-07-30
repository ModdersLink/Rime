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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 32)]
	public class EdgeModelLightMapInstance : FrostbiteContainer
	{
		[ContainerField(Name: "LightMapUv", Offset: 0, NameHash: 2094465924, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 LightMapUv { get; set; } = new Vec4(); // 0x0 (0)
		
		[ContainerField(Name: "Position", Offset: 16, NameHash: 3402582524, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get; set; } = new Vec3(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2094465924:
					LightMapUv = (Vec4) p_Value;
					break;

				case 3402582524:
					Position = (Vec3) p_Value;
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
				case 2094465924:
					return LightMapUv;

				case 3402582524:
					return Position;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2094465924:
					return typeof(EdgeModelLightMapInstance).GetProperty(nameof(LightMapUv));

				case 3402582524:
					return typeof(EdgeModelLightMapInstance).GetProperty(nameof(Position));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
