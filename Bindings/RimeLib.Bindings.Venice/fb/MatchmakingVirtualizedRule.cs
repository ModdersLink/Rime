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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class MatchmakingVirtualizedRule : FrostbiteContainer
	{
		[ContainerField(Name: "MinFitThreshold", Offset: 0, NameHash: 3350684067, Flags: 16509), LayoutImmutable]
		public string MinFitThreshold { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "VirtualizationMode", Offset: 4, NameHash: 152016681, Flags: 137)]
		public MatchmakingVirtualizationMode VirtualizationMode { get; set; } = new MatchmakingVirtualizationMode(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3350684067:
					MinFitThreshold = (string) p_Value;
					break;

				case 152016681:
						VirtualizationMode = (MatchmakingVirtualizationMode) Enum.ToObject(typeof(MatchmakingVirtualizationMode), p_Value);
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
				case 3350684067:
					return MinFitThreshold;

				case 152016681:
					return VirtualizationMode;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3350684067:
					return typeof(MatchmakingVirtualizedRule).GetProperty(nameof(MinFitThreshold));

				case 152016681:
					return typeof(MatchmakingVirtualizedRule).GetProperty(nameof(VirtualizationMode));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
