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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 176)]
	public class PickupEntityData : 
		GamePhysicsEntityData
	{
		protected PickupPlayerEnum m_RandomizeAmmoOnDropForPlayer = new PickupPlayerEnum();
		[ContainerField(Name: "RandomizeAmmoOnDropForPlayer", Offset: 112, NameHash: 2116606342, Flags: 137)]
		public PickupPlayerEnum RandomizeAmmoOnDropForPlayer { get { return m_RandomizeAmmoOnDropForPlayer; } set { if (OnPropertyChanging("PickupEntityData." + nameof(RandomizeAmmoOnDropForPlayer), this, m_RandomizeAmmoOnDropForPlayer, value)) m_RandomizeAmmoOnDropForPlayer = value; } } // 0x70 (112)
		
		protected int m_MinRandomClipAmmoPercent = new int();
		[ContainerField(Name: "MinRandomClipAmmoPercent", Offset: 116, NameHash: 1950314775, Flags: 49405), LayoutImmutable, Blittable]
		public int MinRandomClipAmmoPercent { get { return m_MinRandomClipAmmoPercent; } set { if (OnPropertyChanging("PickupEntityData." + nameof(MinRandomClipAmmoPercent), this, m_MinRandomClipAmmoPercent, value)) m_MinRandomClipAmmoPercent = value; } } // 0x74 (116)
		
		protected CtrRef<ObjectBlueprint> m_PhysicsBlueprint = new CtrRef<ObjectBlueprint>();
		[ContainerField(Name: "PhysicsBlueprint", Offset: 120, NameHash: 1212084673, Flags: 53)]
		public CtrRef<ObjectBlueprint> PhysicsBlueprint { get { return m_PhysicsBlueprint; } set { if (OnPropertyChanging("PickupEntityData." + nameof(PhysicsBlueprint), this, m_PhysicsBlueprint, value)) m_PhysicsBlueprint = value; } } // 0x78 (120)
		
		protected CtrRef<MeshAsset> m_Mesh = new CtrRef<MeshAsset>();
		[ContainerField(Name: "Mesh", Offset: 124, NameHash: 2088783990, Flags: 53)]
		public CtrRef<MeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("PickupEntityData." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0x7C (124)
		
		protected int m_MaxRandomClipAmmoPercent = new int();
		[ContainerField(Name: "MaxRandomClipAmmoPercent", Offset: 128, NameHash: 1649409609, Flags: 49405), LayoutImmutable, Blittable]
		public int MaxRandomClipAmmoPercent { get { return m_MaxRandomClipAmmoPercent; } set { if (OnPropertyChanging("PickupEntityData." + nameof(MaxRandomClipAmmoPercent), this, m_MaxRandomClipAmmoPercent, value)) m_MaxRandomClipAmmoPercent = value; } } // 0x80 (128)
		
		protected uint m_PreferredWeaponSlot = new uint();
		[ContainerField(Name: "PreferredWeaponSlot", Offset: 132, NameHash: 3875004262, Flags: 49421), LayoutImmutable, Blittable]
		public uint PreferredWeaponSlot { get { return m_PreferredWeaponSlot; } set { if (OnPropertyChanging("PickupEntityData." + nameof(PreferredWeaponSlot), this, m_PreferredWeaponSlot, value)) m_PreferredWeaponSlot = value; } } // 0x84 (132)
		
		protected float m_TimeToLive = new float();
		[ContainerField(Name: "TimeToLive", Offset: 136, NameHash: 1571456733, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeToLive { get { return m_TimeToLive; } set { if (OnPropertyChanging("PickupEntityData." + nameof(TimeToLive), this, m_TimeToLive, value)) m_TimeToLive = value; } } // 0x88 (136)
		
		protected int m_MinRandomSpareAmmoPercent = new int();
		[ContainerField(Name: "MinRandomSpareAmmoPercent", Offset: 140, NameHash: 3822639764, Flags: 49405), LayoutImmutable, Blittable]
		public int MinRandomSpareAmmoPercent { get { return m_MinRandomSpareAmmoPercent; } set { if (OnPropertyChanging("PickupEntityData." + nameof(MinRandomSpareAmmoPercent), this, m_MinRandomSpareAmmoPercent, value)) m_MinRandomSpareAmmoPercent = value; } } // 0x8C (140)
		
		protected float m_InteractionRadius = new float();
		[ContainerField(Name: "InteractionRadius", Offset: 144, NameHash: 796824583, Flags: 49469), LayoutImmutable, Blittable]
		public float InteractionRadius { get { return m_InteractionRadius; } set { if (OnPropertyChanging("PickupEntityData." + nameof(InteractionRadius), this, m_InteractionRadius, value)) m_InteractionRadius = value; } } // 0x90 (144)
		
		protected int m_MaxRandomSpareAmmoPercent = new int();
		[ContainerField(Name: "MaxRandomSpareAmmoPercent", Offset: 148, NameHash: 1050404106, Flags: 49405), LayoutImmutable, Blittable]
		public int MaxRandomSpareAmmoPercent { get { return m_MaxRandomSpareAmmoPercent; } set { if (OnPropertyChanging("PickupEntityData." + nameof(MaxRandomSpareAmmoPercent), this, m_MaxRandomSpareAmmoPercent, value)) m_MaxRandomSpareAmmoPercent = value; } } // 0x94 (148)
		
		protected bool m_UnspawnOnPickup = new bool();
		[ContainerField(Name: "UnspawnOnPickup", Offset: 152, NameHash: 2926663472, Flags: 49325), LayoutImmutable, Blittable]
		public bool UnspawnOnPickup { get { return m_UnspawnOnPickup; } set { if (OnPropertyChanging("PickupEntityData." + nameof(UnspawnOnPickup), this, m_UnspawnOnPickup, value)) m_UnspawnOnPickup = value; } } // 0x98 (152)
		
		protected bool m_UnspawnOnAmmoPickup = new bool();
		[ContainerField(Name: "UnspawnOnAmmoPickup", Offset: 153, NameHash: 2536341726, Flags: 49325), LayoutImmutable, Blittable]
		public bool UnspawnOnAmmoPickup { get { return m_UnspawnOnAmmoPickup; } set { if (OnPropertyChanging("PickupEntityData." + nameof(UnspawnOnAmmoPickup), this, m_UnspawnOnAmmoPickup, value)) m_UnspawnOnAmmoPickup = value; } } // 0x99 (153)
		
		protected bool m_ForceWeaponSlotSelection = new bool();
		[ContainerField(Name: "ForceWeaponSlotSelection", Offset: 154, NameHash: 361861630, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForceWeaponSlotSelection { get { return m_ForceWeaponSlotSelection; } set { if (OnPropertyChanging("PickupEntityData." + nameof(ForceWeaponSlotSelection), this, m_ForceWeaponSlotSelection, value)) m_ForceWeaponSlotSelection = value; } } // 0x9A (154)
		
		protected bool m_DisplayInMiniMap = new bool();
		[ContainerField(Name: "DisplayInMiniMap", Offset: 155, NameHash: 377772007, Flags: 49325), LayoutImmutable, Blittable]
		public bool DisplayInMiniMap { get { return m_DisplayInMiniMap; } set { if (OnPropertyChanging("PickupEntityData." + nameof(DisplayInMiniMap), this, m_DisplayInMiniMap, value)) m_DisplayInMiniMap = value; } } // 0x9B (155)
		
		protected bool m_HasAutomaticAmmoPickup = new bool();
		[ContainerField(Name: "HasAutomaticAmmoPickup", Offset: 156, NameHash: 3691873464, Flags: 49325), LayoutImmutable, Blittable]
		public bool HasAutomaticAmmoPickup { get { return m_HasAutomaticAmmoPickup; } set { if (OnPropertyChanging("PickupEntityData." + nameof(HasAutomaticAmmoPickup), this, m_HasAutomaticAmmoPickup, value)) m_HasAutomaticAmmoPickup = value; } } // 0x9C (156)
		
		protected bool m_UseWeaponMesh = new bool();
		[ContainerField(Name: "UseWeaponMesh", Offset: 157, NameHash: 694750135, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseWeaponMesh { get { return m_UseWeaponMesh; } set { if (OnPropertyChanging("PickupEntityData." + nameof(UseWeaponMesh), this, m_UseWeaponMesh, value)) m_UseWeaponMesh = value; } } // 0x9D (157)
		
		protected bool m_AllowPickup = new bool();
		[ContainerField(Name: "AllowPickup", Offset: 158, NameHash: 2939061032, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowPickup { get { return m_AllowPickup; } set { if (OnPropertyChanging("PickupEntityData." + nameof(AllowPickup), this, m_AllowPickup, value)) m_AllowPickup = value; } } // 0x9E (158)
		
		protected bool m_ContentIsStatic = new bool();
		[ContainerField(Name: "ContentIsStatic", Offset: 159, NameHash: 2164780814, Flags: 49325), LayoutImmutable, Blittable]
		public bool ContentIsStatic { get { return m_ContentIsStatic; } set { if (OnPropertyChanging("PickupEntityData." + nameof(ContentIsStatic), this, m_ContentIsStatic, value)) m_ContentIsStatic = value; } } // 0x9F (159)
		
		protected bool m_PositionIsStatic = new bool();
		[ContainerField(Name: "PositionIsStatic", Offset: 160, NameHash: 843666622, Flags: 49325), LayoutImmutable, Blittable]
		public bool PositionIsStatic { get { return m_PositionIsStatic; } set { if (OnPropertyChanging("PickupEntityData." + nameof(PositionIsStatic), this, m_PositionIsStatic, value)) m_PositionIsStatic = value; } } // 0xA0 (160)
		
		protected bool m_IgnoreNullWeaponSlots = new bool();
		[ContainerField(Name: "IgnoreNullWeaponSlots", Offset: 161, NameHash: 1468615603, Flags: 49325), LayoutImmutable, Blittable]
		public bool IgnoreNullWeaponSlots { get { return m_IgnoreNullWeaponSlots; } set { if (OnPropertyChanging("PickupEntityData." + nameof(IgnoreNullWeaponSlots), this, m_IgnoreNullWeaponSlots, value)) m_IgnoreNullWeaponSlots = value; } } // 0xA1 (161)
		
		protected bool m_ReplaceAllContent = new bool();
		[ContainerField(Name: "ReplaceAllContent", Offset: 162, NameHash: 1395308577, Flags: 49325), LayoutImmutable, Blittable]
		public bool ReplaceAllContent { get { return m_ReplaceAllContent; } set { if (OnPropertyChanging("PickupEntityData." + nameof(ReplaceAllContent), this, m_ReplaceAllContent, value)) m_ReplaceAllContent = value; } } // 0xA2 (162)
		
		protected bool m_RemoveWeaponOnDrop = new bool();
		[ContainerField(Name: "RemoveWeaponOnDrop", Offset: 163, NameHash: 1737670089, Flags: 49325), LayoutImmutable, Blittable]
		public bool RemoveWeaponOnDrop { get { return m_RemoveWeaponOnDrop; } set { if (OnPropertyChanging("PickupEntityData." + nameof(RemoveWeaponOnDrop), this, m_RemoveWeaponOnDrop, value)) m_RemoveWeaponOnDrop = value; } } // 0xA3 (163)
		
		protected bool m_SendPlayerInEventOnPickup = new bool();
		[ContainerField(Name: "SendPlayerInEventOnPickup", Offset: 164, NameHash: 2803273908, Flags: 49325), LayoutImmutable, Blittable]
		public bool SendPlayerInEventOnPickup { get { return m_SendPlayerInEventOnPickup; } set { if (OnPropertyChanging("PickupEntityData." + nameof(SendPlayerInEventOnPickup), this, m_SendPlayerInEventOnPickup, value)) m_SendPlayerInEventOnPickup = value; } } // 0xA4 (164)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2116606342:
					RandomizeAmmoOnDropForPlayer = (PickupPlayerEnum) Enum.ToObject(typeof(PickupPlayerEnum), p_Value);
					break;

				case 1950314775:
					MinRandomClipAmmoPercent = (int) p_Value;
					break;

				case 1212084673:
					PhysicsBlueprint = (CtrRef<ObjectBlueprint>) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 1649409609:
					MaxRandomClipAmmoPercent = (int) p_Value;
					break;

				case 3875004262:
					PreferredWeaponSlot = (uint) p_Value;
					break;

				case 1571456733:
					TimeToLive = (float) p_Value;
					break;

				case 3822639764:
					MinRandomSpareAmmoPercent = (int) p_Value;
					break;

				case 796824583:
					InteractionRadius = (float) p_Value;
					break;

				case 1050404106:
					MaxRandomSpareAmmoPercent = (int) p_Value;
					break;

				case 2926663472:
					UnspawnOnPickup = (bool) p_Value;
					break;

				case 2536341726:
					UnspawnOnAmmoPickup = (bool) p_Value;
					break;

				case 361861630:
					ForceWeaponSlotSelection = (bool) p_Value;
					break;

				case 377772007:
					DisplayInMiniMap = (bool) p_Value;
					break;

				case 3691873464:
					HasAutomaticAmmoPickup = (bool) p_Value;
					break;

				case 694750135:
					UseWeaponMesh = (bool) p_Value;
					break;

				case 2939061032:
					AllowPickup = (bool) p_Value;
					break;

				case 2164780814:
					ContentIsStatic = (bool) p_Value;
					break;

				case 843666622:
					PositionIsStatic = (bool) p_Value;
					break;

				case 1468615603:
					IgnoreNullWeaponSlots = (bool) p_Value;
					break;

				case 1395308577:
					ReplaceAllContent = (bool) p_Value;
					break;

				case 1737670089:
					RemoveWeaponOnDrop = (bool) p_Value;
					break;

				case 2803273908:
					SendPlayerInEventOnPickup = (bool) p_Value;
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
				case 2116606342:
					return RandomizeAmmoOnDropForPlayer;

				case 1950314775:
					return MinRandomClipAmmoPercent;

				case 1212084673:
					return PhysicsBlueprint;

				case 2088783990:
					return Mesh;

				case 1649409609:
					return MaxRandomClipAmmoPercent;

				case 3875004262:
					return PreferredWeaponSlot;

				case 1571456733:
					return TimeToLive;

				case 3822639764:
					return MinRandomSpareAmmoPercent;

				case 796824583:
					return InteractionRadius;

				case 1050404106:
					return MaxRandomSpareAmmoPercent;

				case 2926663472:
					return UnspawnOnPickup;

				case 2536341726:
					return UnspawnOnAmmoPickup;

				case 361861630:
					return ForceWeaponSlotSelection;

				case 377772007:
					return DisplayInMiniMap;

				case 3691873464:
					return HasAutomaticAmmoPickup;

				case 694750135:
					return UseWeaponMesh;

				case 2939061032:
					return AllowPickup;

				case 2164780814:
					return ContentIsStatic;

				case 843666622:
					return PositionIsStatic;

				case 1468615603:
					return IgnoreNullWeaponSlots;

				case 1395308577:
					return ReplaceAllContent;

				case 1737670089:
					return RemoveWeaponOnDrop;

				case 2803273908:
					return SendPlayerInEventOnPickup;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2116606342:
					return typeof(PickupEntityData).GetProperty(nameof(RandomizeAmmoOnDropForPlayer));

				case 1950314775:
					return typeof(PickupEntityData).GetProperty(nameof(MinRandomClipAmmoPercent));

				case 1212084673:
					return typeof(PickupEntityData).GetProperty(nameof(PhysicsBlueprint));

				case 2088783990:
					return typeof(PickupEntityData).GetProperty(nameof(Mesh));

				case 1649409609:
					return typeof(PickupEntityData).GetProperty(nameof(MaxRandomClipAmmoPercent));

				case 3875004262:
					return typeof(PickupEntityData).GetProperty(nameof(PreferredWeaponSlot));

				case 1571456733:
					return typeof(PickupEntityData).GetProperty(nameof(TimeToLive));

				case 3822639764:
					return typeof(PickupEntityData).GetProperty(nameof(MinRandomSpareAmmoPercent));

				case 796824583:
					return typeof(PickupEntityData).GetProperty(nameof(InteractionRadius));

				case 1050404106:
					return typeof(PickupEntityData).GetProperty(nameof(MaxRandomSpareAmmoPercent));

				case 2926663472:
					return typeof(PickupEntityData).GetProperty(nameof(UnspawnOnPickup));

				case 2536341726:
					return typeof(PickupEntityData).GetProperty(nameof(UnspawnOnAmmoPickup));

				case 361861630:
					return typeof(PickupEntityData).GetProperty(nameof(ForceWeaponSlotSelection));

				case 377772007:
					return typeof(PickupEntityData).GetProperty(nameof(DisplayInMiniMap));

				case 3691873464:
					return typeof(PickupEntityData).GetProperty(nameof(HasAutomaticAmmoPickup));

				case 694750135:
					return typeof(PickupEntityData).GetProperty(nameof(UseWeaponMesh));

				case 2939061032:
					return typeof(PickupEntityData).GetProperty(nameof(AllowPickup));

				case 2164780814:
					return typeof(PickupEntityData).GetProperty(nameof(ContentIsStatic));

				case 843666622:
					return typeof(PickupEntityData).GetProperty(nameof(PositionIsStatic));

				case 1468615603:
					return typeof(PickupEntityData).GetProperty(nameof(IgnoreNullWeaponSlots));

				case 1395308577:
					return typeof(PickupEntityData).GetProperty(nameof(ReplaceAllContent));

				case 1737670089:
					return typeof(PickupEntityData).GetProperty(nameof(RemoveWeaponOnDrop));

				case 2803273908:
					return typeof(PickupEntityData).GetProperty(nameof(SendPlayerInEventOnPickup));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
