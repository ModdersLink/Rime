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
	[ContainerType(4, 28)]
	public class SubtitleDataNode : 
		TreeNodeBase
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Time { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float DisplayTime { get; set; }

		[ContainerField(20), LayoutImmutable]
		public string SID1 { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string SID2 { get; set; } = string.Empty;

	}
}
