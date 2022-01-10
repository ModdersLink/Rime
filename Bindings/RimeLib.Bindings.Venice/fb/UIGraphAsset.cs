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
	[ContainerType(4, 44)]
	public class UIGraphAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<UINodeData>> Nodes { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<GlobalNode> GlobalNode { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<UINodeConnection>> Connections { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<UIAudioEventAsset> AudioEventMappings { get; set; } = new();

		[ContainerField(28), LayoutImmutable]
		public string BundleAssetName { get; set; } = string.Empty;

		[ContainerField(32)]
		public List<CtrRef<UIEventAsset>> EventList { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool Modal { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable]
		public bool ProtectScreens { get; set; }

		[ContainerField(38), LayoutImmutable, Blittable]
		public bool IsWin32UIGraphAsset { get; set; }

		[ContainerField(39), LayoutImmutable, Blittable]
		public bool IsXenonUIGraphAsset { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool IsPs3UIGraphAsset { get; set; }

		public static void Deserialize(UIGraphAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Nodes.Clear();
			(RimeReader Reader, uint Count) s_Nodes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Nodes.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UINodeData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Nodes.Reader.ReadUInt32()));
				p_Instance.Nodes.Add(s_CtrRef);
			}
			
			s_Nodes.Reader.Dispose();
			p_Instance.GlobalNode.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Connections.Clear();
			(RimeReader Reader, uint Count) s_Connections = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Connections.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UINodeConnection>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Connections.Reader.ReadUInt32()));
				p_Instance.Connections.Add(s_CtrRef);
			}
			
			s_Connections.Reader.Dispose();
			p_Instance.AudioEventMappings.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BundleAssetName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.EventList.Clear();
			(RimeReader Reader, uint Count) s_EventList = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_EventList.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UIEventAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_EventList.Reader.ReadUInt32()));
				p_Instance.EventList.Add(s_CtrRef);
			}
			
			s_EventList.Reader.Dispose();
			p_Instance.Modal = p_Reader.ReadBool();
			p_Instance.ProtectScreens = p_Reader.ReadBool();
			p_Instance.IsWin32UIGraphAsset = p_Reader.ReadBool();
			p_Instance.IsXenonUIGraphAsset = p_Reader.ReadBool();
			p_Instance.IsPs3UIGraphAsset = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
