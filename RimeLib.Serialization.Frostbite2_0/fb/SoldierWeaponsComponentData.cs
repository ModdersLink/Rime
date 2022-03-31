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
	[ContainerType(16, 480)]
	public class SoldierWeaponsComponentData :
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public LinearTransform AimDir { get; set; } = new();

		[ContainerField(160), JsonProperty(Order = 160)]
		public CtrRef<SkeletonAsset> WeaponSkeleton { get; set; } = new();

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public int PrimaryWeaponId { get; set; }

		[ContainerField(168), JsonProperty(Order = 168)]
		public AnimatedWeaponBinding AnimatedWeaponBinding { get; set; } = new();

		[ContainerField(424), JsonProperty(Order = 424)]
		public Animated1pOnlyWeaponBinding Animated1pOnlyWeaponBinding { get; set; } = new();

		[ContainerField(440), JsonProperty(Order = 440)]
		public Animated3pOnlyWeaponBinding Animated3pOnlyWeaponBinding { get; set; } = new();

		[ContainerField(448), LayoutImmutable, Blittable, JsonProperty(Order = 448)]
		public float LockTimeMultiplier { get; set; }

		[ContainerField(452), LayoutImmutable, Blittable, JsonProperty(Order = 452)]
		public int GrenadeIncrease { get; set; }

		[ContainerField(456), LayoutImmutable, Blittable, JsonProperty(Order = 456)]
		public float AmmoClipIncreaseMultiplier { get; set; }

		[ContainerField(460), LayoutImmutable, Blittable, JsonProperty(Order = 460)]
		public float ExplosiveIncreaseMultiplier { get; set; }

		[ContainerField(464), LayoutImmutable, Blittable, JsonProperty(Order = 464)]
		public int UnderslungGrenadeIncrease { get; set; }

		[ContainerField(468), LayoutImmutable, Blittable, JsonProperty(Order = 468)]
		public bool UseExternalAimDir { get; set; }

		[ContainerField(469), LayoutImmutable, Blittable, JsonProperty(Order = 469)]
		public bool UnlimitedAmmo { get; set; }

		[ContainerField(470), LayoutImmutable, Blittable, JsonProperty(Order = 470)]
		public bool UnlimitedMags { get; set; }

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
