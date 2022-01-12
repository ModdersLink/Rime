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
	[ContainerType(4, 48)]
	public class StateNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UIScreenAsset> Screen { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<UINodePort> In { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<UINodePort> Show { get; set; } = new();

		[ContainerField(32)]
		public CtrRef<UINodePort> Hide { get; set; } = new();

		[ContainerField(36)]
		public RefArray<UINodePort> Inputs { get; set; } = new();

		[ContainerField(40)]
		public RefArray<UINodePort> Outputs { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool RenderToTexture { get; set; }

	}
}
