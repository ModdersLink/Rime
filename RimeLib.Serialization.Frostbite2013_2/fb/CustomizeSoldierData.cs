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
using fb.GameShared;

namespace fb.SoldierShared;

[ContainerType(8, 88)]
public class CustomizeSoldierData
	: fb.GameShared.CustomizeCharacterData
{
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<UnlockWeaponAndSlot> Weapons { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public WeaponSlot ActiveSlot { get; set; } = WeaponSlot.WeaponSlot_NotDefined;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<PickupEntityAsset> DeathPickup { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool KeepCurrentActiveSlot { get; set; } = false;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool RemoveAllExistingWeapons { get; set; } = false;
	
	[ContainerField(0x52), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
	public bool DisableDeathPickup { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Weapons = p_EbxWriter.GetArrayWriter(Weapons.GetType(), Weapons.Count);
		p_Writer.Write(s_Weapons.ArrayIndex);
		foreach (var s_Entry in Weapons)
		{
			s_Entry.Serialize(s_Weapons.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) ActiveSlot);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DeathPickup));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(KeepCurrentActiveSlot);
		p_Writer.Write(RemoveAllExistingWeapons);
		p_Writer.Write(DisableDeathPickup);
		p_Writer.WriteNullBytes(5);
	}
}

