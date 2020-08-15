///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16)]
	public class FiringFunctionData : 
		GameDataContainer
	{
		protected List<FiringDispersionData> m_Dispersion = new List<FiringDispersionData>();
		[ContainerField(8), ContainerFieldNameHash(1858542823)]
		public List<FiringDispersionData> Dispersion { get { return m_Dispersion; } set { if (OnPropertyChanging("FiringFunctionData." + nameof(Dispersion), this, m_Dispersion, value)) m_Dispersion = value; } } // 0x8 (8)
		
		protected SoldierWeaponDispersion m_WeaponDispersion = new SoldierWeaponDispersion();
		[ContainerField(12), ContainerFieldNameHash(1873092453)]
		public SoldierWeaponDispersion WeaponDispersion { get { return m_WeaponDispersion; } set { if (OnPropertyChanging("FiringFunctionData." + nameof(WeaponDispersion), this, m_WeaponDispersion, value)) m_WeaponDispersion = value; } } // 0xC (12)
		
		protected List<FireEffectData> m_FireEffects1p = new List<FireEffectData>();
		[ContainerField(80), ContainerFieldNameHash(3749424600)]
		public List<FireEffectData> FireEffects1p { get { return m_FireEffects1p; } set { if (OnPropertyChanging("FiringFunctionData." + nameof(FireEffects1p), this, m_FireEffects1p, value)) m_FireEffects1p = value; } } // 0x50 (80)
		
		protected List<FireEffectData> m_FireEffects3p = new List<FireEffectData>();
		[ContainerField(84), ContainerFieldNameHash(3749424538)]
		public List<FireEffectData> FireEffects3p { get { return m_FireEffects3p; } set { if (OnPropertyChanging("FiringFunctionData." + nameof(FireEffects3p), this, m_FireEffects3p, value)) m_FireEffects3p = value; } } // 0x54 (84)
		
		protected CtrRef<SoundAsset> m_Sound = new CtrRef<SoundAsset>();
		[ContainerField(88), ContainerFieldNameHash(231353798)]
		public CtrRef<SoundAsset> Sound { get { return m_Sound; } set { if (OnPropertyChanging("FiringFunctionData." + nameof(Sound), this, m_Sound, value)) m_Sound = value; } } // 0x58 (88)
		
		protected ShotConfigData m_Shot = new ShotConfigData();
		[ContainerField(96), ContainerFieldNameHash(2089430885)]
		public ShotConfigData Shot { get { return m_Shot; } set { if (OnPropertyChanging("FiringFunctionData." + nameof(Shot), this, m_Shot, value)) m_Shot = value; } } // 0x60 (96)
		
		protected FireLogicData m_FireLogic = new FireLogicData();
		[ContainerField(192), ContainerFieldNameHash(1556251859)]
		public FireLogicData FireLogic { get { return m_FireLogic; } set { if (OnPropertyChanging("FiringFunctionData." + nameof(FireLogic), this, m_FireLogic, value)) m_FireLogic = value; } } // 0xC0 (192)
		
		protected AmmoConfigData m_Ammo = new AmmoConfigData();
		[ContainerField(344), ContainerFieldNameHash(2088639403)]
		public AmmoConfigData Ammo { get { return m_Ammo; } set { if (OnPropertyChanging("FiringFunctionData." + nameof(Ammo), this, m_Ammo, value)) m_Ammo = value; } } // 0x158 (344)
		
		protected OverHeatData m_OverHeat = new OverHeatData();
		[ContainerField(384), ContainerFieldNameHash(3716934067)]
		public OverHeatData OverHeat { get { return m_OverHeat; } set { if (OnPropertyChanging("FiringFunctionData." + nameof(OverHeat), this, m_OverHeat, value)) m_OverHeat = value; } } // 0x180 (384)
		
		protected float m_SelfHealTimeWhenDeployed = new float();
		[ContainerField(480), LayoutImmutable, Blittable, ContainerFieldNameHash(462585362)]
		public float SelfHealTimeWhenDeployed { get { return m_SelfHealTimeWhenDeployed; } set { if (OnPropertyChanging("FiringFunctionData." + nameof(SelfHealTimeWhenDeployed), this, m_SelfHealTimeWhenDeployed, value)) m_SelfHealTimeWhenDeployed = value; } } // 0x1E0 (480)
		
		protected float m_AmmoCrateReloadDelay = new float();
		[ContainerField(484), LayoutImmutable, Blittable, ContainerFieldNameHash(2347122798)]
		public float AmmoCrateReloadDelay { get { return m_AmmoCrateReloadDelay; } set { if (OnPropertyChanging("FiringFunctionData." + nameof(AmmoCrateReloadDelay), this, m_AmmoCrateReloadDelay, value)) m_AmmoCrateReloadDelay = value; } } // 0x1E4 (484)
		
		protected bool m_UnlimitedAmmoForAI = new bool();
		[ContainerField(488), LayoutImmutable, Blittable, ContainerFieldNameHash(2708726775)]
		public bool UnlimitedAmmoForAI { get { return m_UnlimitedAmmoForAI; } set { if (OnPropertyChanging("FiringFunctionData." + nameof(UnlimitedAmmoForAI), this, m_UnlimitedAmmoForAI, value)) m_UnlimitedAmmoForAI = value; } } // 0x1E8 (488)
		
		protected bool m_UsePrimaryAmmo = new bool();
		[ContainerField(489), LayoutImmutable, Blittable, ContainerFieldNameHash(1249980612)]
		public bool UsePrimaryAmmo { get { return m_UsePrimaryAmmo; } set { if (OnPropertyChanging("FiringFunctionData." + nameof(UsePrimaryAmmo), this, m_UsePrimaryAmmo, value)) m_UsePrimaryAmmo = value; } } // 0x1E9 (489)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1858542823:
					Dispersion = (List<FiringDispersionData>) p_Value;
					break;

				case 1873092453:
					WeaponDispersion = (SoldierWeaponDispersion) p_Value;
					break;

				case 3749424600:
					FireEffects1p = (List<FireEffectData>) p_Value;
					break;

				case 3749424538:
					FireEffects3p = (List<FireEffectData>) p_Value;
					break;

				case 231353798:
					Sound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 2089430885:
					Shot = (ShotConfigData) p_Value;
					break;

				case 1556251859:
					FireLogic = (FireLogicData) p_Value;
					break;

				case 2088639403:
					Ammo = (AmmoConfigData) p_Value;
					break;

				case 3716934067:
					OverHeat = (OverHeatData) p_Value;
					break;

				case 462585362:
					SelfHealTimeWhenDeployed = (float) p_Value;
					break;

				case 2347122798:
					AmmoCrateReloadDelay = (float) p_Value;
					break;

				case 2708726775:
					UnlimitedAmmoForAI = (bool) p_Value;
					break;

				case 1249980612:
					UsePrimaryAmmo = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1858542823:
					return Dispersion;

				case 1873092453:
					return WeaponDispersion;

				case 3749424600:
					return FireEffects1p;

				case 3749424538:
					return FireEffects3p;

				case 231353798:
					return Sound;

				case 2089430885:
					return Shot;

				case 1556251859:
					return FireLogic;

				case 2088639403:
					return Ammo;

				case 3716934067:
					return OverHeat;

				case 462585362:
					return SelfHealTimeWhenDeployed;

				case 2347122798:
					return AmmoCrateReloadDelay;

				case 2708726775:
					return UnlimitedAmmoForAI;

				case 1249980612:
					return UsePrimaryAmmo;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1858542823:
					return typeof(FiringFunctionData).GetProperty(nameof(Dispersion));

				case 1873092453:
					return typeof(FiringFunctionData).GetProperty(nameof(WeaponDispersion));

				case 3749424600:
					return typeof(FiringFunctionData).GetProperty(nameof(FireEffects1p));

				case 3749424538:
					return typeof(FiringFunctionData).GetProperty(nameof(FireEffects3p));

				case 231353798:
					return typeof(FiringFunctionData).GetProperty(nameof(Sound));

				case 2089430885:
					return typeof(FiringFunctionData).GetProperty(nameof(Shot));

				case 1556251859:
					return typeof(FiringFunctionData).GetProperty(nameof(FireLogic));

				case 2088639403:
					return typeof(FiringFunctionData).GetProperty(nameof(Ammo));

				case 3716934067:
					return typeof(FiringFunctionData).GetProperty(nameof(OverHeat));

				case 462585362:
					return typeof(FiringFunctionData).GetProperty(nameof(SelfHealTimeWhenDeployed));

				case 2347122798:
					return typeof(FiringFunctionData).GetProperty(nameof(AmmoCrateReloadDelay));

				case 2708726775:
					return typeof(FiringFunctionData).GetProperty(nameof(UnlimitedAmmoForAI));

				case 1249980612:
					return typeof(FiringFunctionData).GetProperty(nameof(UsePrimaryAmmo));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
