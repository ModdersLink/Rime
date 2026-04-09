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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 28)]
	public partial class AudioGraphData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private RefArray<AudioGraphNodeData> _Nodes = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<AudioGraphParameter> _PublicParameters = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<AudioGraphEvent> _PublicEvents = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<AudioGraphAssetParameter> _PublicAssetParameters = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private ushort _PublicValueCount;

		[ObservableProperty]
		[property: ContainerField(26), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
		private ushort _ValueCount;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			(RimeWriter Writer, uint ArrayIndex) s_Nodes = p_EbxWriter.GetArrayWriter(Nodes.GetType(), Nodes.Count);
			p_Writer.Write(s_Nodes.ArrayIndex);
			foreach (var s_Entry in Nodes)
			{
				s_Nodes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_PublicParameters = p_EbxWriter.GetArrayWriter(PublicParameters.GetType(), PublicParameters.Count);
			p_Writer.Write(s_PublicParameters.ArrayIndex);
			foreach (var s_Entry in PublicParameters)
			{
				s_PublicParameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_PublicEvents = p_EbxWriter.GetArrayWriter(PublicEvents.GetType(), PublicEvents.Count);
			p_Writer.Write(s_PublicEvents.ArrayIndex);
			foreach (var s_Entry in PublicEvents)
			{
				s_PublicEvents.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_PublicAssetParameters = p_EbxWriter.GetArrayWriter(PublicAssetParameters.GetType(), PublicAssetParameters.Count);
			p_Writer.Write(s_PublicAssetParameters.ArrayIndex);
			foreach (var s_Entry in PublicAssetParameters)
			{
				s_PublicAssetParameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(PublicValueCount);
			p_Writer.Write(ValueCount);
		}
	}
}
