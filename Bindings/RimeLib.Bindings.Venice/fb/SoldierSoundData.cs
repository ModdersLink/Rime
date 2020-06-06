///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoldierSoundData : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SoundAsset> Movement { get; set; } = new CtrRef<SoundAsset>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<SoundAsset> Death { get; set; } = new CtrRef<SoundAsset>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<SoundAsset> BulletImpact { get; set; } = new CtrRef<SoundAsset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<SoundAsset> Healing { get; set; } = new CtrRef<SoundAsset>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<SoundAsset> BreathControl { get; set; } = new CtrRef<SoundAsset>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<SoundAsset> HitIndicator { get; set; } = new CtrRef<SoundAsset>(); // 0x1C (28)
		
		[ContainerField(32)]
		public CtrRef<SoundAsset> PickupKit { get; set; } = new CtrRef<SoundAsset>(); // 0x20 (32)
		
		[ContainerField(36)]
		public CtrRef<SoundAsset> PickupAmmo { get; set; } = new CtrRef<SoundAsset>(); // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float SprintTimeForRecovery { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float MovementThreshold { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float MinHealSoundTime { get; set; } // 0x30 (48)
		
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
