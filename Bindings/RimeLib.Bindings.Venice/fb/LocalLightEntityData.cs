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
	[ContainerType(16, 160)]
	public class LocalLightEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Color { get; set; } = new();

		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ParticleColorScale { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 EnlightenColorScale { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public float Radius { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float Intensity { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float AttenuationOffset { get; set; }

		[ContainerField(140)]
		public EnlightenColorMode EnlightenColorMode { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable]
		public bool EnlightenEnable { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable]
		public bool Visible { get; set; }

		[ContainerField(146), LayoutImmutable, Blittable]
		public bool SpecularEnable { get; set; }

		public static void Deserialize(LocalLightEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.Color, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.ParticleColorScale, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.EnlightenColorScale, p_Reader, p_Parser);
			p_Instance.Radius = p_Reader.ReadSingle();
			p_Instance.Intensity = p_Reader.ReadSingle();
			p_Instance.AttenuationOffset = p_Reader.ReadSingle();
			p_Instance.EnlightenColorMode = (EnlightenColorMode) p_Reader.ReadInt32();
			p_Instance.EnlightenEnable = p_Reader.ReadBool();
			p_Instance.Visible = p_Reader.ReadBool();
			p_Instance.SpecularEnable = p_Reader.ReadBool();
			p_Reader.Seek(13, SeekOrigin.Current);
		}

	}
}
