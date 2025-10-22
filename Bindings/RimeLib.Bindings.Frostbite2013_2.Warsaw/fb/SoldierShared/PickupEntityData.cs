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

using fb.Core;
using fb.Render;
using fb.Entity;
using fb.Physics;

namespace fb.SoldierShared;

[ContainerType(16, 240)]
public class PickupEntityData
	: fb.Physics.GamePhysicsEntityData
{
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<ObjectBlueprint> PhysicsBlueprint { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public CtrRef<MeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float TimeToShowWeaponMesh { get; set; } = 10.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public uint PreferredWeaponSlot { get; set; } = 0;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float TimeToLive { get; set; } = 0.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public string IconName { get; set; } = string.Empty;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public int MinRandomSpareAmmoPercent { get; set; } = 0;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public int MaxRandomSpareAmmoPercent { get; set; } = 0;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public int MinRandomClipAmmoPercent { get; set; } = 0;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public int MaxRandomClipAmmoPercent { get; set; } = 0;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public PickupPlayerEnum RandomizeAmmoOnDropForPlayer { get; set; } = PickupPlayerEnum.PickupPlayerEnum_AIOnly;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float InteractionRadius { get; set; } = 2.500f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float DisplayWithinRadius { get; set; } = 25.000f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float TacticalRadius { get; set; } = 200.000f;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public bool UseWeaponMesh { get; set; } = true;
	
	[ContainerField(0xd9), LayoutImmutable, Blittable, JsonProperty(Order = 217)]
	public bool UnspawnOnPickup { get; set; } = false;
	
	[ContainerField(0xda), LayoutImmutable, Blittable, JsonProperty(Order = 218)]
	public bool UnspawnOnAmmoPickup { get; set; } = false;
	
	[ContainerField(0xdb), LayoutImmutable, Blittable, JsonProperty(Order = 219)]
	public bool ContentIsStatic { get; set; } = false;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public bool PositionIsStatic { get; set; } = false;
	
	[ContainerField(0xdd), LayoutImmutable, Blittable, JsonProperty(Order = 221)]
	public bool AllowPickup { get; set; } = true;
	
	[ContainerField(0xde), LayoutImmutable, Blittable, JsonProperty(Order = 222)]
	public bool IgnoreNullWeaponSlots { get; set; } = false;
	
	[ContainerField(0xdf), LayoutImmutable, Blittable, JsonProperty(Order = 223)]
	public bool ForceWeaponSlotSelection { get; set; } = true;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public bool DisplayInMiniMap { get; set; } = true;
	
	[ContainerField(0xe1), LayoutImmutable, Blittable, JsonProperty(Order = 225)]
	public bool HasAutomaticAmmoPickup { get; set; } = true;
	
	[ContainerField(0xe2), LayoutImmutable, Blittable, JsonProperty(Order = 226)]
	public bool ReplaceAllContent { get; set; } = false;
	
	[ContainerField(0xe3), LayoutImmutable, Blittable, JsonProperty(Order = 227)]
	public bool RemoveWeaponOnDrop { get; set; } = false;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public bool UseDisplayWithinRadius { get; set; } = false;
	
	[ContainerField(0xe5), LayoutImmutable, Blittable, JsonProperty(Order = 229)]
	public bool KeepAmmoState { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(PhysicsBlueprint));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TimeToShowWeaponMesh);
		p_Writer.Write(PreferredWeaponSlot);
		p_Writer.Write(TimeToLive);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(IconName));
		p_Writer.Write(MinRandomSpareAmmoPercent);
		p_Writer.Write(MaxRandomSpareAmmoPercent);
		p_Writer.Write(MinRandomClipAmmoPercent);
		p_Writer.Write(MaxRandomClipAmmoPercent);
		p_Writer.Write((int) RandomizeAmmoOnDropForPlayer);
		p_Writer.Write(InteractionRadius);
		p_Writer.Write(DisplayWithinRadius);
		p_Writer.Write(TacticalRadius);
		p_Writer.Write(UseWeaponMesh);
		p_Writer.Write(UnspawnOnPickup);
		p_Writer.Write(UnspawnOnAmmoPickup);
		p_Writer.Write(ContentIsStatic);
		p_Writer.Write(PositionIsStatic);
		p_Writer.Write(AllowPickup);
		p_Writer.Write(IgnoreNullWeaponSlots);
		p_Writer.Write(ForceWeaponSlotSelection);
		p_Writer.Write(DisplayInMiniMap);
		p_Writer.Write(HasAutomaticAmmoPickup);
		p_Writer.Write(ReplaceAllContent);
		p_Writer.Write(RemoveWeaponOnDrop);
		p_Writer.Write(UseDisplayWithinRadius);
		p_Writer.Write(KeepAmmoState);
		p_Writer.WriteNullBytes(10);
	}
}

