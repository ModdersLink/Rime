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

[ContainerType(16, 256)]
public class DynamicWeaponPickupEntityData
	: fb.SoldierShared.PickupEntityData
{
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public List<DynamicWeaponPickupSlotData> WeaponSlots { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_WeaponSlots = p_EbxWriter.GetArrayWriter(WeaponSlots.GetType(), WeaponSlots.Count);
		p_Writer.Write(s_WeaponSlots.ArrayIndex);
		foreach (var s_Entry in WeaponSlots)
		{
			s_Entry.Serialize(s_WeaponSlots.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(12);
	}
}

