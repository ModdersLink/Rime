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
	[ContainerType(4, 72)]
	public class UIPageHeaderBinding : 
		UIDataBinding
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public UIDataSourceInfo Header { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public UIDataSourceInfo SubHeader { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public UIDataSourceInfo Icon { get; set; } = new();

		[ContainerField(56), LayoutImmutable, JsonProperty(Order = 56)]
		public string StaticHeader { get; set; } = string.Empty;

		[ContainerField(60), LayoutImmutable, JsonProperty(Order = 60)]
		public string StaticSubHeader { get; set; } = string.Empty;

		[ContainerField(64), LayoutImmutable, JsonProperty(Order = 64)]
		public string StaticIcon { get; set; } = string.Empty;

		[ContainerField(68), JsonProperty(Order = 68)]
		public List<UILevelSpecificPageHeader> LevelSpecificHeaders { get; set; } = new();

	}
}
