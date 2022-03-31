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
	[ContainerType(16, 496)]
	public class FiringFunctionData :
		GameDataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<FiringDispersionData> Dispersion { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public SoldierWeaponDispersion WeaponDispersion { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public List<FireEffectData> FireEffects1p { get; set; } = new();

		[ContainerField(84), JsonProperty(Order = 84)]
		public List<FireEffectData> FireEffects3p { get; set; } = new();

		[ContainerField(88), JsonProperty(Order = 88)]
		public CtrRef<SoundAsset> Sound { get; set; } = new();

		[ContainerField(96), JsonProperty(Order = 96)]
		public ShotConfigData Shot { get; set; } = new();

		[ContainerField(192), JsonProperty(Order = 192)]
		public FireLogicData FireLogic { get; set; } = new();

		[ContainerField(344), JsonProperty(Order = 344)]
		public AmmoConfigData Ammo { get; set; } = new();

		[ContainerField(384), JsonProperty(Order = 384)]
		public OverHeatData OverHeat { get; set; } = new();

		[ContainerField(480), LayoutImmutable, Blittable, JsonProperty(Order = 480)]
		public float SelfHealTimeWhenDeployed { get; set; }

		[ContainerField(484), LayoutImmutable, Blittable, JsonProperty(Order = 484)]
		public float AmmoCrateReloadDelay { get; set; }

		[ContainerField(488), LayoutImmutable, Blittable, JsonProperty(Order = 488)]
		public bool UnlimitedAmmoForAI { get; set; }

		[ContainerField(489), LayoutImmutable, Blittable, JsonProperty(Order = 489)]
		public bool UsePrimaryAmmo { get; set; }

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
