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

[ContainerType(8, 64)]
public class RSPSettings
	: fb.Core.SystemSettings
{
	public RSPSettings()
	{
		//SystemSettings
		Name = @"RSP";
	}
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<SettingConfig> PresetSettings { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<SettingsRangeConfig> SettingsRanges { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<PresetTypeConfig> PresetTypes { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<MapRotationConfig> MapRotations { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_PresetSettings = p_EbxWriter.GetArrayWriter(PresetSettings.GetType(), PresetSettings.Count);
		p_Writer.Write(s_PresetSettings.ArrayIndex);
		foreach (var s_Entry in PresetSettings)
		{
			s_Entry.Serialize(s_PresetSettings.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_SettingsRanges = p_EbxWriter.GetArrayWriter(SettingsRanges.GetType(), SettingsRanges.Count);
		p_Writer.Write(s_SettingsRanges.ArrayIndex);
		foreach (var s_Entry in SettingsRanges)
		{
			s_Entry.Serialize(s_SettingsRanges.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PresetTypes = p_EbxWriter.GetArrayWriter(PresetTypes.GetType(), PresetTypes.Count);
		p_Writer.Write(s_PresetTypes.ArrayIndex);
		foreach (var s_Entry in PresetTypes)
		{
			s_Entry.Serialize(s_PresetTypes.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_MapRotations = p_EbxWriter.GetArrayWriter(MapRotations.GetType(), MapRotations.Count);
		p_Writer.Write(s_MapRotations.ArrayIndex);
		foreach (var s_Entry in MapRotations)
		{
			s_Entry.Serialize(s_MapRotations.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

