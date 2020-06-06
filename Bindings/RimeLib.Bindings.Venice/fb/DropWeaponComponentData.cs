///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class DropWeaponComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<PickupEntityAsset> DeathPickup { get; set; } = new CtrRef<PickupEntityAsset>(); // 0x60 (96)
		
		[ContainerField(100)]
		public EntryInputActionEnum ActionIdentifier { get; set; } = new EntryInputActionEnum(); // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float DropWeaponAfterTime { get; set; } // 0x68 (104)
		
		[ContainerField(108)]
		public CtrRef<PickupEntityAsset> Pickup { get; set; } = new CtrRef<PickupEntityAsset>(); // 0x6C (108)
		
		[ContainerField(112)]
		public List<WeaponSlot> ExcludedWeaponSlots { get; set; } = new List<WeaponSlot>(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float WeaponDropTime { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public bool ListenToAnimationWeaponDropSignal { get; set; } // 0x78 (120)
		
		[ContainerField(121), LayoutImmutable, Blittable]
		public bool AllowDropWeaponOnAction { get; set; } // 0x79 (121)
		
		[ContainerField(122), LayoutImmutable, Blittable]
		public bool RequireWeaponSlotEmpty { get; set; } // 0x7A (122)
		
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
