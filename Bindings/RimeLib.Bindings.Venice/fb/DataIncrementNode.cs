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
	[ContainerType(4, 56)]
	public class DataIncrementNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UINodePort> In { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<UINodePort> Out { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public float Max { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float Min { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float IncrementSize { get; set; }

		[ContainerField(40)]
		public UIDataSourceInfo DataSource { get; set; } = new();

	}
}
