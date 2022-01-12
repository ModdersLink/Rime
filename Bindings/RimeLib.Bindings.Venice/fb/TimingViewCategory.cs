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
	public class TimingViewCategory : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string CategoryName { get; set; } = string.Empty;

		[ContainerField(12)]
		public List<string> Keywords { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float SpuBudget { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float CpuBudget { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float GpuBudget { get; set; }

	}
}
