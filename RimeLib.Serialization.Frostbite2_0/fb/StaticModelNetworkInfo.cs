///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 16)]
	public class StaticModelNetworkInfo :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public List<IndexRange> PartNetworkIdRanges { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public uint NetworkIdCount { get; set; }
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<ChildStaticModelNetworkInfo> ChildNetworkInfos { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint ChildNetworkIdCount { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_PartNetworkIdRanges = p_EbxWriter.GetArrayWriter(PartNetworkIdRanges.GetType(), PartNetworkIdRanges.Count);
			p_Writer.Write(s_PartNetworkIdRanges.ArrayIndex);
			foreach (var s_Entry in PartNetworkIdRanges)
			{
				s_Entry.Serialize(s_PartNetworkIdRanges.Writer, p_EbxWriter);
			}
			p_Writer.Write(NetworkIdCount);
			(RimeWriter Writer, uint ArrayIndex) s_ChildNetworkInfos = p_EbxWriter.GetArrayWriter(ChildNetworkInfos.GetType(), ChildNetworkInfos.Count);
			p_Writer.Write(s_ChildNetworkInfos.ArrayIndex);
			foreach (var s_Entry in ChildNetworkInfos)
			{
				s_Entry.Serialize(s_ChildNetworkInfos.Writer, p_EbxWriter);
			}
			p_Writer.Write(ChildNetworkIdCount);
		}
	}
}
