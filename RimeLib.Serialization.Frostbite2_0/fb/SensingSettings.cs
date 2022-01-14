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
	[ContainerType(8, 168)]
	public class SensingSettings :
		Asset
	{
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public double SensingTimeSpan { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public double AttackerTrackTime { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public double LineOfSightTestTime { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public int MaxRays { get; set; }

		[ContainerField(44), JsonProperty(Order = 44)]
		public VisionBoxSettings CharacterVisionBoxSettings { get; set; } = new();

		[ContainerField(60), JsonProperty(Order = 60)]
		public VisionBoxSettings VehicleVisionBoxSettings { get; set; } = new();

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float CloseFireImpactDistance { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float CloseExplosiveImpactDistance { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float CloseTrajectoryDistance { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float ImpactSenseDistance { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float MaxVolume { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float MaxSize { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float MaxSpeed { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float VolumeModifier { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float MovementModifier { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float LuckModifier { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float BackgroundLoudnessFactor { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float MotionSizeFactor { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float MotionSpeedFactor { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float MotionPeripheralityFactor { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float MotionDistanceFactor { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float SmokeSphereRadius { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float SmokeSphereDuration { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float SpawnOutOfLOSRaycastHeight { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float SpawnOutOfLOSTraceDistance { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float SpawnOutOfLOSRaycastDistance { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float SpawnOutOfLOSRadius { get; set; }

		[ContainerField(160), JsonProperty(Order = 160)]
		public CtrRef<SensingTemplateData> DefaultTemplate { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			p_Writer.Write(SensingTimeSpan);
			p_Writer.Write(AttackerTrackTime);
			p_Writer.Write(LineOfSightTestTime);
			p_Writer.Write(MaxRays);
			CharacterVisionBoxSettings.Serialize(p_Writer, p_EbxWriter);
			VehicleVisionBoxSettings.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(CloseFireImpactDistance);
			p_Writer.Write(CloseExplosiveImpactDistance);
			p_Writer.Write(CloseTrajectoryDistance);
			p_Writer.Write(ImpactSenseDistance);
			p_Writer.Write(MaxVolume);
			p_Writer.Write(MaxSize);
			p_Writer.Write(MaxSpeed);
			p_Writer.Write(VolumeModifier);
			p_Writer.Write(MovementModifier);
			p_Writer.Write(LuckModifier);
			p_Writer.Write(BackgroundLoudnessFactor);
			p_Writer.Write(MotionSizeFactor);
			p_Writer.Write(MotionSpeedFactor);
			p_Writer.Write(MotionPeripheralityFactor);
			p_Writer.Write(MotionDistanceFactor);
			p_Writer.Write(SmokeSphereRadius);
			p_Writer.Write(SmokeSphereDuration);
			p_Writer.Write(SpawnOutOfLOSRaycastHeight);
			p_Writer.Write(SpawnOutOfLOSTraceDistance);
			p_Writer.Write(SpawnOutOfLOSRaycastDistance);
			p_Writer.Write(SpawnOutOfLOSRadius);
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultTemplate));
			p_Writer.WriteNullBytes(4);
		}
	}
}
