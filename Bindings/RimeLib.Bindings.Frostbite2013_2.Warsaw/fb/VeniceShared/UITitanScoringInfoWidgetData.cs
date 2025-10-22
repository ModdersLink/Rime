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
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 144)]
public class UITitanScoringInfoWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public List<TitanScoringInfoState> States { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public string Team1CarrierHealthPercentProperty { get; set; } = @"Team1CarrierHealthPercent";
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public string Team1CarrierStateProperty { get; set; } = @"Team1CarrierState";
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public string Team2CarrierHealthPercentProperty { get; set; } = @"Team2CarrierHealthPercent";
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public string Team2CarrierStateProperty { get; set; } = @"Team2CarrierState";
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_States = p_EbxWriter.GetArrayWriter(States.GetType(), States.Count);
		p_Writer.Write(s_States.ArrayIndex);
		foreach (var s_Entry in States)
		{
			s_Entry.Serialize(s_States.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(Team1CarrierHealthPercentProperty));
		p_Writer.Write(p_EbxWriter.WriteString(Team1CarrierStateProperty));
		p_Writer.Write(p_EbxWriter.WriteString(Team2CarrierHealthPercentProperty));
		p_Writer.Write(p_EbxWriter.WriteString(Team2CarrierStateProperty));
	}
}

