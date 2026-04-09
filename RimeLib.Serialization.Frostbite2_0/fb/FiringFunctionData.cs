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
	[ContainerType(16, 496)]
	public partial class FiringFunctionData :
		GameDataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private List<FiringDispersionData> _Dispersion = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private SoldierWeaponDispersion _WeaponDispersion = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private List<FireEffectData> _FireEffects1p = new();

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private List<FireEffectData> _FireEffects3p = new();

		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private CtrRef<SoundAsset> _Sound = new();

		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private ShotConfigData _Shot = new();

		[ObservableProperty]
		[property: ContainerField(192), JsonProperty(Order = 192)]
		private FireLogicData _FireLogic = new();

		[ObservableProperty]
		[property: ContainerField(344), JsonProperty(Order = 344)]
		private AmmoConfigData _Ammo = new();

		[ObservableProperty]
		[property: ContainerField(384), JsonProperty(Order = 384)]
		private OverHeatData _OverHeat = new();

		[ObservableProperty]
		[property: ContainerField(480), LayoutImmutable, Blittable, JsonProperty(Order = 480)]
		private float _SelfHealTimeWhenDeployed;

		[ObservableProperty]
		[property: ContainerField(484), LayoutImmutable, Blittable, JsonProperty(Order = 484)]
		private float _AmmoCrateReloadDelay;

		[ObservableProperty]
		[property: ContainerField(488), LayoutImmutable, Blittable, JsonProperty(Order = 488)]
		private bool _UnlimitedAmmoForAI;

		[ObservableProperty]
		[property: ContainerField(489), LayoutImmutable, Blittable, JsonProperty(Order = 489)]
		private bool _UsePrimaryAmmo;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Dispersion = p_EbxWriter.GetArrayWriter(Dispersion.GetType(), Dispersion.Count);
			p_Writer.Write(s_Dispersion.ArrayIndex);
			foreach (var s_Entry in Dispersion)
			{
				s_Entry.Serialize(s_Dispersion.Writer, p_EbxWriter);
			}
			WeaponDispersion.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_FireEffects1p = p_EbxWriter.GetArrayWriter(FireEffects1p.GetType(), FireEffects1p.Count);
			p_Writer.Write(s_FireEffects1p.ArrayIndex);
			foreach (var s_Entry in FireEffects1p)
			{
				s_Entry.Serialize(s_FireEffects1p.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_FireEffects3p = p_EbxWriter.GetArrayWriter(FireEffects3p.GetType(), FireEffects3p.Count);
			p_Writer.Write(s_FireEffects3p.ArrayIndex);
			foreach (var s_Entry in FireEffects3p)
			{
				s_Entry.Serialize(s_FireEffects3p.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Sound));
			p_Writer.WriteNullBytes(4);
			Shot.Serialize(p_Writer, p_EbxWriter);
			FireLogic.Serialize(p_Writer, p_EbxWriter);
			Ammo.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			OverHeat.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SelfHealTimeWhenDeployed);
			p_Writer.Write(AmmoCrateReloadDelay);
			p_Writer.Write(UnlimitedAmmoForAI);
			p_Writer.Write(UsePrimaryAmmo);
			p_Writer.WriteNullBytes(6);
		}
	}
}
