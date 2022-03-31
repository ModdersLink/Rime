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
	[ContainerType(16, 128)]
	public class RenderVolumeEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public Vec4 UserMasks { get; set; } = new();

		[ContainerField(96), JsonProperty(Order = 96)]
		public SurfaceShaderInstanceDataStruct Shader { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public RenderVolumeTransformType TransformType { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public bool Enabled { get; set; }

	}
}
