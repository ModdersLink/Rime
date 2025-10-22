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

[ContainerType(8, 48)]
public class XdpExportAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float PerLevelProgression { get; set; } = 0.000f;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<string> ExportedAchievements { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<XdpStatCodeData> ExportedStats { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(PerLevelProgression);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ExportedAchievements = p_EbxWriter.GetArrayWriter(ExportedAchievements.GetType(), ExportedAchievements.Count);
		p_Writer.Write(s_ExportedAchievements.ArrayIndex);
		foreach (var s_Entry in ExportedAchievements)
		{
			s_ExportedAchievements.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ExportedStats = p_EbxWriter.GetArrayWriter(ExportedStats.GetType(), ExportedStats.Count);
		p_Writer.Write(s_ExportedStats.ArrayIndex);
		foreach (var s_Entry in ExportedStats)
		{
			s_Entry.Serialize(s_ExportedStats.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

