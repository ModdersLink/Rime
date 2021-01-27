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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 20)]
	public class FloatOption : FrostbiteContainer
	{
		[ContainerField(Name: "Name", Offset: 0, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Value", Offset: 4, NameHash: 225375086, Flags: 49469), LayoutImmutable, Blittable]
		public float Value { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Min", Offset: 8, NameHash: 193446607, Flags: 49469), LayoutImmutable, Blittable]
		public float Min { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "Max", Offset: 12, NameHash: 193446865, Flags: 49469), LayoutImmutable, Blittable]
		public float Max { get; set; } // 0xC (12)
		
		[ContainerField(Name: "Step", Offset: 16, NameHash: 2089400887, Flags: 49469), LayoutImmutable, Blittable]
		public float Step { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 225375086:
					Value = (float) p_Value;
					break;

				case 193446607:
					Min = (float) p_Value;
					break;

				case 193446865:
					Max = (float) p_Value;
					break;

				case 2089400887:
					Step = (float) p_Value;
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
				case 2088949890:
					return Name;

				case 225375086:
					return Value;

				case 193446607:
					return Min;

				case 193446865:
					return Max;

				case 2089400887:
					return Step;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(FloatOption).GetProperty(nameof(Name));

				case 225375086:
					return typeof(FloatOption).GetProperty(nameof(Value));

				case 193446607:
					return typeof(FloatOption).GetProperty(nameof(Min));

				case 193446865:
					return typeof(FloatOption).GetProperty(nameof(Max));

				case 2089400887:
					return typeof(FloatOption).GetProperty(nameof(Step));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
