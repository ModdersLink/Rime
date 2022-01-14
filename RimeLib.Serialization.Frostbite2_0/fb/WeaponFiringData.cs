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
	[ContainerType(4, 64)]
	public class WeaponFiringData :
		GameDataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<FiringFunctionData> PrimaryFire { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float DeployTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float ReactivateCooldownTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float DisableZoomOnDeployTime { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float AltDeployTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public int AltDeployId { get; set; }

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<WeaponSwayData> WeaponSway { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float SupportDelayProne { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float SupportDelayStand { get; set; }

		[ContainerField(44), JsonProperty(Order = 44)]
		public RumbleFiringData Rumble { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public bool InflictSelfDamage { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		public bool UseAutoAiming { get; set; }

		[ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		public bool ShowEnemyNametagOnAim { get; set; }

		[ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		public bool ReloadWholeMags { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public bool DisableReloadWhileSprinting { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		public bool AbortReloadOnSprint { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(PrimaryFire));
			p_Writer.Write(DeployTime);
			p_Writer.Write(ReactivateCooldownTime);
			p_Writer.Write(DisableZoomOnDeployTime);
			p_Writer.Write(AltDeployTime);
			p_Writer.Write(AltDeployId);
			p_Writer.Write(p_EbxWriter.WriteImport(WeaponSway));
			p_Writer.Write(SupportDelayProne);
			p_Writer.Write(SupportDelayStand);
			Rumble.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(InflictSelfDamage);
			p_Writer.Write(UseAutoAiming);
			p_Writer.Write(ShowEnemyNametagOnAim);
			p_Writer.Write(ReloadWholeMags);
			p_Writer.Write(DisableReloadWhileSprinting);
			p_Writer.Write(AbortReloadOnSprint);
			p_Writer.WriteNullBytes(2);
		}
	}
}
