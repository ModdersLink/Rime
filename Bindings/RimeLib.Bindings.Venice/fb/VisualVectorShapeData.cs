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
	[ContainerType(4, 44)]
	public class VisualVectorShapeData : 
		VectorShapeData
	{
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float ErrorTolerance { get; set; }

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<SurfaceShaderBaseAsset> Shader3d { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public uint DrawOrderIndex { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float TessellationTriangleSize { get; set; }

	}
}
