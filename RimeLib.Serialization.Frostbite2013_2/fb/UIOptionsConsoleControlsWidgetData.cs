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

[ContainerType(8, 264)]
public class UIOptionsConsoleControlsWidgetData
	: fb.VeniceShared.UIOptionsListWidgetData
{
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public UIOptionsConsoleControlsTextFieldMappings SoldierMappings { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public UIOptionsConsoleControlsTextFieldMappings VehicleMappings { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public UIOptionsConsoleControlsTextFieldMappings HeliMappings { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public UIOptionsConsoleControlsTextFieldMappings JetMappings { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public List<UIOptionsConsoleControlsShown> Modes { get; set; } = new();
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public UIOptionsConsoleControlsShown DefaultMode { get; set; } = UIOptionsConsoleControlsShown.UIOptionsConsoleControlsShown_Soldier;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public string DefaultTitle { get; set; } = @"ID_M_OPTIONS_SOLDIER_BUTTONS";
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		SoldierMappings.Serialize(p_Writer, p_EbxWriter);
		VehicleMappings.Serialize(p_Writer, p_EbxWriter);
		HeliMappings.Serialize(p_Writer, p_EbxWriter);
		JetMappings.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Modes = p_EbxWriter.GetArrayWriter(Modes.GetType(), Modes.Count);
		p_Writer.Write(s_Modes.ArrayIndex);
		foreach (var s_Entry in Modes)
		{
			s_Modes.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) DefaultMode);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(DefaultTitle));
	}
}

