///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 176)]
	public class PickupEntityData :
		GamePhysicsEntityData
	{
		[ContainerField(112), JsonProperty(Order = 112)]
		public PickupPlayerEnum RandomizeAmmoOnDropForPlayer { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public int MinRandomClipAmmoPercent { get; set; }

		[ContainerField(120), JsonProperty(Order = 120)]
		public CtrRef<ObjectBlueprint> PhysicsBlueprint { get; set; } = new();

		[ContainerField(124), JsonProperty(Order = 124)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public int MaxRandomClipAmmoPercent { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public uint PreferredWeaponSlot { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float TimeToLive { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public int MinRandomSpareAmmoPercent { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float InteractionRadius { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public int MaxRandomSpareAmmoPercent { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public bool UnspawnOnPickup { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		public bool UnspawnOnAmmoPickup { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		public bool ForceWeaponSlotSelection { get; set; }

		[ContainerField(155), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
		public bool DisplayInMiniMap { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public bool HasAutomaticAmmoPickup { get; set; }

		[ContainerField(157), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
		public bool UseWeaponMesh { get; set; }

		[ContainerField(158), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
		public bool AllowPickup { get; set; }

		[ContainerField(159), LayoutImmutable, Blittable, JsonProperty(Order = 159)]
		public bool ContentIsStatic { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public bool PositionIsStatic { get; set; }

		[ContainerField(161), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
		public bool IgnoreNullWeaponSlots { get; set; }

		[ContainerField(162), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
		public bool ReplaceAllContent { get; set; }

		[ContainerField(163), LayoutImmutable, Blittable, JsonProperty(Order = 163)]
		public bool RemoveWeaponOnDrop { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public bool SendPlayerInEventOnPickup { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) RandomizeAmmoOnDropForPlayer);
			p_Writer.Write(MinRandomClipAmmoPercent);
			p_Writer.Write(p_EbxWriter.WriteImport(PhysicsBlueprint));
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(MaxRandomClipAmmoPercent);
			p_Writer.Write(PreferredWeaponSlot);
			p_Writer.Write(TimeToLive);
			p_Writer.Write(MinRandomSpareAmmoPercent);
			p_Writer.Write(InteractionRadius);
			p_Writer.Write(MaxRandomSpareAmmoPercent);
			p_Writer.Write(UnspawnOnPickup);
			p_Writer.Write(UnspawnOnAmmoPickup);
			p_Writer.Write(ForceWeaponSlotSelection);
			p_Writer.Write(DisplayInMiniMap);
			p_Writer.Write(HasAutomaticAmmoPickup);
			p_Writer.Write(UseWeaponMesh);
			p_Writer.Write(AllowPickup);
			p_Writer.Write(ContentIsStatic);
			p_Writer.Write(PositionIsStatic);
			p_Writer.Write(IgnoreNullWeaponSlots);
			p_Writer.Write(ReplaceAllContent);
			p_Writer.Write(RemoveWeaponOnDrop);
			p_Writer.Write(SendPlayerInEventOnPickup);
			p_Writer.WriteNullBytes(11);
		}
	}
}
