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
	[ContainerType(16, 480)]
	public class SoldierWeaponsComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform AimDir { get; set; } = new();

		[ContainerField(160)]
		public CtrRef<SkeletonAsset> WeaponSkeleton { get; set; } = new();

		[ContainerField(164), LayoutImmutable, Blittable]
		public int PrimaryWeaponId { get; set; }

		[ContainerField(168)]
		public AnimatedWeaponBinding AnimatedWeaponBinding { get; set; } = new();

		[ContainerField(424)]
		public Animated1pOnlyWeaponBinding Animated1pOnlyWeaponBinding { get; set; } = new();

		[ContainerField(440)]
		public Animated3pOnlyWeaponBinding Animated3pOnlyWeaponBinding { get; set; } = new();

		[ContainerField(448), LayoutImmutable, Blittable]
		public float LockTimeMultiplier { get; set; }

		[ContainerField(452), LayoutImmutable, Blittable]
		public int GrenadeIncrease { get; set; }

		[ContainerField(456), LayoutImmutable, Blittable]
		public float AmmoClipIncreaseMultiplier { get; set; }

		[ContainerField(460), LayoutImmutable, Blittable]
		public float ExplosiveIncreaseMultiplier { get; set; }

		[ContainerField(464), LayoutImmutable, Blittable]
		public int UnderslungGrenadeIncrease { get; set; }

		[ContainerField(468), LayoutImmutable, Blittable]
		public bool UseExternalAimDir { get; set; }

		[ContainerField(469), LayoutImmutable, Blittable]
		public bool UnlimitedAmmo { get; set; }

		[ContainerField(470), LayoutImmutable, Blittable]
		public bool UnlimitedMags { get; set; }

		public static void Deserialize(SoldierWeaponsComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.LinearTransform.Deserialize(p_Instance.AimDir, p_Reader, p_Parser);
			p_Instance.WeaponSkeleton.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.PrimaryWeaponId = p_Reader.ReadInt32();
			fb.AnimatedWeaponBinding.Deserialize(p_Instance.AnimatedWeaponBinding, p_Reader, p_Parser);
			fb.Animated1pOnlyWeaponBinding.Deserialize(p_Instance.Animated1pOnlyWeaponBinding, p_Reader, p_Parser);
			fb.Animated3pOnlyWeaponBinding.Deserialize(p_Instance.Animated3pOnlyWeaponBinding, p_Reader, p_Parser);
			p_Instance.LockTimeMultiplier = p_Reader.ReadSingle();
			p_Instance.GrenadeIncrease = p_Reader.ReadInt32();
			p_Instance.AmmoClipIncreaseMultiplier = p_Reader.ReadSingle();
			p_Instance.ExplosiveIncreaseMultiplier = p_Reader.ReadSingle();
			p_Instance.UnderslungGrenadeIncrease = p_Reader.ReadInt32();
			p_Instance.UseExternalAimDir = p_Reader.ReadBool();
			p_Instance.UnlimitedAmmo = p_Reader.ReadBool();
			p_Instance.UnlimitedMags = p_Reader.ReadBool();
			p_Reader.Seek(9, SeekOrigin.Current);
		}

	}
}
