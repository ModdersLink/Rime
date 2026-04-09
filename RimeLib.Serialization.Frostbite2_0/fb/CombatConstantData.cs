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
	[ContainerType(4, 120)]
	public partial class CombatConstantData :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _PoseTransitionFireDelay;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _ChangePoseStopDelay;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _AllowCrouchFiringWaterLevel;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _PoseChangeLockoutTime;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _ExplosionInterestRange;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _ExplosiveObjectSearchRadius;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _ExplosiveBlastMultiplier;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _MaxSuppressDistance;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _MaxSuppressorsRatio;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _SuppressOffsetXz;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _SuppressOffsetY;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _SuppressMinLOFDistance;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _SuppressMinLOFOffsetDistance;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _InvestigateCoverSearchWidth;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _InvestigateAroundTargetRadius;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _InvestigateFreeLookRadius;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _InvestigatePauseTimeMin;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _InvestigatePauseTimeMax;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _AvoidC4Time;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _StandStillMinTime;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _StationaryBailDistance;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _PrecisionTimeout;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _CloseRangeAccuracyDistance;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _FightFromPathRadius;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _SmokeRadius;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _SmokeLifeTime;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _MeleeCooldown;

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
