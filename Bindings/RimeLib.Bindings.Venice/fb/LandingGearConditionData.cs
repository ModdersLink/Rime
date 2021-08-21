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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class LandingGearConditionData : FrostbiteContainer
	{
		[ContainerField(Name: "Height", Offset: 0, NameHash: 3054065626, Flags: 49469), LayoutImmutable, Blittable]
		public float Height { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Velocity", Offset: 4, NameHash: 3860766482, Flags: 49469), LayoutImmutable, Blittable]
		public float Velocity { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Angle", Offset: 8, NameHash: 205597860, Flags: 49469), LayoutImmutable, Blittable]
		public float Angle { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3054065626:
					Height = (float) p_Value;
					break;

				case 3860766482:
					Velocity = (float) p_Value;
					break;

				case 205597860:
					Angle = (float) p_Value;
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
				case 3054065626:
					return Height;

				case 3860766482:
					return Velocity;

				case 205597860:
					return Angle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3054065626:
					return typeof(LandingGearConditionData).GetProperty(nameof(Height));

				case 3860766482:
					return typeof(LandingGearConditionData).GetProperty(nameof(Velocity));

				case 205597860:
					return typeof(LandingGearConditionData).GetProperty(nameof(Angle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
