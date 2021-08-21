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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class PhysicsPartInfo : FrostbiteContainer
	{
		[ContainerField(Name: "PartComponentIndex", Offset: 0, NameHash: 4189988995, Flags: 49421), LayoutImmutable, Blittable]
		public uint PartComponentIndex { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "HealthStateIndex", Offset: 4, NameHash: 3506272272, Flags: 49421), LayoutImmutable, Blittable]
		public uint HealthStateIndex { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4189988995:
					PartComponentIndex = (uint) p_Value;
					break;

				case 3506272272:
					HealthStateIndex = (uint) p_Value;
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
				case 4189988995:
					return PartComponentIndex;

				case 3506272272:
					return HealthStateIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4189988995:
					return typeof(PhysicsPartInfo).GetProperty(nameof(PartComponentIndex));

				case 3506272272:
					return typeof(PhysicsPartInfo).GetProperty(nameof(HealthStateIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
