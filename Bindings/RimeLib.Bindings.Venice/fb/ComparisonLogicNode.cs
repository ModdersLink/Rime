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
	[ContainerType(4, 48)]
	public class ComparisonLogicNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UINodePort> In { get; set; } = new();

		[ContainerField(24)]
		public RefArray<UINodePort> Outputs { get; set; } = new();

		[ContainerField(28)]
		public UIDataSourceInfo DataSourceInfo { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool SkipFractionals { get; set; }

	}
}
