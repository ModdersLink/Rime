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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 144)]
public class StanceFilterComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public List<int> ValidStances { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float StanceChangeTime { get; set; } = 0.500f;
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public List<ActionSuppressor> ActionsToFilter { get; set; } = new();
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public bool UndoParentStanceFilter { get; set; } = false;
	
	[ContainerField(0x89), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
	public bool FilterSpecificActions { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ValidStances = p_EbxWriter.GetArrayWriter(ValidStances.GetType(), ValidStances.Count);
		p_Writer.Write(s_ValidStances.ArrayIndex);
		foreach (var s_Entry in ValidStances)
		{
			s_ValidStances.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(StanceChangeTime);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ActionsToFilter = p_EbxWriter.GetArrayWriter(ActionsToFilter.GetType(), ActionsToFilter.Count);
		p_Writer.Write(s_ActionsToFilter.ArrayIndex);
		foreach (var s_Entry in ActionsToFilter)
		{
			s_Entry.Serialize(s_ActionsToFilter.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(UndoParentStanceFilter);
		p_Writer.Write(FilterSpecificActions);
		p_Writer.WriteNullBytes(6);
	}
}

