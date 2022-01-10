///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 16)]
	public class StaticModelNetworkInfo
	{
		[ContainerField(0)]
		public List<IndexRange> PartNetworkIdRanges { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint NetworkIdCount { get; set; }
		
		[ContainerField(8)]
		public List<ChildStaticModelNetworkInfo> ChildNetworkInfos { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint ChildNetworkIdCount { get; set; }
		
		public static void Deserialize(StaticModelNetworkInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PartNetworkIdRanges.Clear();
			(RimeReader Reader, uint Count) s_PartNetworkIdRanges = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PartNetworkIdRanges.Count; ++i)
			{
				var s_Value = new IndexRange();
				fb.IndexRange.Deserialize(s_Value, s_PartNetworkIdRanges.Reader, p_Parser);
				p_Instance.PartNetworkIdRanges.Add(s_Value);
			}
			
			s_PartNetworkIdRanges.Reader.Dispose();
			p_Instance.NetworkIdCount = p_Reader.ReadUInt32();
			p_Instance.ChildNetworkInfos.Clear();
			(RimeReader Reader, uint Count) s_ChildNetworkInfos = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ChildNetworkInfos.Count; ++i)
			{
				var s_Value = new ChildStaticModelNetworkInfo();
				fb.ChildStaticModelNetworkInfo.Deserialize(s_Value, s_ChildNetworkInfos.Reader, p_Parser);
				p_Instance.ChildNetworkInfos.Add(s_Value);
			}
			
			s_ChildNetworkInfos.Reader.Dispose();
			p_Instance.ChildNetworkIdCount = p_Reader.ReadUInt32();
		}
	}
}
