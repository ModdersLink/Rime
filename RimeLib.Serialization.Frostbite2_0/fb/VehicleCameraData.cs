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
	[ContainerType(16, 256)]
	public class VehicleCameraData :
		TargetCameraData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public Vec3 MoveToPosition { get; set; } = new();

		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public Vec3 MoveToPositionSlopeFactor { get; set; } = new();

		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public Vec3 TargetOffset { get; set; } = new();

		[ContainerField(208), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public Vec3 TargetOffsetSlopeFactor { get; set; } = new();

		[ContainerField(224), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public Vec3 RotationFactor { get; set; } = new();

		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public float PositionFactor { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		public float ResetDistance { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		public bool FixedPosition { get; set; }

		[ContainerField(249), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
		public bool FixedAngleZ { get; set; }

		[ContainerField(250), LayoutImmutable, Blittable, JsonProperty(Order = 250)]
		public bool UseTerrainAdjustment { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			MoveToPosition.Serialize(p_Writer, p_EbxWriter);
			MoveToPositionSlopeFactor.Serialize(p_Writer, p_EbxWriter);
			TargetOffset.Serialize(p_Writer, p_EbxWriter);
			TargetOffsetSlopeFactor.Serialize(p_Writer, p_EbxWriter);
			RotationFactor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(PositionFactor);
			p_Writer.Write(ResetDistance);
			p_Writer.Write(FixedPosition);
			p_Writer.Write(FixedAngleZ);
			p_Writer.Write(UseTerrainAdjustment);
			p_Writer.WriteNullBytes(5);
		}
	}
}
