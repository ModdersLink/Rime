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
	[ContainerType(4, 72)]
	public class UIPageHeaderBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo Header { get; set; } = new();

		[ContainerField(24)]
		public UIDataSourceInfo SubHeader { get; set; } = new();

		[ContainerField(40)]
		public UIDataSourceInfo Icon { get; set; } = new();

		[ContainerField(56), LayoutImmutable]
		public string StaticHeader { get; set; } = string.Empty;

		[ContainerField(60), LayoutImmutable]
		public string StaticSubHeader { get; set; } = string.Empty;

		[ContainerField(64), LayoutImmutable]
		public string StaticIcon { get; set; } = string.Empty;

		[ContainerField(68)]
		public List<UILevelSpecificPageHeader> LevelSpecificHeaders { get; set; } = new();

	}
}
