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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class MatchmakingRuleString : FrostbiteContainer
	{
		[ContainerField(Name: "Value", Offset: 0, NameHash: 225375086, Flags: 16509), LayoutImmutable]
		public string Value { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Platform", Offset: 4, NameHash: 942751002, Flags: 137)]
		public MatchmakingPlatform Platform { get; set; } = new MatchmakingPlatform(); // 0x4 (4)
		
		[ContainerField(Name: "Licenses", Offset: 8, NameHash: 2259172461, Flags: 65)]
		public List<string> Licenses { get; set; } = new List<string>(); // 0x8 (8)
		
		[ContainerField(Name: "UseOnlyIfEmpty", Offset: 12, NameHash: 601634056, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseOnlyIfEmpty { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 225375086:
					Value = (string) p_Value;
					break;

				case 942751002:
						Platform = (MatchmakingPlatform) Enum.ToObject(typeof(MatchmakingPlatform), p_Value);
					break;

				case 2259172461:
					Licenses = (List<string>) p_Value;
					break;

				case 601634056:
					UseOnlyIfEmpty = (bool) p_Value;
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

				case 942751002:
					return Platform;

				case 2259172461:
					return Licenses;

				case 601634056:
					return UseOnlyIfEmpty;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 225375086:
					return typeof(MatchmakingRuleString).GetProperty(nameof(Value));

				case 942751002:
					return typeof(MatchmakingRuleString).GetProperty(nameof(Platform));

				case 2259172461:
					return typeof(MatchmakingRuleString).GetProperty(nameof(Licenses));

				case 601634056:
					return typeof(MatchmakingRuleString).GetProperty(nameof(UseOnlyIfEmpty));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
