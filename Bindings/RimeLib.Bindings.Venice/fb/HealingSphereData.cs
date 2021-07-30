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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class HealingSphereData : FrostbiteContainer
	{
		[ContainerField(Name: "Radius", Offset: 0, NameHash: 3298407133, Flags: 49469), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "HealthIncSpeed", Offset: 4, NameHash: 2425137914, Flags: 49469), LayoutImmutable, Blittable]
		public float HealthIncSpeed { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3298407133:
					Radius = (float) p_Value;
					break;

				case 2425137914:
					HealthIncSpeed = (float) p_Value;
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
				case 3298407133:
					return Radius;

				case 2425137914:
					return HealthIncSpeed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3298407133:
					return typeof(HealingSphereData).GetProperty(nameof(Radius));

				case 2425137914:
					return typeof(HealingSphereData).GetProperty(nameof(HealthIncSpeed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
