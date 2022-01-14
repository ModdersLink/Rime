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
	[ContainerType(4, 64)]
	public class WidgetNode : 
		UINodeData
	{
		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<UIWidgetAsset> WidgetAsset { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int FocusIndex { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public int ZDepthLevel { get; set; }

		[ContainerField(32), JsonProperty(Order = 32)]
		public WidgetVerticalAlignment VerticalAlign { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public WidgetHorisontalAlignment HorisontalAlign { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public CtrRef<UIDataBinding> DataBinding { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public List<UIWidgetProperty> WidgetProperties { get; set; } = new();

		[ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		public string InstanceName { get; set; } = string.Empty;

		[ContainerField(52), JsonProperty(Order = 52)]
		public RefArray<UINodePort> Inputs { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public RefArray<UINodePort> Outputs { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public bool AlwaysInFocus { get; set; }

	}
}
