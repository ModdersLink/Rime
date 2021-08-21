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
	public class SoundGraphPluginConstructParam : FrostbiteContainer
	{
		[ContainerField(Name: "Value", Offset: 0, NameHash: 225375086, Flags: 49469), LayoutImmutable, Blittable]
		public float Value { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Index", Offset: 4, NameHash: 214509467, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte Index { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 225375086:
					Value = (float) p_Value;
					break;

				case 214509467:
					Index = (sbyte) p_Value;
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
				case 225375086:
					return Value;

				case 214509467:
					return Index;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 225375086:
					return typeof(SoundGraphPluginConstructParam).GetProperty(nameof(Value));

				case 214509467:
					return typeof(SoundGraphPluginConstructParam).GetProperty(nameof(Index));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
