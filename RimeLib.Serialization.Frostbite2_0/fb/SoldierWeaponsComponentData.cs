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
	[ContainerType(16, 480)]
	public partial class SoldierWeaponsComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private LinearTransform _AimDir = new();

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private CtrRef<SkeletonAsset> _WeaponSkeleton = new();

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private int _PrimaryWeaponId;

		[ObservableProperty]
		[property: ContainerField(168), JsonProperty(Order = 168)]
		private AnimatedWeaponBinding _AnimatedWeaponBinding = new();

		[ObservableProperty]
		[property: ContainerField(424), JsonProperty(Order = 424)]
		private Animated1pOnlyWeaponBinding _Animated1pOnlyWeaponBinding = new();

		[ObservableProperty]
		[property: ContainerField(440), JsonProperty(Order = 440)]
		private Animated3pOnlyWeaponBinding _Animated3pOnlyWeaponBinding = new();

		[ObservableProperty]
		[property: ContainerField(448), LayoutImmutable, Blittable, JsonProperty(Order = 448)]
		private float _LockTimeMultiplier;

		[ObservableProperty]
		[property: ContainerField(452), LayoutImmutable, Blittable, JsonProperty(Order = 452)]
		private int _GrenadeIncrease;

		[ObservableProperty]
		[property: ContainerField(456), LayoutImmutable, Blittable, JsonProperty(Order = 456)]
		private float _AmmoClipIncreaseMultiplier;

		[ObservableProperty]
		[property: ContainerField(460), LayoutImmutable, Blittable, JsonProperty(Order = 460)]
		private float _ExplosiveIncreaseMultiplier;

		[ObservableProperty]
		[property: ContainerField(464), LayoutImmutable, Blittable, JsonProperty(Order = 464)]
		private int _UnderslungGrenadeIncrease;

		[ObservableProperty]
		[property: ContainerField(468), LayoutImmutable, Blittable, JsonProperty(Order = 468)]
		private bool _UseExternalAimDir;

		[ObservableProperty]
		[property: ContainerField(469), LayoutImmutable, Blittable, JsonProperty(Order = 469)]
		private bool _UnlimitedAmmo;

		[ObservableProperty]
		[property: ContainerField(470), LayoutImmutable, Blittable, JsonProperty(Order = 470)]
		private bool _UnlimitedMags;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AimDir.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(WeaponSkeleton));
			p_Writer.Write(PrimaryWeaponId);
			AnimatedWeaponBinding.Serialize(p_Writer, p_EbxWriter);
			Animated1pOnlyWeaponBinding.Serialize(p_Writer, p_EbxWriter);
			Animated3pOnlyWeaponBinding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(LockTimeMultiplier);
			p_Writer.Write(GrenadeIncrease);
			p_Writer.Write(AmmoClipIncreaseMultiplier);
			p_Writer.Write(ExplosiveIncreaseMultiplier);
			p_Writer.Write(UnderslungGrenadeIncrease);
			p_Writer.Write(UseExternalAimDir);
			p_Writer.Write(UnlimitedAmmo);
			p_Writer.Write(UnlimitedMags);
			p_Writer.WriteNullBytes(9);
		}
	}
}
