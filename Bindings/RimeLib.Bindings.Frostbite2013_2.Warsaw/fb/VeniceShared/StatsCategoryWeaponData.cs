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

using fb.GameShared;
using fb.Core;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 64)]
public class StatsCategoryWeaponData
	: fb.VeniceShared.StatsCategoryGuidData
{
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint SoldierWeaponId { get; set; } = 0;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<CriteriaGateList> AccessoryUnlockGates { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<BasicUnlockInfo> UnlocksInfo { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SoldierWeaponId);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AccessoryUnlockGates));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_UnlocksInfo = p_EbxWriter.GetArrayWriter(UnlocksInfo.GetType(), UnlocksInfo.Count);
		p_Writer.Write(s_UnlocksInfo.ArrayIndex);
		foreach (var s_Entry in UnlocksInfo)
		{
			s_Entry.Serialize(s_UnlocksInfo.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

