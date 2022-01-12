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
		public RefArray<UINodeData> Nodes { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<GlobalNode> GlobalNode { get; set; } = new();

		[ContainerField(20)]
		public RefArray<UINodeConnection> Connections { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<UIAudioEventAsset> AudioEventMappings { get; set; } = new();

		[ContainerField(28), LayoutImmutable]
		public string BundleAssetName { get; set; } = string.Empty;

		[ContainerField(32)]
		public RefArray<UIEventAsset> EventList { get; set; } = new();

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

	}
}
