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

	}
}
