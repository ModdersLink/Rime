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
using fb.SoldierShared;
using fb.GameShared;
using fb.Entity;

namespace fb.Venice;

[ContainerType(16, 160)]
public class DropWeaponComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<PickupEntityAsset> DeathPickup { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float DropWeaponAfterTime { get; set; } = 0.100f;
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public CtrRef<PickupEntityAsset> Pickup { get; set; } = new();
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public int ActionIdentifier { get; set; } = -1341426433;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float WeaponDropTime { get; set; } = 0.500f;
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public List<WeaponSlot> ExcludedWeaponSlots { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public bool ListenToAnimationWeaponDropSignal { get; set; } = false;
	
	[ContainerField(0x99), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
	public bool RequireWeaponSlotEmpty { get; set; } = false;
	
	[ContainerField(0x9a), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
	public bool AllowDropWeaponOnAction { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(DeathPickup));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DropWeaponAfterTime);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Pickup));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ActionIdentifier);
		p_Writer.Write(WeaponDropTime);
		(RimeWriter Writer, uint ArrayIndex) s_ExcludedWeaponSlots = p_EbxWriter.GetArrayWriter(ExcludedWeaponSlots.GetType(), ExcludedWeaponSlots.Count);
		p_Writer.Write(s_ExcludedWeaponSlots.ArrayIndex);
		foreach (var s_Entry in ExcludedWeaponSlots)
		{
			s_ExcludedWeaponSlots.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ListenToAnimationWeaponDropSignal);
		p_Writer.Write(RequireWeaponSlotEmpty);
		p_Writer.Write(AllowDropWeaponOnAction);
		p_Writer.WriteNullBytes(5);
	}
}

