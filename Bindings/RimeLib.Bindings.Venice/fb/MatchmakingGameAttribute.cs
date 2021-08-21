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
	public class MatchmakingGameAttribute : FrostbiteContainer
	{
		[ContainerField(Name: "Attribute", Offset: 0, NameHash: 2715851769, Flags: 16509), LayoutImmutable]
		public string Attribute { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Value", Offset: 4, NameHash: 225375086, Flags: 16509), LayoutImmutable]
		public string Value { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Override", Offset: 8, NameHash: 3718925169, Flags: 49325), LayoutImmutable, Blittable]
		public bool Override { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2715851769:
					Attribute = (string) p_Value;
					break;

				case 225375086:
					Value = (string) p_Value;
					break;

				case 3718925169:
					Override = (bool) p_Value;
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
				case 2715851769:
					return Attribute;

				case 225375086:
					return Value;

				case 3718925169:
					return Override;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2715851769:
					return typeof(MatchmakingGameAttribute).GetProperty(nameof(Attribute));

				case 225375086:
					return typeof(MatchmakingGameAttribute).GetProperty(nameof(Value));

				case 3718925169:
					return typeof(MatchmakingGameAttribute).GetProperty(nameof(Override));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
