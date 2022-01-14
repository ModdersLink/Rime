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
	[ContainerType(4, 40)]
	public class CustomSequenceTrackData :
		EntityData
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string TrackName { get; set; } = string.Empty;

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<CustomSequenceTrackLinkMapping> InputLinkMap { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<CustomSequenceTrackLinkMapping> OutputLinkMap { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public RefArray<CustomSequenceTrackEventMapping> EventMap { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public RefArray<CustomSequenceTrackPropertyMapping> SourcePropertyMap { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public RefArray<CustomSequenceTrackPropertyMapping> TargetPropertyMap { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public RefArray<CustomSequenceTrackPropertyMapping> SourceAndTargetPropertyMap { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(TrackName));
			(RimeWriter Writer, uint ArrayIndex) s_InputLinkMap = p_EbxWriter.GetArrayWriter(InputLinkMap.GetType(), InputLinkMap.Count);
			p_Writer.Write(s_InputLinkMap.ArrayIndex);
			foreach (var s_Entry in InputLinkMap)
			{
				s_InputLinkMap.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_OutputLinkMap = p_EbxWriter.GetArrayWriter(OutputLinkMap.GetType(), OutputLinkMap.Count);
			p_Writer.Write(s_OutputLinkMap.ArrayIndex);
			foreach (var s_Entry in OutputLinkMap)
			{
				s_OutputLinkMap.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_EventMap = p_EbxWriter.GetArrayWriter(EventMap.GetType(), EventMap.Count);
			p_Writer.Write(s_EventMap.ArrayIndex);
			foreach (var s_Entry in EventMap)
			{
				s_EventMap.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_SourcePropertyMap = p_EbxWriter.GetArrayWriter(SourcePropertyMap.GetType(), SourcePropertyMap.Count);
			p_Writer.Write(s_SourcePropertyMap.ArrayIndex);
			foreach (var s_Entry in SourcePropertyMap)
			{
				s_SourcePropertyMap.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_TargetPropertyMap = p_EbxWriter.GetArrayWriter(TargetPropertyMap.GetType(), TargetPropertyMap.Count);
			p_Writer.Write(s_TargetPropertyMap.ArrayIndex);
			foreach (var s_Entry in TargetPropertyMap)
			{
				s_TargetPropertyMap.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_SourceAndTargetPropertyMap = p_EbxWriter.GetArrayWriter(SourceAndTargetPropertyMap.GetType(), SourceAndTargetPropertyMap.Count);
			p_Writer.Write(s_SourceAndTargetPropertyMap.ArrayIndex);
			foreach (var s_Entry in SourceAndTargetPropertyMap)
			{
				s_SourceAndTargetPropertyMap.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
