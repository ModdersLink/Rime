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
	public class DataCopValueSetting : FrostbiteContainer
	{
		[ContainerField(Name: "DataKey", Offset: 0, NameHash: 3872856866, Flags: 49405), LayoutImmutable, Blittable]
		public int DataKey { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "FrameSpacing", Offset: 4, NameHash: 1506868793, Flags: 49405), LayoutImmutable, Blittable]
		public int FrameSpacing { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Offset", Offset: 8, NameHash: 2871410728, Flags: 49405), LayoutImmutable, Blittable]
		public int Offset { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3872856866:
					DataKey = (int) p_Value;
					break;

				case 1506868793:
					FrameSpacing = (int) p_Value;
					break;

				case 2871410728:
					Offset = (int) p_Value;
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
				case 3872856866:
					return DataKey;

				case 1506868793:
					return FrameSpacing;

				case 2871410728:
					return Offset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3872856866:
					return typeof(DataCopValueSetting).GetProperty(nameof(DataKey));

				case 1506868793:
					return typeof(DataCopValueSetting).GetProperty(nameof(FrameSpacing));

				case 2871410728:
					return typeof(DataCopValueSetting).GetProperty(nameof(Offset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
