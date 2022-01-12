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
	[ContainerType(4, 20)]
	public class UIEventAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string Category { get; set; } = string.Empty;

		[ContainerField(16)]
		public List<string> EventList { get; set; } = new();

	}
}
