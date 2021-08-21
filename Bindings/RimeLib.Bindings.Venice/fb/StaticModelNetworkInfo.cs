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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class StaticModelNetworkInfo : FrostbiteContainer
	{
		[ContainerField(Name: "PartNetworkIdRanges", Offset: 0, NameHash: 2560941869, Flags: 65)]
		public List<IndexRange> PartNetworkIdRanges { get; set; } = new List<IndexRange>(); // 0x0 (0)
		
		[ContainerField(Name: "NetworkIdCount", Offset: 4, NameHash: 1234693717, Flags: 49421), LayoutImmutable, Blittable]
		public uint NetworkIdCount { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "ChildNetworkInfos", Offset: 8, NameHash: 3109636684, Flags: 65)]
		public List<ChildStaticModelNetworkInfo> ChildNetworkInfos { get; set; } = new List<ChildStaticModelNetworkInfo>(); // 0x8 (8)
		
		[ContainerField(Name: "ChildNetworkIdCount", Offset: 12, NameHash: 2318313855, Flags: 49421), LayoutImmutable, Blittable]
		public uint ChildNetworkIdCount { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2560941869:
					PartNetworkIdRanges = (List<IndexRange>) p_Value;
					break;

				case 1234693717:
					NetworkIdCount = (uint) p_Value;
					break;

				case 3109636684:
					ChildNetworkInfos = (List<ChildStaticModelNetworkInfo>) p_Value;
					break;

				case 2318313855:
					ChildNetworkIdCount = (uint) p_Value;
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
				case 2560941869:
					return PartNetworkIdRanges;

				case 1234693717:
					return NetworkIdCount;

				case 3109636684:
					return ChildNetworkInfos;

				case 2318313855:
					return ChildNetworkIdCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2560941869:
					return typeof(StaticModelNetworkInfo).GetProperty(nameof(PartNetworkIdRanges));

				case 1234693717:
					return typeof(StaticModelNetworkInfo).GetProperty(nameof(NetworkIdCount));

				case 3109636684:
					return typeof(StaticModelNetworkInfo).GetProperty(nameof(ChildNetworkInfos));

				case 2318313855:
					return typeof(StaticModelNetworkInfo).GetProperty(nameof(ChildNetworkIdCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
