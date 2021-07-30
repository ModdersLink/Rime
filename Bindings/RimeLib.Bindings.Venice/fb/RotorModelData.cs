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
	public class RotorModelData : FrostbiteContainer
	{
		[ContainerField(Name: "RotationRpm", Offset: 0, NameHash: 1136603326, Flags: 49469), LayoutImmutable, Blittable]
		public float RotationRpm { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "PartIndex", Offset: 4, NameHash: 3213901068, Flags: 49421), LayoutImmutable, Blittable]
		public uint PartIndex { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1136603326:
					RotationRpm = (float) p_Value;
					break;

				case 3213901068:
					PartIndex = (uint) p_Value;
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
				case 1136603326:
					return RotationRpm;

				case 3213901068:
					return PartIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1136603326:
					return typeof(RotorModelData).GetProperty(nameof(RotationRpm));

				case 3213901068:
					return typeof(RotorModelData).GetProperty(nameof(PartIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
