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
	[ContainerType(4, 64)]
	public partial class WeaponFiringData :
		GameDataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private CtrRef<FiringFunctionData> _PrimaryFire = new();

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _DeployTime;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _ReactivateCooldownTime;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _DisableZoomOnDeployTime;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _AltDeployTime;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private int _AltDeployId;

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CtrRef<WeaponSwayData> _WeaponSway = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _SupportDelayProne;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _SupportDelayStand;

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private RumbleFiringData _Rumble = new();

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private bool _InflictSelfDamage;

		[ObservableProperty]
		[property: ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		private bool _UseAutoAiming;

		[ObservableProperty]
		[property: ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		private bool _ShowEnemyNametagOnAim;

		[ObservableProperty]
		[property: ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		private bool _ReloadWholeMags;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private bool _DisableReloadWhileSprinting;

		[ObservableProperty]
		[property: ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		private bool _AbortReloadOnSprint;

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
