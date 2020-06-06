///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MatchmakingGenericRule : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable]
		public string Rule { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable]
		public string MinFitThresHold { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable]
		public string Setting { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public List<MatchmakingRuleString> DesiredValues { get; set; } = new List<MatchmakingRuleString>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool IgnoreIfDefault { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool MergeValues { get; set; } // 0x11 (17)
		
		[ContainerField(18), LayoutImmutable, Blittable]
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
