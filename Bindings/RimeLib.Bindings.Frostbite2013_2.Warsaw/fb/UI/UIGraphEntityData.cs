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

namespace fb.UI;

[ContainerType(8, 56)]
public class UIGraphEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<EventSpec> Events { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<UIGraphAsset> GraphAsset { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public UIGraphPriority GraphPriority { get; set; } = UIGraphPriority.UIGraphPriority_Normal;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public UIState State { get; set; } = UIState.UIState_Playing;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool PopPreviousGraph { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Events = p_EbxWriter.GetArrayWriter(Events.GetType(), Events.Count);
		p_Writer.Write(s_Events.ArrayIndex);
		foreach (var s_Entry in Events)
		{
			s_Entry.Serialize(s_Events.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(GraphAsset));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) GraphPriority);
		p_Writer.Write((int) State);
		p_Writer.Write(PopPreviousGraph);
		p_Writer.WriteNullBytes(7);
	}
}

