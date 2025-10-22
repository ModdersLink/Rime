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

namespace fb.GameShared;

[ContainerType(8, 88)]
public class PersistenceData
	: fb.GameShared.AbstractPersistenceData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string PersistenceName { get; set; } = string.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string ClubPersistenceName { get; set; } = string.Empty;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<PersistentValueTemplateData> Values { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<PersistenceStatGroup> ServerDefaultGroup { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<PersistenceStatGroup> ClientDefaultGroup { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<PersistenceRetentionPolicy> RetentionPolicy { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public List<PersistenceConsumableMapping> ConsumableMappings { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool DeltaGameReports { get; set; } = true;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool HistoryDaily { get; set; } = false;
	
	[ContainerField(0x52), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
	public bool HistoryWeekly { get; set; } = false;
	
	[ContainerField(0x53), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
	public bool HistoryMonthly { get; set; } = false;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool OutputProperties { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(PersistenceName));
		p_Writer.Write(p_EbxWriter.WriteString(ClubPersistenceName));
		(RimeWriter Writer, uint ArrayIndex) s_Values = p_EbxWriter.GetArrayWriter(Values.GetType(), Values.Count);
		p_Writer.Write(s_Values.ArrayIndex);
		foreach (var s_Entry in Values)
		{
			s_Entry.Serialize(s_Values.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ServerDefaultGroup));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ClientDefaultGroup));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(RetentionPolicy));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ConsumableMappings = p_EbxWriter.GetArrayWriter(ConsumableMappings.GetType(), ConsumableMappings.Count);
		p_Writer.Write(s_ConsumableMappings.ArrayIndex);
		foreach (var s_Entry in ConsumableMappings)
		{
			s_Entry.Serialize(s_ConsumableMappings.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DeltaGameReports);
		p_Writer.Write(HistoryDaily);
		p_Writer.Write(HistoryWeekly);
		p_Writer.Write(HistoryMonthly);
		p_Writer.Write(OutputProperties);
		p_Writer.WriteNullBytes(3);
	}
}

