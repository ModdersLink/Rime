///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SoldierWeaponsComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform AimDir { get; set; } = new LinearTransform(); // 0x60 (96)
		
		[ContainerField(160)]
		public CtrRef<SkeletonAsset> WeaponSkeleton { get; set; } = new CtrRef<SkeletonAsset>(); // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public int PrimaryWeaponId { get; set; } // 0xA4 (164)
		
		[ContainerField(168)]
		public AnimatedWeaponBinding AnimatedWeaponBinding { get; set; } = new AnimatedWeaponBinding(); // 0xA8 (168)
		
		[ContainerField(424)]
		public Animated1pOnlyWeaponBinding Animated1pOnlyWeaponBinding { get; set; } = new Animated1pOnlyWeaponBinding(); // 0x1A8 (424)
		
		[ContainerField(440)]
		public Animated3pOnlyWeaponBinding Animated3pOnlyWeaponBinding { get; set; } = new Animated3pOnlyWeaponBinding(); // 0x1B8 (440)
		
		[ContainerField(448), LayoutImmutable, Blittable]
		public float LockTimeMultiplier { get; set; } // 0x1C0 (448)
		
		[ContainerField(452), LayoutImmutable, Blittable]
		public int GrenadeIncrease { get; set; } // 0x1C4 (452)
		
		[ContainerField(456), LayoutImmutable, Blittable]
		public float AmmoClipIncreaseMultiplier { get; set; } // 0x1C8 (456)
		
		[ContainerField(460), LayoutImmutable, Blittable]
		public float ExplosiveIncreaseMultiplier { get; set; } // 0x1CC (460)
		
		[ContainerField(464), LayoutImmutable, Blittable]
		public int UnderslungGrenadeIncrease { get; set; } // 0x1D0 (464)
		
		[ContainerField(468), LayoutImmutable, Blittable]
		public bool UseExternalAimDir { get; set; } // 0x1D4 (468)
		
		[ContainerField(469), LayoutImmutable, Blittable]
		public bool UnlimitedAmmo { get; set; } // 0x1D5 (469)
		
		[ContainerField(470), LayoutImmutable, Blittable]
		public bool UnlimitedMags { get; set; } // 0x1D6 (470)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2495031935:
					AimDir = (LinearTransform) p_Value;
					break;

				case 170547750:
					WeaponSkeleton = (CtrRef<SkeletonAsset>) p_Value;
					break;

				case 2577280838:
					PrimaryWeaponId = (int) p_Value;
					break;

				case 2545459481:
					AnimatedWeaponBinding = (AnimatedWeaponBinding) p_Value;
					break;

				case 2092774924:
					Animated1pOnlyWeaponBinding = (Animated1pOnlyWeaponBinding) p_Value;
					break;

				case 2729217678:
					Animated3pOnlyWeaponBinding = (Animated3pOnlyWeaponBinding) p_Value;
					break;

				case 1309101584:
					LockTimeMultiplier = (float) p_Value;
					break;

				case 2234856031:
					GrenadeIncrease = (int) p_Value;
					break;

				case 1503904946:
					AmmoClipIncreaseMultiplier = (float) p_Value;
					break;

				case 1624823149:
					ExplosiveIncreaseMultiplier = (float) p_Value;
					break;

				case 4031664884:
					UnderslungGrenadeIncrease = (int) p_Value;
					break;

				case 4048604289:
					UseExternalAimDir = (bool) p_Value;
					break;

				case 348431844:
					UnlimitedAmmo = (bool) p_Value;
					break;

				case 348292018:
					UnlimitedMags = (bool) p_Value;
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
				case 2495031935:
					return AimDir;

				case 170547750:
					return WeaponSkeleton;

				case 2577280838:
					return PrimaryWeaponId;

				case 2545459481:
					return AnimatedWeaponBinding;

				case 2092774924:
					return Animated1pOnlyWeaponBinding;

				case 2729217678:
					return Animated3pOnlyWeaponBinding;

				case 1309101584:
					return LockTimeMultiplier;

				case 2234856031:
					return GrenadeIncrease;

				case 1503904946:
					return AmmoClipIncreaseMultiplier;

				case 1624823149:
					return ExplosiveIncreaseMultiplier;

				case 4031664884:
					return UnderslungGrenadeIncrease;

				case 4048604289:
					return UseExternalAimDir;

				case 348431844:
					return UnlimitedAmmo;

				case 348292018:
					return UnlimitedMags;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2495031935:
					return typeof(SoldierWeaponsComponentData).GetProperty(nameof(AimDir));

				case 170547750:
					return typeof(SoldierWeaponsComponentData).GetProperty(nameof(WeaponSkeleton));

				case 2577280838:
					return typeof(SoldierWeaponsComponentData).GetProperty(nameof(PrimaryWeaponId));

				case 2545459481:
					return typeof(SoldierWeaponsComponentData).GetProperty(nameof(AnimatedWeaponBinding));

				case 2092774924:
					return typeof(SoldierWeaponsComponentData).GetProperty(nameof(Animated1pOnlyWeaponBinding));

				case 2729217678:
					return typeof(SoldierWeaponsComponentData).GetProperty(nameof(Animated3pOnlyWeaponBinding));

				case 1309101584:
					return typeof(SoldierWeaponsComponentData).GetProperty(nameof(LockTimeMultiplier));

				case 2234856031:
					return typeof(SoldierWeaponsComponentData).GetProperty(nameof(GrenadeIncrease));

				case 1503904946:
					return typeof(SoldierWeaponsComponentData).GetProperty(nameof(AmmoClipIncreaseMultiplier));

				case 1624823149:
					return typeof(SoldierWeaponsComponentData).GetProperty(nameof(ExplosiveIncreaseMultiplier));

				case 4031664884:
					return typeof(SoldierWeaponsComponentData).GetProperty(nameof(UnderslungGrenadeIncrease));

				case 4048604289:
					return typeof(SoldierWeaponsComponentData).GetProperty(nameof(UseExternalAimDir));

				case 348431844:
					return typeof(SoldierWeaponsComponentData).GetProperty(nameof(UnlimitedAmmo));

				case 348292018:
					return typeof(SoldierWeaponsComponentData).GetProperty(nameof(UnlimitedMags));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
