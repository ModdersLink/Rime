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
	[ContainerType(4, 120)]
	public class CombatConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float PoseTransitionFireDelay { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float ChangePoseStopDelay { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float AllowCrouchFiringWaterLevel { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float PoseChangeLockoutTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float ExplosionInterestRange { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ExplosiveObjectSearchRadius { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float ExplosiveBlastMultiplier { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaxSuppressDistance { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float MaxSuppressorsRatio { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float SuppressOffsetXz { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float SuppressOffsetY { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float SuppressMinLOFDistance { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float SuppressMinLOFOffsetDistance { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float InvestigateCoverSearchWidth { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float InvestigateAroundTargetRadius { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float InvestigateFreeLookRadius { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float InvestigatePauseTimeMin { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float InvestigatePauseTimeMax { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float AvoidC4Time { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float StandStillMinTime { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float StationaryBailDistance { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float PrecisionTimeout { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float CloseRangeAccuracyDistance { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float FightFromPathRadius { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float SmokeRadius { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float SmokeLifeTime { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float MeleeCooldown { get; set; }

		public static void Deserialize(CombatConstantData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PoseTransitionFireDelay = p_Reader.ReadSingle();
			p_Instance.ChangePoseStopDelay = p_Reader.ReadSingle();
			p_Instance.AllowCrouchFiringWaterLevel = p_Reader.ReadSingle();
			p_Instance.PoseChangeLockoutTime = p_Reader.ReadSingle();
			p_Instance.ExplosionInterestRange = p_Reader.ReadSingle();
			p_Instance.ExplosiveObjectSearchRadius = p_Reader.ReadSingle();
			p_Instance.ExplosiveBlastMultiplier = p_Reader.ReadSingle();
			p_Instance.MaxSuppressDistance = p_Reader.ReadSingle();
			p_Instance.MaxSuppressorsRatio = p_Reader.ReadSingle();
			p_Instance.SuppressOffsetXz = p_Reader.ReadSingle();
			p_Instance.SuppressOffsetY = p_Reader.ReadSingle();
			p_Instance.SuppressMinLOFDistance = p_Reader.ReadSingle();
			p_Instance.SuppressMinLOFOffsetDistance = p_Reader.ReadSingle();
			p_Instance.InvestigateCoverSearchWidth = p_Reader.ReadSingle();
			p_Instance.InvestigateAroundTargetRadius = p_Reader.ReadSingle();
			p_Instance.InvestigateFreeLookRadius = p_Reader.ReadSingle();
			p_Instance.InvestigatePauseTimeMin = p_Reader.ReadSingle();
			p_Instance.InvestigatePauseTimeMax = p_Reader.ReadSingle();
			p_Instance.AvoidC4Time = p_Reader.ReadSingle();
			p_Instance.StandStillMinTime = p_Reader.ReadSingle();
			p_Instance.StationaryBailDistance = p_Reader.ReadSingle();
			p_Instance.PrecisionTimeout = p_Reader.ReadSingle();
			p_Instance.CloseRangeAccuracyDistance = p_Reader.ReadSingle();
			p_Instance.FightFromPathRadius = p_Reader.ReadSingle();
			p_Instance.SmokeRadius = p_Reader.ReadSingle();
			p_Instance.SmokeLifeTime = p_Reader.ReadSingle();
			p_Instance.MeleeCooldown = p_Reader.ReadSingle();
		}

	}
}
