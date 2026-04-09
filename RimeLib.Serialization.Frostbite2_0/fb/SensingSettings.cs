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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(8, 168)]
	public partial class SensingSettings :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private double _SensingTimeSpan;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private double _AttackerTrackTime;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private double _LineOfSightTestTime;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private int _MaxRays;

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private VisionBoxSettings _CharacterVisionBoxSettings = new();

		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private VisionBoxSettings _VehicleVisionBoxSettings = new();

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _CloseFireImpactDistance;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _CloseExplosiveImpactDistance;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _CloseTrajectoryDistance;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _ImpactSenseDistance;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _MaxVolume;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _MaxSize;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _MaxSpeed;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _VolumeModifier;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _MovementModifier;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _LuckModifier;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _BackgroundLoudnessFactor;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _MotionSizeFactor;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _MotionSpeedFactor;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _MotionPeripheralityFactor;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _MotionDistanceFactor;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _SmokeSphereRadius;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _SmokeSphereDuration;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _SpawnOutOfLOSRaycastHeight;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _SpawnOutOfLOSTraceDistance;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _SpawnOutOfLOSRaycastDistance;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _SpawnOutOfLOSRadius;

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private CtrRef<SensingTemplateData> _DefaultTemplate = new();

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
