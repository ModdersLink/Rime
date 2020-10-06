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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(128), ContainerClass]
	public class DropWeaponComponentData : 
		ComponentData
	{
		protected CtrRef<PickupEntityAsset> m_DeathPickup = new CtrRef<PickupEntityAsset>();
		[ContainerField(96), MemberInfoFlag(53), ContainerFieldNameHash(507619053), ContainerCtrRef]
		public CtrRef<PickupEntityAsset> DeathPickup { get { return m_DeathPickup; } set { if (OnPropertyChanging("DropWeaponComponentData." + nameof(DeathPickup), this, m_DeathPickup, value)) m_DeathPickup = value; } } // 0x60 (96)
		
		protected EntryInputActionEnum m_ActionIdentifier = new EntryInputActionEnum();
		[ContainerField(100), MemberInfoFlag(137), ContainerFieldNameHash(2090288440)]
		public EntryInputActionEnum ActionIdentifier { get { return m_ActionIdentifier; } set { if (OnPropertyChanging("DropWeaponComponentData." + nameof(ActionIdentifier), this, m_ActionIdentifier, value)) m_ActionIdentifier = value; } } // 0x64 (100)
		
		protected float m_DropWeaponAfterTime = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1483095999)]
		public float DropWeaponAfterTime { get { return m_DropWeaponAfterTime; } set { if (OnPropertyChanging("DropWeaponComponentData." + nameof(DropWeaponAfterTime), this, m_DropWeaponAfterTime, value)) m_DropWeaponAfterTime = value; } } // 0x68 (104)
		
		protected CtrRef<PickupEntityAsset> m_Pickup = new CtrRef<PickupEntityAsset>();
		[ContainerField(108), MemberInfoFlag(53), ContainerFieldNameHash(3381581553), ContainerCtrRef]
		public CtrRef<PickupEntityAsset> Pickup { get { return m_Pickup; } set { if (OnPropertyChanging("DropWeaponComponentData." + nameof(Pickup), this, m_Pickup, value)) m_Pickup = value; } } // 0x6C (108)
		
		protected List<WeaponSlot> m_ExcludedWeaponSlots = new List<WeaponSlot>();
		[ContainerField(112), MemberInfoFlag(65), ContainerFieldNameHash(1714084178), ContainerArray]
		public List<WeaponSlot> ExcludedWeaponSlots { get { return m_ExcludedWeaponSlots; } set { if (OnPropertyChanging("DropWeaponComponentData." + nameof(ExcludedWeaponSlots), this, m_ExcludedWeaponSlots, value)) m_ExcludedWeaponSlots = value; } } // 0x70 (112)
		
		protected float m_WeaponDropTime = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(961265435)]
		public float WeaponDropTime { get { return m_WeaponDropTime; } set { if (OnPropertyChanging("DropWeaponComponentData." + nameof(WeaponDropTime), this, m_WeaponDropTime, value)) m_WeaponDropTime = value; } } // 0x74 (116)
		
		protected bool m_ListenToAnimationWeaponDropSignal = new bool();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(423346996)]
		public bool ListenToAnimationWeaponDropSignal { get { return m_ListenToAnimationWeaponDropSignal; } set { if (OnPropertyChanging("DropWeaponComponentData." + nameof(ListenToAnimationWeaponDropSignal), this, m_ListenToAnimationWeaponDropSignal, value)) m_ListenToAnimationWeaponDropSignal = value; } } // 0x78 (120)
		
		protected bool m_AllowDropWeaponOnAction = new bool();
		[ContainerField(121), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3589518696)]
		public bool AllowDropWeaponOnAction { get { return m_AllowDropWeaponOnAction; } set { if (OnPropertyChanging("DropWeaponComponentData." + nameof(AllowDropWeaponOnAction), this, m_AllowDropWeaponOnAction, value)) m_AllowDropWeaponOnAction = value; } } // 0x79 (121)
		
		protected bool m_RequireWeaponSlotEmpty = new bool();
		[ContainerField(122), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2054797371)]
		public bool RequireWeaponSlotEmpty { get { return m_RequireWeaponSlotEmpty; } set { if (OnPropertyChanging("DropWeaponComponentData." + nameof(RequireWeaponSlotEmpty), this, m_RequireWeaponSlotEmpty, value)) m_RequireWeaponSlotEmpty = value; } } // 0x7A (122)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 507619053:
					DeathPickup = (CtrRef<PickupEntityAsset>) p_Value;
					break;

				case 2090288440:
					ActionIdentifier = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 1483095999:
					DropWeaponAfterTime = (float) p_Value;
					break;

				case 3381581553:
					Pickup = (CtrRef<PickupEntityAsset>) p_Value;
					break;

				case 1714084178:
					if (p_Value.GetType() == typeof (List<uint>))
						ExcludedWeaponSlots = ((List<uint>) p_Value).Select(x => (WeaponSlot) Enum.ToObject(typeof(WeaponSlot), x)).ToList();
					else
						ExcludedWeaponSlots = (List<WeaponSlot>) p_Value;
					break;

				case 961265435:
					WeaponDropTime = (float) p_Value;
					break;

				case 423346996:
					ListenToAnimationWeaponDropSignal = (bool) p_Value;
					break;

				case 3589518696:
					AllowDropWeaponOnAction = (bool) p_Value;
					break;

				case 2054797371:
					RequireWeaponSlotEmpty = (bool) p_Value;
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
				case 507619053:
					return DeathPickup;

				case 2090288440:
					return ActionIdentifier;

				case 1483095999:
					return DropWeaponAfterTime;

				case 3381581553:
					return Pickup;

				case 1714084178:
					return ExcludedWeaponSlots;

				case 961265435:
					return WeaponDropTime;

				case 423346996:
					return ListenToAnimationWeaponDropSignal;

				case 3589518696:
					return AllowDropWeaponOnAction;

				case 2054797371:
					return RequireWeaponSlotEmpty;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 507619053:
					return typeof(DropWeaponComponentData).GetProperty(nameof(DeathPickup));

				case 2090288440:
					return typeof(DropWeaponComponentData).GetProperty(nameof(ActionIdentifier));

				case 1483095999:
					return typeof(DropWeaponComponentData).GetProperty(nameof(DropWeaponAfterTime));

				case 3381581553:
					return typeof(DropWeaponComponentData).GetProperty(nameof(Pickup));

				case 1714084178:
					return typeof(DropWeaponComponentData).GetProperty(nameof(ExcludedWeaponSlots));

				case 961265435:
					return typeof(DropWeaponComponentData).GetProperty(nameof(WeaponDropTime));

				case 423346996:
					return typeof(DropWeaponComponentData).GetProperty(nameof(ListenToAnimationWeaponDropSignal));

				case 3589518696:
					return typeof(DropWeaponComponentData).GetProperty(nameof(AllowDropWeaponOnAction));

				case 2054797371:
					return typeof(DropWeaponComponentData).GetProperty(nameof(RequireWeaponSlotEmpty));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
