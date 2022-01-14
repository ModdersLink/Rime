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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 64)]
	public class MissionObjectiveHudData :
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 CameraPosition { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec2 HorizontalBoundaries { get; set; } = new();

		[ContainerField(40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public Vec2 VerticalBoundaries { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float CameraRotation { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float CameraFov { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float CameraLookDistance { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float CameraDistance { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			CameraPosition.Serialize(p_Writer, p_EbxWriter);
			HorizontalBoundaries.Serialize(p_Writer, p_EbxWriter);
			VerticalBoundaries.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(CameraRotation);
			p_Writer.Write(CameraFov);
			p_Writer.Write(CameraLookDistance);
			p_Writer.Write(CameraDistance);
		}
	}
}
