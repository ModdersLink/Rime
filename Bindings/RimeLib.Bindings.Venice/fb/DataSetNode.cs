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
	[ContainerType(4, 52)]
	public class DataSetNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UINodePort> In { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<UINodePort> Out { get; set; } = new();

		[ContainerField(28), LayoutImmutable]
		public string Param { get; set; } = string.Empty;

		[ContainerField(32)]
		public UIDataSourceInfo DataSource { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool SetToEmptyString { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable]
		public bool ForceUpdate { get; set; }

	}
}
