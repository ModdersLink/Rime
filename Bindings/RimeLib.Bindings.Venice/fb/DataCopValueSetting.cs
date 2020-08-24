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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class DataCopValueSetting : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int DataKey { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int FrameSpacing { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
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
