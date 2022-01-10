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
	[ContainerType(16, 496)]
	public class FiringFunctionData : 
		GameDataContainer
	{
		[ContainerField(8)]
		public List<FiringDispersionData> Dispersion { get; set; } = new();

		[ContainerField(12)]
		public SoldierWeaponDispersion WeaponDispersion { get; set; } = new();

		[ContainerField(80)]
		public List<FireEffectData> FireEffects1p { get; set; } = new();

		[ContainerField(84)]
		public List<FireEffectData> FireEffects3p { get; set; } = new();

		[ContainerField(88)]
		public CtrRef<SoundAsset> Sound { get; set; } = new();

		[ContainerField(96)]
		public ShotConfigData Shot { get; set; } = new();

		[ContainerField(192)]
		public FireLogicData FireLogic { get; set; } = new();

		[ContainerField(344)]
		public AmmoConfigData Ammo { get; set; } = new();

		[ContainerField(384)]
		public OverHeatData OverHeat { get; set; } = new();

		[ContainerField(480), LayoutImmutable, Blittable]
		public float SelfHealTimeWhenDeployed { get; set; }

		[ContainerField(484), LayoutImmutable, Blittable]
		public float AmmoCrateReloadDelay { get; set; }

		[ContainerField(488), LayoutImmutable, Blittable]
		public bool UnlimitedAmmoForAI { get; set; }

		[ContainerField(489), LayoutImmutable, Blittable]
		public bool UsePrimaryAmmo { get; set; }

		public static void Deserialize(FiringFunctionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Dispersion.Clear();
			(RimeReader Reader, uint Count) s_Dispersion = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Dispersion.Count; ++i)
			{
				var s_Value = new FiringDispersionData();
				fb.FiringDispersionData.Deserialize(s_Value, s_Dispersion.Reader, p_Parser);
				p_Instance.Dispersion.Add(s_Value);
			}
			
			s_Dispersion.Reader.Dispose();
			fb.SoldierWeaponDispersion.Deserialize(p_Instance.WeaponDispersion, p_Reader, p_Parser);
			p_Instance.FireEffects1p.Clear();
			(RimeReader Reader, uint Count) s_FireEffects1p = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_FireEffects1p.Count; ++i)
			{
				var s_Value = new FireEffectData();
				fb.FireEffectData.Deserialize(s_Value, s_FireEffects1p.Reader, p_Parser);
				p_Instance.FireEffects1p.Add(s_Value);
			}
			
			s_FireEffects1p.Reader.Dispose();
			p_Instance.FireEffects3p.Clear();
			(RimeReader Reader, uint Count) s_FireEffects3p = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_FireEffects3p.Count; ++i)
			{
				var s_Value = new FireEffectData();
				fb.FireEffectData.Deserialize(s_Value, s_FireEffects3p.Reader, p_Parser);
				p_Instance.FireEffects3p.Add(s_Value);
			}
			
			s_FireEffects3p.Reader.Dispose();
			p_Instance.Sound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.ShotConfigData.Deserialize(p_Instance.Shot, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.FireLogicData.Deserialize(p_Instance.FireLogic, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.AmmoConfigData.Deserialize(p_Instance.Ammo, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.OverHeatData.Deserialize(p_Instance.OverHeat, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.SelfHealTimeWhenDeployed = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.AmmoCrateReloadDelay = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UnlimitedAmmoForAI = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UsePrimaryAmmo = p_Reader.ReadBool();
			p_Reader.Seek(14, SeekOrigin.Current);
		}

	}
}
