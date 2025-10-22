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
using fb.Physics;
using fb.Entity;

namespace fb.SoldierShared;

[ContainerType(16, 160)]
public class SoldierHealthComponentData
	: fb.GameShared.CharacterHealthComponentData
{
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float UnderWaterHoldBreathTime { get; set; } = 10.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float UnderWaterBreathRegenerationTime { get; set; } = 5.000f;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public List<DamageEntryData> UnderWaterDamageTable { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float UnderWaterClearSpottingTime { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(UnderWaterHoldBreathTime);
		p_Writer.Write(UnderWaterBreathRegenerationTime);
		(RimeWriter Writer, uint ArrayIndex) s_UnderWaterDamageTable = p_EbxWriter.GetArrayWriter(UnderWaterDamageTable.GetType(), UnderWaterDamageTable.Count);
		p_Writer.Write(s_UnderWaterDamageTable.ArrayIndex);
		foreach (var s_Entry in UnderWaterDamageTable)
		{
			s_Entry.Serialize(s_UnderWaterDamageTable.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(UnderWaterClearSpottingTime);
		p_Writer.WriteNullBytes(12);
	}
}

