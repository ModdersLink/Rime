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
	[ContainerType(4, 32)]
	public class UIStateAsset : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<UIComponentData> UIComponents { get; set; } = new();

		[ContainerField(16)]
		public RefArray<UIAsset> ActionscriptLibraries { get; set; } = new();

		[ContainerField(20)]
		public List<string> ActionscriptNames { get; set; } = new();

		[ContainerField(24), LayoutImmutable]
		public string StateName { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string StatePath { get; set; } = string.Empty;

	}
}
