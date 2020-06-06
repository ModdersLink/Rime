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
	public class PickupEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112)]
		public PickupPlayerEnum RandomizeAmmoOnDropForPlayer { get; set; } = new PickupPlayerEnum(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public int MinRandomClipAmmoPercent { get; set; } // 0x74 (116)
		
		[ContainerField(120)]
		public CtrRef<ObjectBlueprint> PhysicsBlueprint { get; set; } = new CtrRef<ObjectBlueprint>(); // 0x78 (120)
		
		[ContainerField(124)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new CtrRef<MeshAsset>(); // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public int MaxRandomClipAmmoPercent { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public uint PreferredWeaponSlot { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float TimeToLive { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public int MinRandomSpareAmmoPercent { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float InteractionRadius { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public int MaxRandomSpareAmmoPercent { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public bool UnspawnOnPickup { get; set; } // 0x98 (152)
		
		[ContainerField(153), LayoutImmutable, Blittable]
		public bool UnspawnOnAmmoPickup { get; set; } // 0x99 (153)
		
		[ContainerField(154), LayoutImmutable, Blittable]
		public bool ForceWeaponSlotSelection { get; set; } // 0x9A (154)
		
		[ContainerField(155), LayoutImmutable, Blittable]
		public bool DisplayInMiniMap { get; set; } // 0x9B (155)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public bool HasAutomaticAmmoPickup { get; set; } // 0x9C (156)
		
		[ContainerField(157), LayoutImmutable, Blittable]
		public bool UseWeaponMesh { get; set; } // 0x9D (157)
		
		[ContainerField(158), LayoutImmutable, Blittable]
		public bool AllowPickup { get; set; } // 0x9E (158)
		
		[ContainerField(159), LayoutImmutable, Blittable]
		public bool ContentIsStatic { get; set; } // 0x9F (159)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public bool PositionIsStatic { get; set; } // 0xA0 (160)
		
		[ContainerField(161), LayoutImmutable, Blittable]
		public bool IgnoreNullWeaponSlots { get; set; } // 0xA1 (161)
		
		[ContainerField(162), LayoutImmutable, Blittable]
		public bool ReplaceAllContent { get; set; } // 0xA2 (162)
		
		[ContainerField(163), LayoutImmutable, Blittable]
		public bool RemoveWeaponOnDrop { get; set; } // 0xA3 (163)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public bool SendPlayerInEventOnPickup { get; set; } // 0xA4 (164)
		
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
