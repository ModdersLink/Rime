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
	[ContainerType(4, 76)]
	public class UISoldierCompData :
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float CriticalHealthThreshold { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float HitShaderDamageMultiplier { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float HitShaderMinDamage { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float EKGLineThickness { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public int ShockTraumaAbilityIndex { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public int RangerPTProgramAbilityIndex { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public int FocusAbilityIndex { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float EKGLineAlpha { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float HitShaderGradientDurationMultiplier { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float HitShaderMaxDamage { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float HitShaderIndicatorDurationMultiplier { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public bool UseVehicleTeamSpawn { get; set; }

		[ContainerField(73), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
		public bool UseSquadSpawn { get; set; }

		[ContainerField(74), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
		public bool SpawnOnSquadLeaders { get; set; }

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
