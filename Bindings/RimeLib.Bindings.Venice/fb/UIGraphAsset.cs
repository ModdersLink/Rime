///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UIGraphAsset : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<UINodeData> Nodes { get; set; } = new RefArray<UINodeData>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<GlobalNode> GlobalNode { get; set; } = new CtrRef<GlobalNode>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<UINodeConnection> Connections { get; set; } = new RefArray<UINodeConnection>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<UIAudioEventAsset> AudioEventMappings { get; set; } = new CtrRef<UIAudioEventAsset>(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable]
		public string BundleAssetName { get; set; } // 0x1C (28)
		
		[ContainerField(32)]
		public RefArray<UIEventAsset> EventList { get; set; } = new RefArray<UIEventAsset>(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool Modal { get; set; } // 0x24 (36)
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool ProtectScreens { get; set; } // 0x25 (37)
		
		[ContainerField(38), LayoutImmutable, Blittable]
		public bool IsWin32UIGraphAsset { get; set; } // 0x26 (38)
		
		[ContainerField(39), LayoutImmutable, Blittable]
		public bool IsXenonUIGraphAsset { get; set; } // 0x27 (39)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool IsPs3UIGraphAsset { get; set; } // 0x28 (40)
		
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
