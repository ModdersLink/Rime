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
	[ContainerType(8, 168)]
	public class SensingSettings : 
		Asset
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public double SensingTimeSpan { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public double AttackerTrackTime { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public double LineOfSightTestTime { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public int MaxRays { get; set; }

		[ContainerField(44)]
		public VisionBoxSettings CharacterVisionBoxSettings { get; set; } = new();

		[ContainerField(60)]
		public VisionBoxSettings VehicleVisionBoxSettings { get; set; } = new();

		[ContainerField(76), LayoutImmutable, Blittable]
		public float CloseFireImpactDistance { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float CloseExplosiveImpactDistance { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float CloseTrajectoryDistance { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float ImpactSenseDistance { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float MaxVolume { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float MaxSize { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float MaxSpeed { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float VolumeModifier { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float MovementModifier { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float LuckModifier { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float BackgroundLoudnessFactor { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float MotionSizeFactor { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float MotionSpeedFactor { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float MotionPeripheralityFactor { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float MotionDistanceFactor { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float SmokeSphereRadius { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float SmokeSphereDuration { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float SpawnOutOfLOSRaycastHeight { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float SpawnOutOfLOSTraceDistance { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float SpawnOutOfLOSRaycastDistance { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float SpawnOutOfLOSRadius { get; set; }

		[ContainerField(160)]
		public CtrRef<SensingTemplateData> DefaultTemplate { get; set; } = new();

		public static void Deserialize(SensingSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.SensingTimeSpan = p_Reader.ReadDouble();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.AttackerTrackTime = p_Reader.ReadDouble();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.LineOfSightTestTime = p_Reader.ReadDouble();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MaxRays = p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.VisionBoxSettings.Deserialize(p_Instance.CharacterVisionBoxSettings, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.VisionBoxSettings.Deserialize(p_Instance.VehicleVisionBoxSettings, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.CloseFireImpactDistance = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.CloseExplosiveImpactDistance = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.CloseTrajectoryDistance = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ImpactSenseDistance = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MaxVolume = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MaxSize = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MaxSpeed = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.VolumeModifier = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MovementModifier = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.LuckModifier = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.BackgroundLoudnessFactor = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MotionSizeFactor = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MotionSpeedFactor = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MotionPeripheralityFactor = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MotionDistanceFactor = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.SmokeSphereRadius = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.SmokeSphereDuration = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.SpawnOutOfLOSRaycastHeight = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.SpawnOutOfLOSTraceDistance = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.SpawnOutOfLOSRaycastDistance = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.SpawnOutOfLOSRadius = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DefaultTemplate.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
