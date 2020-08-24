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
	public class MatchmakingCriteria : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public MatchmakingSizeRule SizeRule { get; set; } = new MatchmakingSizeRule(); // 0x0 (0)
		
		[ContainerField(8), MemberInfoFlag(41)]
		public MatchmakingPingSiteRule PingSiteRule { get; set; } = new MatchmakingPingSiteRule(); // 0x8 (8)
		
		[ContainerField(12), MemberInfoFlag(41)]
		public MatchmakingRankedRule RankedRule { get; set; } = new MatchmakingRankedRule(); // 0xC (12)
		
		[ContainerField(16), MemberInfoFlag(65), ContainerArray]
		public List<MatchmakingGenericRule> GenericRules { get; set; } = new List<MatchmakingGenericRule>(); // 0x10 (16)
		
		[ContainerField(20), MemberInfoFlag(41)]
		public MatchmakingVirtualizedRule VirtualizedRule { get; set; } = new MatchmakingVirtualizedRule(); // 0x14 (20)
		
		[ContainerField(28), MemberInfoFlag(65), ContainerArray]
		public List<MatchmakingUserExtendedDataRule> UEDRules { get; set; } = new List<MatchmakingUserExtendedDataRule>(); // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2544174702:
					SizeRule = (MatchmakingSizeRule) p_Value;
					break;

				case 2506878288:
					PingSiteRule = (MatchmakingPingSiteRule) p_Value;
					break;

				case 3471512572:
					RankedRule = (MatchmakingRankedRule) p_Value;
					break;

				case 2031266057:
					GenericRules = (List<MatchmakingGenericRule>) p_Value;
					break;

				case 2775847128:
					VirtualizedRule = (MatchmakingVirtualizedRule) p_Value;
					break;

				case 1513224812:
					UEDRules = (List<MatchmakingUserExtendedDataRule>) p_Value;
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
				case 2544174702:
					return SizeRule;

				case 2506878288:
					return PingSiteRule;

				case 3471512572:
					return RankedRule;

				case 2031266057:
					return GenericRules;

				case 2775847128:
					return VirtualizedRule;

				case 1513224812:
					return UEDRules;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2544174702:
					return typeof(MatchmakingCriteria).GetProperty(nameof(SizeRule));

				case 2506878288:
					return typeof(MatchmakingCriteria).GetProperty(nameof(PingSiteRule));

				case 3471512572:
					return typeof(MatchmakingCriteria).GetProperty(nameof(RankedRule));

				case 2031266057:
					return typeof(MatchmakingCriteria).GetProperty(nameof(GenericRules));

				case 2775847128:
					return typeof(MatchmakingCriteria).GetProperty(nameof(VirtualizedRule));

				case 1513224812:
					return typeof(MatchmakingCriteria).GetProperty(nameof(UEDRules));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
