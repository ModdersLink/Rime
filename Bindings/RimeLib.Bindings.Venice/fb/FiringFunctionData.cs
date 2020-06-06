///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class FiringFunctionData : 
		GameDataContainer
	{
		[ContainerField(8)]
		public List<FiringDispersionData> Dispersion { get; set; } = new List<FiringDispersionData>(); // 0x8 (8)
		
		[ContainerField(12)]
		public SoldierWeaponDispersion WeaponDispersion { get; set; } = new SoldierWeaponDispersion(); // 0xC (12)
		
		[ContainerField(80)]
		public List<FireEffectData> FireEffects1p { get; set; } = new List<FireEffectData>(); // 0x50 (80)
		
		[ContainerField(84)]
		public List<FireEffectData> FireEffects3p { get; set; } = new List<FireEffectData>(); // 0x54 (84)
		
		[ContainerField(88)]
		public CtrRef<SoundAsset> Sound { get; set; } = new CtrRef<SoundAsset>(); // 0x58 (88)
		
		[ContainerField(96)]
		public ShotConfigData Shot { get; set; } = new ShotConfigData(); // 0x60 (96)
		
		[ContainerField(192)]
		public FireLogicData FireLogic { get; set; } = new FireLogicData(); // 0xC0 (192)
		
		[ContainerField(344)]
		public AmmoConfigData Ammo { get; set; } = new AmmoConfigData(); // 0x158 (344)
		
		[ContainerField(384)]
		public OverHeatData OverHeat { get; set; } = new OverHeatData(); // 0x180 (384)
		
		[ContainerField(480), LayoutImmutable, Blittable]
		public float SelfHealTimeWhenDeployed { get; set; } // 0x1E0 (480)
		
		[ContainerField(484), LayoutImmutable, Blittable]
		public float AmmoCrateReloadDelay { get; set; } // 0x1E4 (484)
		
		[ContainerField(488), LayoutImmutable, Blittable]
		public bool UnlimitedAmmoForAI { get; set; } // 0x1E8 (488)
		
		[ContainerField(489), LayoutImmutable, Blittable]
		public bool UsePrimaryAmmo { get; set; } // 0x1E9 (489)
		
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
