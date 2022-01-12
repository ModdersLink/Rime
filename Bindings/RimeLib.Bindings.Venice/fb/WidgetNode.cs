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
	[ContainerType(4, 64)]
	public class WidgetNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UIWidgetAsset> WidgetAsset { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public int FocusIndex { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public int ZDepthLevel { get; set; }

		[ContainerField(32)]
		public WidgetVerticalAlignment VerticalAlign { get; set; } = new();

		[ContainerField(36)]
		public WidgetHorisontalAlignment HorisontalAlign { get; set; } = new();

		[ContainerField(40)]
		public CtrRef<UIDataBinding> DataBinding { get; set; } = new();

		[ContainerField(44)]
		public List<UIWidgetProperty> WidgetProperties { get; set; } = new();

		[ContainerField(48), LayoutImmutable]
		public string InstanceName { get; set; } = string.Empty;

		[ContainerField(52)]
		public RefArray<UINodePort> Inputs { get; set; } = new();

		[ContainerField(56)]
		public RefArray<UINodePort> Outputs { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool AlwaysInFocus { get; set; }

	}
}
