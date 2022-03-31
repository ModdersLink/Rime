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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 160)]
	public class CharacterLightingComponentData :
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec3 BottomLight { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec3 TopLight { get; set; } = new();

		[ContainerField(128), JsonProperty(Order = 128)]
		public CharacterLightingMode CharacterLightingMode { get; set; } = new();

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float CameraUpRotation { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float TopLightDirY { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float BlendFactor { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float TopLightDirX { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public bool LockToCameraDirection { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		public bool FirstPersonEnable { get; set; }

		[ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		public bool CharacterLightEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			BottomLight.Serialize(p_Writer, p_EbxWriter);
			TopLight.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) CharacterLightingMode);
			p_Writer.Write(CameraUpRotation);
			p_Writer.Write(TopLightDirY);
			p_Writer.Write(BlendFactor);
			p_Writer.Write(TopLightDirX);
			p_Writer.Write(LockToCameraDirection);
			p_Writer.Write(FirstPersonEnable);
			p_Writer.Write(CharacterLightEnable);
			p_Writer.WriteNullBytes(9);
		}
	}
}
