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
	public class InstanceNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UIGraphAsset> UIGraph { get; set; } = new();

		[ContainerField(24)]
		public RefArray<UINodePort> Inputs { get; set; } = new();

		[ContainerField(28)]
		public RefArray<UINodePort> Outputs { get; set; } = new();

	}
}
