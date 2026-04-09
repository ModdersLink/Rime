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
	[ContainerType(4, 76)]
	public partial class UISoldierCompData :
		UIComponentData
	{
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _CriticalHealthThreshold;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _HitShaderDamageMultiplier;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _HitShaderMinDamage;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _EKGLineThickness;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private int _ShockTraumaAbilityIndex;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private int _RangerPTProgramAbilityIndex;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private int _FocusAbilityIndex;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _EKGLineAlpha;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _HitShaderGradientDurationMultiplier;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _HitShaderMaxDamage;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _HitShaderIndicatorDurationMultiplier;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private bool _UseVehicleTeamSpawn;

		[ObservableProperty]
		[property: ContainerField(73), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
		private bool _UseSquadSpawn;

		[ObservableProperty]
		[property: ContainerField(74), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
		private bool _SpawnOnSquadLeaders;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(CriticalHealthThreshold);
			p_Writer.Write(HitShaderDamageMultiplier);
			p_Writer.Write(HitShaderMinDamage);
			p_Writer.Write(EKGLineThickness);
			p_Writer.Write(ShockTraumaAbilityIndex);
			p_Writer.Write(RangerPTProgramAbilityIndex);
			p_Writer.Write(FocusAbilityIndex);
			p_Writer.Write(EKGLineAlpha);
			p_Writer.Write(HitShaderGradientDurationMultiplier);
			p_Writer.Write(HitShaderMaxDamage);
			p_Writer.Write(HitShaderIndicatorDurationMultiplier);
			p_Writer.Write(UseVehicleTeamSpawn);
			p_Writer.Write(UseSquadSpawn);
			p_Writer.Write(SpawnOnSquadLeaders);
			p_Writer.WriteNullBytes(1);
		}
	}
}
