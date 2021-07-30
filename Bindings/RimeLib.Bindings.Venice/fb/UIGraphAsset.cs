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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class UIGraphAsset : 
		Asset
	{
		protected RefArray<UINodeData> m_Nodes = new RefArray<UINodeData>();
		[ContainerField(Name: "Nodes", Offset: 12, NameHash: 215794742, Flags: 65)]
		public RefArray<UINodeData> Nodes { get { return m_Nodes; } set { if (OnPropertyChanging("UIGraphAsset." + nameof(Nodes), this, m_Nodes, value)) m_Nodes = value; } } // 0xC (12)
		
		protected CtrRef<GlobalNode> m_GlobalNode = new CtrRef<GlobalNode>();
		[ContainerField(Name: "GlobalNode", Offset: 16, NameHash: 4020629102, Flags: 53)]
		public CtrRef<GlobalNode> GlobalNode { get { return m_GlobalNode; } set { if (OnPropertyChanging("UIGraphAsset." + nameof(GlobalNode), this, m_GlobalNode, value)) m_GlobalNode = value; } } // 0x10 (16)
		
		protected RefArray<UINodeConnection> m_Connections = new RefArray<UINodeConnection>();
		[ContainerField(Name: "Connections", Offset: 20, NameHash: 1202806848, Flags: 65)]
		public RefArray<UINodeConnection> Connections { get { return m_Connections; } set { if (OnPropertyChanging("UIGraphAsset." + nameof(Connections), this, m_Connections, value)) m_Connections = value; } } // 0x14 (20)
		
		protected CtrRef<UIAudioEventAsset> m_AudioEventMappings = new CtrRef<UIAudioEventAsset>();
		[ContainerField(Name: "AudioEventMappings", Offset: 24, NameHash: 3437982272, Flags: 53)]
		public CtrRef<UIAudioEventAsset> AudioEventMappings { get { return m_AudioEventMappings; } set { if (OnPropertyChanging("UIGraphAsset." + nameof(AudioEventMappings), this, m_AudioEventMappings, value)) m_AudioEventMappings = value; } } // 0x18 (24)
		
		protected string m_BundleAssetName = string.Empty;
		[ContainerField(Name: "BundleAssetName", Offset: 28, NameHash: 948318150, Flags: 16509), LayoutImmutable]
		public string BundleAssetName { get { return m_BundleAssetName; } set { if (OnPropertyChanging("UIGraphAsset." + nameof(BundleAssetName), this, m_BundleAssetName, value)) m_BundleAssetName = value; } } // 0x1C (28)
		
		protected RefArray<UIEventAsset> m_EventList = new RefArray<UIEventAsset>();
		[ContainerField(Name: "EventList", Offset: 32, NameHash: 4132327979, Flags: 65)]
		public RefArray<UIEventAsset> EventList { get { return m_EventList; } set { if (OnPropertyChanging("UIGraphAsset." + nameof(EventList), this, m_EventList, value)) m_EventList = value; } } // 0x20 (32)
		
		protected bool m_Modal = new bool();
		[ContainerField(Name: "Modal", Offset: 36, NameHash: 210010926, Flags: 49325), LayoutImmutable, Blittable]
		public bool Modal { get { return m_Modal; } set { if (OnPropertyChanging("UIGraphAsset." + nameof(Modal), this, m_Modal, value)) m_Modal = value; } } // 0x24 (36)
		
		protected bool m_ProtectScreens = new bool();
		[ContainerField(Name: "ProtectScreens", Offset: 37, NameHash: 1751026961, Flags: 49325), LayoutImmutable, Blittable]
		public bool ProtectScreens { get { return m_ProtectScreens; } set { if (OnPropertyChanging("UIGraphAsset." + nameof(ProtectScreens), this, m_ProtectScreens, value)) m_ProtectScreens = value; } } // 0x25 (37)
		
		protected bool m_IsWin32UIGraphAsset = new bool();
		[ContainerField(Name: "IsWin32UIGraphAsset", Offset: 38, NameHash: 1711914190, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsWin32UIGraphAsset { get { return m_IsWin32UIGraphAsset; } set { if (OnPropertyChanging("UIGraphAsset." + nameof(IsWin32UIGraphAsset), this, m_IsWin32UIGraphAsset, value)) m_IsWin32UIGraphAsset = value; } } // 0x26 (38)
		
		protected bool m_IsXenonUIGraphAsset = new bool();
		[ContainerField(Name: "IsXenonUIGraphAsset", Offset: 39, NameHash: 3514658573, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsXenonUIGraphAsset { get { return m_IsXenonUIGraphAsset; } set { if (OnPropertyChanging("UIGraphAsset." + nameof(IsXenonUIGraphAsset), this, m_IsXenonUIGraphAsset, value)) m_IsXenonUIGraphAsset = value; } } // 0x27 (39)
		
		protected bool m_IsPs3UIGraphAsset = new bool();
		[ContainerField(Name: "IsPs3UIGraphAsset", Offset: 40, NameHash: 1700956271, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsPs3UIGraphAsset { get { return m_IsPs3UIGraphAsset; } set { if (OnPropertyChanging("UIGraphAsset." + nameof(IsPs3UIGraphAsset), this, m_IsPs3UIGraphAsset, value)) m_IsPs3UIGraphAsset = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 215794742:
					Nodes = (RefArray<UINodeData>) p_Value;
					break;

				case 4020629102:
					GlobalNode = (CtrRef<GlobalNode>) p_Value;
					break;

				case 1202806848:
					Connections = (RefArray<UINodeConnection>) p_Value;
					break;

				case 3437982272:
					AudioEventMappings = (CtrRef<UIAudioEventAsset>) p_Value;
					break;

				case 948318150:
					BundleAssetName = (string) p_Value;
					break;

				case 4132327979:
					EventList = (RefArray<UIEventAsset>) p_Value;
					break;

				case 210010926:
					Modal = (bool) p_Value;
					break;

				case 1751026961:
					ProtectScreens = (bool) p_Value;
					break;

				case 1711914190:
					IsWin32UIGraphAsset = (bool) p_Value;
					break;

				case 3514658573:
					IsXenonUIGraphAsset = (bool) p_Value;
					break;

				case 1700956271:
					IsPs3UIGraphAsset = (bool) p_Value;
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
				case 215794742:
					return Nodes;

				case 4020629102:
					return GlobalNode;

				case 1202806848:
					return Connections;

				case 3437982272:
					return AudioEventMappings;

				case 948318150:
					return BundleAssetName;

				case 4132327979:
					return EventList;

				case 210010926:
					return Modal;

				case 1751026961:
					return ProtectScreens;

				case 1711914190:
					return IsWin32UIGraphAsset;

				case 3514658573:
					return IsXenonUIGraphAsset;

				case 1700956271:
					return IsPs3UIGraphAsset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 215794742:
					return typeof(UIGraphAsset).GetProperty(nameof(Nodes));

				case 4020629102:
					return typeof(UIGraphAsset).GetProperty(nameof(GlobalNode));

				case 1202806848:
					return typeof(UIGraphAsset).GetProperty(nameof(Connections));

				case 3437982272:
					return typeof(UIGraphAsset).GetProperty(nameof(AudioEventMappings));

				case 948318150:
					return typeof(UIGraphAsset).GetProperty(nameof(BundleAssetName));

				case 4132327979:
					return typeof(UIGraphAsset).GetProperty(nameof(EventList));

				case 210010926:
					return typeof(UIGraphAsset).GetProperty(nameof(Modal));

				case 1751026961:
					return typeof(UIGraphAsset).GetProperty(nameof(ProtectScreens));

				case 1711914190:
					return typeof(UIGraphAsset).GetProperty(nameof(IsWin32UIGraphAsset));

				case 3514658573:
					return typeof(UIGraphAsset).GetProperty(nameof(IsXenonUIGraphAsset));

				case 1700956271:
					return typeof(UIGraphAsset).GetProperty(nameof(IsPs3UIGraphAsset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
