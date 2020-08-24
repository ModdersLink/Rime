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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class SoldierSoundData : 
		DataContainer
	{
		protected CtrRef<SoundAsset> m_Movement = new CtrRef<SoundAsset>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(1609263334), ContainerCtrRef]
		public CtrRef<SoundAsset> Movement { get { return m_Movement; } set { if (OnPropertyChanging("SoldierSoundData." + nameof(Movement), this, m_Movement, value)) m_Movement = value; } } // 0x8 (8)
		
		protected CtrRef<SoundAsset> m_Death = new CtrRef<SoundAsset>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(208763161), ContainerCtrRef]
		public CtrRef<SoundAsset> Death { get { return m_Death; } set { if (OnPropertyChanging("SoldierSoundData." + nameof(Death), this, m_Death, value)) m_Death = value; } } // 0xC (12)
		
		protected CtrRef<SoundAsset> m_BulletImpact = new CtrRef<SoundAsset>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(1157477793), ContainerCtrRef]
		public CtrRef<SoundAsset> BulletImpact { get { return m_BulletImpact; } set { if (OnPropertyChanging("SoldierSoundData." + nameof(BulletImpact), this, m_BulletImpact, value)) m_BulletImpact = value; } } // 0x10 (16)
		
		protected CtrRef<SoundAsset> m_Healing = new CtrRef<SoundAsset>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(2008873029), ContainerCtrRef]
		public CtrRef<SoundAsset> Healing { get { return m_Healing; } set { if (OnPropertyChanging("SoldierSoundData." + nameof(Healing), this, m_Healing, value)) m_Healing = value; } } // 0x14 (20)
		
		protected CtrRef<SoundAsset> m_BreathControl = new CtrRef<SoundAsset>();
		[ContainerField(24), MemberInfoFlag(53), ContainerFieldNameHash(2325792682), ContainerCtrRef]
		public CtrRef<SoundAsset> BreathControl { get { return m_BreathControl; } set { if (OnPropertyChanging("SoldierSoundData." + nameof(BreathControl), this, m_BreathControl, value)) m_BreathControl = value; } } // 0x18 (24)
		
		protected CtrRef<SoundAsset> m_HitIndicator = new CtrRef<SoundAsset>();
		[ContainerField(28), MemberInfoFlag(53), ContainerFieldNameHash(4272287985), ContainerCtrRef]
		public CtrRef<SoundAsset> HitIndicator { get { return m_HitIndicator; } set { if (OnPropertyChanging("SoldierSoundData." + nameof(HitIndicator), this, m_HitIndicator, value)) m_HitIndicator = value; } } // 0x1C (28)
		
		protected CtrRef<SoundAsset> m_PickupKit = new CtrRef<SoundAsset>();
		[ContainerField(32), MemberInfoFlag(53), ContainerFieldNameHash(2091679527), ContainerCtrRef]
		public CtrRef<SoundAsset> PickupKit { get { return m_PickupKit; } set { if (OnPropertyChanging("SoldierSoundData." + nameof(PickupKit), this, m_PickupKit, value)) m_PickupKit = value; } } // 0x20 (32)
		
		protected CtrRef<SoundAsset> m_PickupAmmo = new CtrRef<SoundAsset>();
		[ContainerField(36), MemberInfoFlag(53), ContainerFieldNameHash(305470687), ContainerCtrRef]
		public CtrRef<SoundAsset> PickupAmmo { get { return m_PickupAmmo; } set { if (OnPropertyChanging("SoldierSoundData." + nameof(PickupAmmo), this, m_PickupAmmo, value)) m_PickupAmmo = value; } } // 0x24 (36)
		
		protected float m_SprintTimeForRecovery = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4109042602)]
		public float SprintTimeForRecovery { get { return m_SprintTimeForRecovery; } set { if (OnPropertyChanging("SoldierSoundData." + nameof(SprintTimeForRecovery), this, m_SprintTimeForRecovery, value)) m_SprintTimeForRecovery = value; } } // 0x28 (40)
		
		protected float m_MovementThreshold = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2275026641)]
		public float MovementThreshold { get { return m_MovementThreshold; } set { if (OnPropertyChanging("SoldierSoundData." + nameof(MovementThreshold), this, m_MovementThreshold, value)) m_MovementThreshold = value; } } // 0x2C (44)
		
		protected float m_MinHealSoundTime = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4130615641)]
		public float MinHealSoundTime { get { return m_MinHealSoundTime; } set { if (OnPropertyChanging("SoldierSoundData." + nameof(MinHealSoundTime), this, m_MinHealSoundTime, value)) m_MinHealSoundTime = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1609263334:
					Movement = (CtrRef<SoundAsset>) p_Value;
					break;

				case 208763161:
					Death = (CtrRef<SoundAsset>) p_Value;
					break;

				case 1157477793:
					BulletImpact = (CtrRef<SoundAsset>) p_Value;
					break;

				case 2008873029:
					Healing = (CtrRef<SoundAsset>) p_Value;
					break;

				case 2325792682:
					BreathControl = (CtrRef<SoundAsset>) p_Value;
					break;

				case 4272287985:
					HitIndicator = (CtrRef<SoundAsset>) p_Value;
					break;

				case 2091679527:
					PickupKit = (CtrRef<SoundAsset>) p_Value;
					break;

				case 305470687:
					PickupAmmo = (CtrRef<SoundAsset>) p_Value;
					break;

				case 4109042602:
					SprintTimeForRecovery = (float) p_Value;
					break;

				case 2275026641:
					MovementThreshold = (float) p_Value;
					break;

				case 4130615641:
					MinHealSoundTime = (float) p_Value;
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
				case 1609263334:
					return Movement;

				case 208763161:
					return Death;

				case 1157477793:
					return BulletImpact;

				case 2008873029:
					return Healing;

				case 2325792682:
					return BreathControl;

				case 4272287985:
					return HitIndicator;

				case 2091679527:
					return PickupKit;

				case 305470687:
					return PickupAmmo;

				case 4109042602:
					return SprintTimeForRecovery;

				case 2275026641:
					return MovementThreshold;

				case 4130615641:
					return MinHealSoundTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1609263334:
					return typeof(SoldierSoundData).GetProperty(nameof(Movement));

				case 208763161:
					return typeof(SoldierSoundData).GetProperty(nameof(Death));

				case 1157477793:
					return typeof(SoldierSoundData).GetProperty(nameof(BulletImpact));

				case 2008873029:
					return typeof(SoldierSoundData).GetProperty(nameof(Healing));

				case 2325792682:
					return typeof(SoldierSoundData).GetProperty(nameof(BreathControl));

				case 4272287985:
					return typeof(SoldierSoundData).GetProperty(nameof(HitIndicator));

				case 2091679527:
					return typeof(SoldierSoundData).GetProperty(nameof(PickupKit));

				case 305470687:
					return typeof(SoldierSoundData).GetProperty(nameof(PickupAmmo));

				case 4109042602:
					return typeof(SoldierSoundData).GetProperty(nameof(SprintTimeForRecovery));

				case 2275026641:
					return typeof(SoldierSoundData).GetProperty(nameof(MovementThreshold));

				case 4130615641:
					return typeof(SoldierSoundData).GetProperty(nameof(MinHealSoundTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
