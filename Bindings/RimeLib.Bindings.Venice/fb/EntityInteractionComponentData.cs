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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(144), ContainerClass]
	public class EntityInteractionComponentData : 
		ComponentData
	{
		protected float m_PickupRadius = new float();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1500838121)]
		public float PickupRadius { get { return m_PickupRadius; } set { if (OnPropertyChanging("EntityInteractionComponentData." + nameof(PickupRadius), this, m_PickupRadius, value)) m_PickupRadius = value; } } // 0x60 (96)
		
		protected float m_MaxAmmoPickupTimer = new float();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3934834668)]
		public float MaxAmmoPickupTimer { get { return m_MaxAmmoPickupTimer; } set { if (OnPropertyChanging("EntityInteractionComponentData." + nameof(MaxAmmoPickupTimer), this, m_MaxAmmoPickupTimer, value)) m_MaxAmmoPickupTimer = value; } } // 0x64 (100)
		
		protected float m_MaxAmmoCrateTimer = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(187941017)]
		public float MaxAmmoCrateTimer { get { return m_MaxAmmoCrateTimer; } set { if (OnPropertyChanging("EntityInteractionComponentData." + nameof(MaxAmmoCrateTimer), this, m_MaxAmmoCrateTimer, value)) m_MaxAmmoCrateTimer = value; } } // 0x68 (104)
		
		protected InteractionTypesData m_InteractWithTypes = new InteractionTypesData();
		[ContainerField(108), MemberInfoFlag(41), ContainerFieldNameHash(3812367710)]
		public InteractionTypesData InteractWithTypes { get { return m_InteractWithTypes; } set { if (OnPropertyChanging("EntityInteractionComponentData." + nameof(InteractWithTypes), this, m_InteractWithTypes, value)) m_InteractWithTypes = value; } } // 0x6C (108)
		
		protected float m_MaxLookAtAngle = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(210376098)]
		public float MaxLookAtAngle { get { return m_MaxLookAtAngle; } set { if (OnPropertyChanging("EntityInteractionComponentData." + nameof(MaxLookAtAngle), this, m_MaxLookAtAngle, value)) m_MaxLookAtAngle = value; } } // 0x74 (116)
		
		protected float m_SoldierInteractRadius = new float();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(713239749)]
		public float SoldierInteractRadius { get { return m_SoldierInteractRadius; } set { if (OnPropertyChanging("EntityInteractionComponentData." + nameof(SoldierInteractRadius), this, m_SoldierInteractRadius, value)) m_SoldierInteractRadius = value; } } // 0x78 (120)
		
		protected EntryInputActionEnum m_SoldierInteractInputAction = new EntryInputActionEnum();
		[ContainerField(124), MemberInfoFlag(137), ContainerFieldNameHash(2419536693)]
		public EntryInputActionEnum SoldierInteractInputAction { get { return m_SoldierInteractInputAction; } set { if (OnPropertyChanging("EntityInteractionComponentData." + nameof(SoldierInteractInputAction), this, m_SoldierInteractInputAction, value)) m_SoldierInteractInputAction = value; } } // 0x7C (124)
		
		protected bool m_AllowInteractionWithSoldiers = new bool();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2620371741)]
		public bool AllowInteractionWithSoldiers { get { return m_AllowInteractionWithSoldiers; } set { if (OnPropertyChanging("EntityInteractionComponentData." + nameof(AllowInteractionWithSoldiers), this, m_AllowInteractionWithSoldiers, value)) m_AllowInteractionWithSoldiers = value; } } // 0x80 (128)
		
		protected bool m_OnlyAllowInteractionWithManDownSoldiers = new bool();
		[ContainerField(129), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3800065913)]
		public bool OnlyAllowInteractionWithManDownSoldiers { get { return m_OnlyAllowInteractionWithManDownSoldiers; } set { if (OnPropertyChanging("EntityInteractionComponentData." + nameof(OnlyAllowInteractionWithManDownSoldiers), this, m_OnlyAllowInteractionWithManDownSoldiers, value)) m_OnlyAllowInteractionWithManDownSoldiers = value; } } // 0x81 (129)
		
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
