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
	public class UINodeConnection : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<UINodeData> SourceNode { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<UINodeData> TargetNode { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<UINodePort> SourcePort { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<UINodePort> TargetPort { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public int NumScreensToPop { get; set; }

	}
}
