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
	[ContainerType(4, 120)]
	public class CombatConstantData :
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float PoseTransitionFireDelay { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float ChangePoseStopDelay { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float AllowCrouchFiringWaterLevel { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float PoseChangeLockoutTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float ExplosionInterestRange { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float ExplosiveObjectSearchRadius { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float ExplosiveBlastMultiplier { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float MaxSuppressDistance { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float MaxSuppressorsRatio { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float SuppressOffsetXz { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float SuppressOffsetY { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float SuppressMinLOFDistance { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float SuppressMinLOFOffsetDistance { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float InvestigateCoverSearchWidth { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float InvestigateAroundTargetRadius { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float InvestigateFreeLookRadius { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float InvestigatePauseTimeMin { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float InvestigatePauseTimeMax { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float AvoidC4Time { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float StandStillMinTime { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float StationaryBailDistance { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float PrecisionTimeout { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float CloseRangeAccuracyDistance { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float FightFromPathRadius { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float SmokeRadius { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float SmokeLifeTime { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float MeleeCooldown { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(PoseTransitionFireDelay);
			p_Writer.Write(ChangePoseStopDelay);
			p_Writer.Write(AllowCrouchFiringWaterLevel);
			p_Writer.Write(PoseChangeLockoutTime);
			p_Writer.Write(ExplosionInterestRange);
			p_Writer.Write(ExplosiveObjectSearchRadius);
			p_Writer.Write(ExplosiveBlastMultiplier);
			p_Writer.Write(MaxSuppressDistance);
			p_Writer.Write(MaxSuppressorsRatio);
			p_Writer.Write(SuppressOffsetXz);
			p_Writer.Write(SuppressOffsetY);
			p_Writer.Write(SuppressMinLOFDistance);
			p_Writer.Write(SuppressMinLOFOffsetDistance);
			p_Writer.Write(InvestigateCoverSearchWidth);
			p_Writer.Write(InvestigateAroundTargetRadius);
			p_Writer.Write(InvestigateFreeLookRadius);
			p_Writer.Write(InvestigatePauseTimeMin);
			p_Writer.Write(InvestigatePauseTimeMax);
			p_Writer.Write(AvoidC4Time);
			p_Writer.Write(StandStillMinTime);
			p_Writer.Write(StationaryBailDistance);
			p_Writer.Write(PrecisionTimeout);
			p_Writer.Write(CloseRangeAccuracyDistance);
			p_Writer.Write(FightFromPathRadius);
			p_Writer.Write(SmokeRadius);
			p_Writer.Write(SmokeLifeTime);
			p_Writer.Write(MeleeCooldown);
		}
	}
}
