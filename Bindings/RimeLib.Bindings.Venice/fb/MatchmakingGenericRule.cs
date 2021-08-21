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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 20)]
	public class MatchmakingGenericRule : FrostbiteContainer
	{
		[ContainerField(Name: "Rule", Offset: 0, NameHash: 2089359915, Flags: 16509), LayoutImmutable]
		public string Rule { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "MinFitThresHold", Offset: 4, NameHash: 3351757955, Flags: 16509), LayoutImmutable]
		public string MinFitThresHold { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Setting", Offset: 8, NameHash: 2752851091, Flags: 16509), LayoutImmutable]
		public string Setting { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "DesiredValues", Offset: 12, NameHash: 2104393557, Flags: 65)]
		public List<MatchmakingRuleString> DesiredValues { get; set; } = new List<MatchmakingRuleString>(); // 0xC (12)
		
		[ContainerField(Name: "IgnoreIfDefault", Offset: 16, NameHash: 6250777, Flags: 49325), LayoutImmutable, Blittable]
		public bool IgnoreIfDefault { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "MergeValues", Offset: 17, NameHash: 1359715749, Flags: 49325), LayoutImmutable, Blittable]
		public bool MergeValues { get; set; } // 0x11 (17)
		
		[ContainerField(Name: "SortValues", Offset: 18, NameHash: 1083437895, Flags: 49325), LayoutImmutable, Blittable]
		public bool SortValues { get; set; } // 0x12 (18)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089359915:
					Rule = (string) p_Value;
					break;

				case 3351757955:
					MinFitThresHold = (string) p_Value;
					break;

				case 2752851091:
					Setting = (string) p_Value;
					break;

				case 2104393557:
					DesiredValues = (List<MatchmakingRuleString>) p_Value;
					break;

				case 6250777:
					IgnoreIfDefault = (bool) p_Value;
					break;

				case 1359715749:
					MergeValues = (bool) p_Value;
					break;

				case 1083437895:
					SortValues = (bool) p_Value;
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
				case 2089359915:
					return Rule;

				case 3351757955:
					return MinFitThresHold;

				case 2752851091:
					return Setting;

				case 2104393557:
					return DesiredValues;

				case 6250777:
					return IgnoreIfDefault;

				case 1359715749:
					return MergeValues;

				case 1083437895:
					return SortValues;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089359915:
					return typeof(MatchmakingGenericRule).GetProperty(nameof(Rule));

				case 3351757955:
					return typeof(MatchmakingGenericRule).GetProperty(nameof(MinFitThresHold));

				case 2752851091:
					return typeof(MatchmakingGenericRule).GetProperty(nameof(Setting));

				case 2104393557:
					return typeof(MatchmakingGenericRule).GetProperty(nameof(DesiredValues));

				case 6250777:
					return typeof(MatchmakingGenericRule).GetProperty(nameof(IgnoreIfDefault));

				case 1359715749:
					return typeof(MatchmakingGenericRule).GetProperty(nameof(MergeValues));

				case 1083437895:
					return typeof(MatchmakingGenericRule).GetProperty(nameof(SortValues));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
