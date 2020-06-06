///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class EntityInteractionComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float PickupRadius { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float MaxAmmoPickupTimer { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float MaxAmmoCrateTimer { get; set; } // 0x68 (104)
		
		[ContainerField(108)]
		public InteractionTypesData InteractWithTypes { get; set; } = new InteractionTypesData(); // 0x6C (108)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float MaxLookAtAngle { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float SoldierInteractRadius { get; set; } // 0x78 (120)
		
		[ContainerField(124)]
		public EntryInputActionEnum SoldierInteractInputAction { get; set; } = new EntryInputActionEnum(); // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public bool AllowInteractionWithSoldiers { get; set; } // 0x80 (128)
		
		[ContainerField(129), LayoutImmutable, Blittable]
		public bool OnlyAllowInteractionWithManDownSoldiers { get; set; } // 0x81 (129)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1500838121:
					PickupRadius = (float) p_Value;
					break;

				case 3934834668:
					MaxAmmoPickupTimer = (float) p_Value;
					break;

				case 187941017:
					MaxAmmoCrateTimer = (float) p_Value;
					break;

				case 3812367710:
					InteractWithTypes = (InteractionTypesData) p_Value;
					break;

				case 210376098:
					MaxLookAtAngle = (float) p_Value;
					break;

				case 713239749:
					SoldierInteractRadius = (float) p_Value;
					break;

				case 2419536693:
					SoldierInteractInputAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 2620371741:
					AllowInteractionWithSoldiers = (bool) p_Value;
					break;

				case 3800065913:
					OnlyAllowInteractionWithManDownSoldiers = (bool) p_Value;
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
				case 1500838121:
					return PickupRadius;

				case 3934834668:
					return MaxAmmoPickupTimer;

				case 187941017:
					return MaxAmmoCrateTimer;

				case 3812367710:
					return InteractWithTypes;

				case 210376098:
					return MaxLookAtAngle;

				case 713239749:
					return SoldierInteractRadius;

				case 2419536693:
					return SoldierInteractInputAction;

				case 2620371741:
					return AllowInteractionWithSoldiers;

				case 3800065913:
					return OnlyAllowInteractionWithManDownSoldiers;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1500838121:
					return typeof(EntityInteractionComponentData).GetProperty(nameof(PickupRadius));

				case 3934834668:
					return typeof(EntityInteractionComponentData).GetProperty(nameof(MaxAmmoPickupTimer));

				case 187941017:
					return typeof(EntityInteractionComponentData).GetProperty(nameof(MaxAmmoCrateTimer));

				case 3812367710:
					return typeof(EntityInteractionComponentData).GetProperty(nameof(InteractWithTypes));

				case 210376098:
					return typeof(EntityInteractionComponentData).GetProperty(nameof(MaxLookAtAngle));

				case 713239749:
					return typeof(EntityInteractionComponentData).GetProperty(nameof(SoldierInteractRadius));

				case 2419536693:
					return typeof(EntityInteractionComponentData).GetProperty(nameof(SoldierInteractInputAction));

				case 2620371741:
					return typeof(EntityInteractionComponentData).GetProperty(nameof(AllowInteractionWithSoldiers));

				case 3800065913:
					return typeof(EntityInteractionComponentData).GetProperty(nameof(OnlyAllowInteractionWithManDownSoldiers));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
