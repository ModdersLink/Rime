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

namespace fb.VeniceShared;

[ContainerType(8, 56)]
public class CalendarBattlepackDrop
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string ReleaseDateTime { get; set; } = @"2013/02/20-14:00:00";
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string RequiredLicense { get; set; } = @"PREMIUM";
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int ValidDays { get; set; } = 0;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<BattlepackData> Battlepacks { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int BattlepackNumber { get; set; } = -1;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ReleaseDateTime));
		p_Writer.Write(p_EbxWriter.WriteString(RequiredLicense));
		p_Writer.Write(ValidDays);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Battlepacks = p_EbxWriter.GetArrayWriter(Battlepacks.GetType(), Battlepacks.Count);
		p_Writer.Write(s_Battlepacks.ArrayIndex);
		foreach (var s_Entry in Battlepacks)
		{
			s_Battlepacks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(BattlepackNumber);
		p_Writer.WriteNullBytes(4);
	}
}

