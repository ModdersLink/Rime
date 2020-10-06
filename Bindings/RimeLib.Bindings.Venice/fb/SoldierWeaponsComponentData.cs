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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(480), ContainerClass]
	public class SoldierWeaponsComponentData : 
		ComponentData
	{
		protected LinearTransform m_AimDir = new LinearTransform();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2495031935)]
		public LinearTransform AimDir { get { return m_AimDir; } set { if (OnPropertyChanging("SoldierWeaponsComponentData." + nameof(AimDir), this, m_AimDir, value)) m_AimDir = value; } } // 0x60 (96)
		
		protected CtrRef<SkeletonAsset> m_WeaponSkeleton = new CtrRef<SkeletonAsset>();
		[ContainerField(160), MemberInfoFlag(53), ContainerFieldNameHash(170547750), ContainerCtrRef]
		public CtrRef<SkeletonAsset> WeaponSkeleton { get { return m_WeaponSkeleton; } set { if (OnPropertyChanging("SoldierWeaponsComponentData." + nameof(WeaponSkeleton), this, m_WeaponSkeleton, value)) m_WeaponSkeleton = value; } } // 0xA0 (160)
		
		protected int m_PrimaryWeaponId = new int();
		[ContainerField(164), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2577280838)]
		public int PrimaryWeaponId { get { return m_PrimaryWeaponId; } set { if (OnPropertyChanging("SoldierWeaponsComponentData." + nameof(PrimaryWeaponId), this, m_PrimaryWeaponId, value)) m_PrimaryWeaponId = value; } } // 0xA4 (164)
		
		protected AnimatedWeaponBinding m_AnimatedWeaponBinding = new AnimatedWeaponBinding();
		[ContainerField(168), MemberInfoFlag(41), ContainerFieldNameHash(2545459481)]
		public AnimatedWeaponBinding AnimatedWeaponBinding { get { return m_AnimatedWeaponBinding; } set { if (OnPropertyChanging("SoldierWeaponsComponentData." + nameof(AnimatedWeaponBinding), this, m_AnimatedWeaponBinding, value)) m_AnimatedWeaponBinding = value; } } // 0xA8 (168)
		
		protected Animated1pOnlyWeaponBinding m_Animated1pOnlyWeaponBinding = new Animated1pOnlyWeaponBinding();
		[ContainerField(424), MemberInfoFlag(41), ContainerFieldNameHash(2092774924)]
		public Animated1pOnlyWeaponBinding Animated1pOnlyWeaponBinding { get { return m_Animated1pOnlyWeaponBinding; } set { if (OnPropertyChanging("SoldierWeaponsComponentData." + nameof(Animated1pOnlyWeaponBinding), this, m_Animated1pOnlyWeaponBinding, value)) m_Animated1pOnlyWeaponBinding = value; } } // 0x1A8 (424)
		
		protected Animated3pOnlyWeaponBinding m_Animated3pOnlyWeaponBinding = new Animated3pOnlyWeaponBinding();
		[ContainerField(440), MemberInfoFlag(41), ContainerFieldNameHash(2729217678)]
		public Animated3pOnlyWeaponBinding Animated3pOnlyWeaponBinding { get { return m_Animated3pOnlyWeaponBinding; } set { if (OnPropertyChanging("SoldierWeaponsComponentData." + nameof(Animated3pOnlyWeaponBinding), this, m_Animated3pOnlyWeaponBinding, value)) m_Animated3pOnlyWeaponBinding = value; } } // 0x1B8 (440)
		
		protected float m_LockTimeMultiplier = new float();
		[ContainerField(448), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1309101584)]
		public float LockTimeMultiplier { get { return m_LockTimeMultiplier; } set { if (OnPropertyChanging("SoldierWeaponsComponentData." + nameof(LockTimeMultiplier), this, m_LockTimeMultiplier, value)) m_LockTimeMultiplier = value; } } // 0x1C0 (448)
		
		protected int m_GrenadeIncrease = new int();
		[ContainerField(452), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2234856031)]
		public int GrenadeIncrease { get { return m_GrenadeIncrease; } set { if (OnPropertyChanging("SoldierWeaponsComponentData." + nameof(GrenadeIncrease), this, m_GrenadeIncrease, value)) m_GrenadeIncrease = value; } } // 0x1C4 (452)
		
		protected float m_AmmoClipIncreaseMultiplier = new float();
		[ContainerField(456), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1503904946)]
		public float AmmoClipIncreaseMultiplier { get { return m_AmmoClipIncreaseMultiplier; } set { if (OnPropertyChanging("SoldierWeaponsComponentData." + nameof(AmmoClipIncreaseMultiplier), this, m_AmmoClipIncreaseMultiplier, value)) m_AmmoClipIncreaseMultiplier = value; } } // 0x1C8 (456)
		
		protected float m_ExplosiveIncreaseMultiplier = new float();
		[ContainerField(460), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1624823149)]
		public float ExplosiveIncreaseMultiplier { get { return m_ExplosiveIncreaseMultiplier; } set { if (OnPropertyChanging("SoldierWeaponsComponentData." + nameof(ExplosiveIncreaseMultiplier), this, m_ExplosiveIncreaseMultiplier, value)) m_ExplosiveIncreaseMultiplier = value; } } // 0x1CC (460)
		
		protected int m_UnderslungGrenadeIncrease = new int();
		[ContainerField(464), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4031664884)]
		public int UnderslungGrenadeIncrease { get { return m_UnderslungGrenadeIncrease; } set { if (OnPropertyChanging("SoldierWeaponsComponentData." + nameof(UnderslungGrenadeIncrease), this, m_UnderslungGrenadeIncrease, value)) m_UnderslungGrenadeIncrease = value; } } // 0x1D0 (464)
		
		protected bool m_UseExternalAimDir = new bool();
		[ContainerField(468), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4048604289)]
		public bool UseExternalAimDir { get { return m_UseExternalAimDir; } set { if (OnPropertyChanging("SoldierWeaponsComponentData." + nameof(UseExternalAimDir), this, m_UseExternalAimDir, value)) m_UseExternalAimDir = value; } } // 0x1D4 (468)
		
		protected bool m_UnlimitedAmmo = new bool();
		[ContainerField(469), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(348431844)]
		public bool UnlimitedAmmo { get { return m_UnlimitedAmmo; } set { if (OnPropertyChanging("SoldierWeaponsComponentData." + nameof(UnlimitedAmmo), this, m_UnlimitedAmmo, value)) m_UnlimitedAmmo = value; } } // 0x1D5 (469)
		
		protected bool m_UnlimitedMags = new bool();
		[ContainerField(470), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(348292018)]
		public bool UnlimitedMags { get { return m_UnlimitedMags; } set { if (OnPropertyChanging("SoldierWeaponsComponentData." + nameof(UnlimitedMags), this, m_UnlimitedMags, value)) m_UnlimitedMags = value; } } // 0x1D6 (470)
		
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
