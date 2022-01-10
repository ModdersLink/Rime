///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 176)]
	public class PickupEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112)]
		public PickupPlayerEnum RandomizeAmmoOnDropForPlayer { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public int MinRandomClipAmmoPercent { get; set; }

		[ContainerField(120)]
		public CtrRef<ObjectBlueprint> PhysicsBlueprint { get; set; } = new();

		[ContainerField(124)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public int MaxRandomClipAmmoPercent { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public uint PreferredWeaponSlot { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float TimeToLive { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public int MinRandomSpareAmmoPercent { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float InteractionRadius { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public int MaxRandomSpareAmmoPercent { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public bool UnspawnOnPickup { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable]
		public bool UnspawnOnAmmoPickup { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable]
		public bool ForceWeaponSlotSelection { get; set; }

		[ContainerField(155), LayoutImmutable, Blittable]
		public bool DisplayInMiniMap { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public bool HasAutomaticAmmoPickup { get; set; }

		[ContainerField(157), LayoutImmutable, Blittable]
		public bool UseWeaponMesh { get; set; }

		[ContainerField(158), LayoutImmutable, Blittable]
		public bool AllowPickup { get; set; }

		[ContainerField(159), LayoutImmutable, Blittable]
		public bool ContentIsStatic { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public bool PositionIsStatic { get; set; }

		[ContainerField(161), LayoutImmutable, Blittable]
		public bool IgnoreNullWeaponSlots { get; set; }

		[ContainerField(162), LayoutImmutable, Blittable]
		public bool ReplaceAllContent { get; set; }

		[ContainerField(163), LayoutImmutable, Blittable]
		public bool RemoveWeaponOnDrop { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public bool SendPlayerInEventOnPickup { get; set; }

		public static void Deserialize(PickupEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RandomizeAmmoOnDropForPlayer = (PickupPlayerEnum) p_Reader.ReadInt32();
			p_Instance.MinRandomClipAmmoPercent = p_Reader.ReadInt32();
			p_Instance.PhysicsBlueprint.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MaxRandomClipAmmoPercent = p_Reader.ReadInt32();
			p_Instance.PreferredWeaponSlot = p_Reader.ReadUInt32();
			p_Instance.TimeToLive = p_Reader.ReadSingle();
			p_Instance.MinRandomSpareAmmoPercent = p_Reader.ReadInt32();
			p_Instance.InteractionRadius = p_Reader.ReadSingle();
			p_Instance.MaxRandomSpareAmmoPercent = p_Reader.ReadInt32();
			p_Instance.UnspawnOnPickup = p_Reader.ReadBool();
			p_Instance.UnspawnOnAmmoPickup = p_Reader.ReadBool();
			p_Instance.ForceWeaponSlotSelection = p_Reader.ReadBool();
			p_Instance.DisplayInMiniMap = p_Reader.ReadBool();
			p_Instance.HasAutomaticAmmoPickup = p_Reader.ReadBool();
			p_Instance.UseWeaponMesh = p_Reader.ReadBool();
			p_Instance.AllowPickup = p_Reader.ReadBool();
			p_Instance.ContentIsStatic = p_Reader.ReadBool();
			p_Instance.PositionIsStatic = p_Reader.ReadBool();
			p_Instance.IgnoreNullWeaponSlots = p_Reader.ReadBool();
			p_Instance.ReplaceAllContent = p_Reader.ReadBool();
			p_Instance.RemoveWeaponOnDrop = p_Reader.ReadBool();
			p_Instance.SendPlayerInEventOnPickup = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
