///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 48)]
	public class ProcessorData : 
		EmitterComponentData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec4 DefaultValues { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<ProcessorData> NextProcessor { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<EmitterComponentData> Pre { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public EmittableField EvaluatorInput { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool Enable { get; set; }

	}
}
