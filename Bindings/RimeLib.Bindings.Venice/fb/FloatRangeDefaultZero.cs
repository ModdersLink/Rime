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
	public class FloatRangeDefaultZero : FrostbiteContainer
	{
		[ContainerField(Name: "Min", Offset: 0, NameHash: 193446607, Flags: 49469), LayoutImmutable, Blittable]
		public float Min { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Max", Offset: 4, NameHash: 193446865, Flags: 49469), LayoutImmutable, Blittable]
		public float Max { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193446607:
					Min = (float) p_Value;
					break;

				case 193446865:
					Max = (float) p_Value;
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
				case 193446607:
					return Min;

				case 193446865:
					return Max;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193446607:
					return typeof(FloatRangeDefaultZero).GetProperty(nameof(Min));

				case 193446865:
					return typeof(FloatRangeDefaultZero).GetProperty(nameof(Max));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
