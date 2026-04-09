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
	[ContainerType(4, 44)]
	public partial class UIGraphAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<UINodeData> _Nodes = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<GlobalNode> _GlobalNode = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<UINodeConnection> _Connections = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<UIAudioEventAsset> _AudioEventMappings = new();

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		private string _BundleAssetName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private RefArray<UIEventAsset> _EventList = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private bool _Modal;

		[ObservableProperty]
		[property: ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		private bool _ProtectScreens;

		[ObservableProperty]
		[property: ContainerField(38), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
		private bool _IsWin32UIGraphAsset;

		[ObservableProperty]
		[property: ContainerField(39), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
		private bool _IsXenonUIGraphAsset;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private bool _IsPs3UIGraphAsset;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Nodes = p_EbxWriter.GetArrayWriter(Nodes.GetType(), Nodes.Count);
			p_Writer.Write(s_Nodes.ArrayIndex);
			foreach (var s_Entry in Nodes)
			{
				s_Nodes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(GlobalNode));
			(RimeWriter Writer, uint ArrayIndex) s_Connections = p_EbxWriter.GetArrayWriter(Connections.GetType(), Connections.Count);
			p_Writer.Write(s_Connections.ArrayIndex);
			foreach (var s_Entry in Connections)
			{
				s_Connections.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(AudioEventMappings));
			p_Writer.Write(p_EbxWriter.WriteString(BundleAssetName));
			(RimeWriter Writer, uint ArrayIndex) s_EventList = p_EbxWriter.GetArrayWriter(EventList.GetType(), EventList.Count);
			p_Writer.Write(s_EventList.ArrayIndex);
			foreach (var s_Entry in EventList)
			{
				s_EventList.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(Modal);
			p_Writer.Write(ProtectScreens);
			p_Writer.Write(IsWin32UIGraphAsset);
			p_Writer.Write(IsXenonUIGraphAsset);
			p_Writer.Write(IsPs3UIGraphAsset);
			p_Writer.WriteNullBytes(3);
		}
	}
}
