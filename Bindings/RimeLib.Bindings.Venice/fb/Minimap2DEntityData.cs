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
	[ContainerType(16, 144)]
	public class Minimap2DEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec3 CameraTransform { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public uint ImageHeight { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public uint ImageWidth { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public uint AntialiasMultiplier { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public uint TerrainHeight { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public uint Fov { get; set; }

	}
}
