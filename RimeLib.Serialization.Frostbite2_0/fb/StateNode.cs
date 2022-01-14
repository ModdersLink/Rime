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

namespace fb
{
	[ContainerType(4, 48)]
	public class StateNode : 
		UINodeData
	{
		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<UIScreenAsset> Screen { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<UINodePort> In { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<UINodePort> Show { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<UINodePort> Hide { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public RefArray<UINodePort> Inputs { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public RefArray<UINodePort> Outputs { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool RenderToTexture { get; set; }

	}
}
