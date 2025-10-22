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

[ContainerType(8, 112)]
public class LevelDescriptionAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string LevelName { get; set; } = string.Empty;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<LevelDescriptionInclusionCategory> Categories { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public LevelDescription Description { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public List<LevelBundleLoad> Bundles { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public List<LevelStartPoint> StartPoints { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public List<string> SuperBundles { get; set; } = new();
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public GUID LevelGuid { get; set; } = GUID.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(LevelName));
		(RimeWriter Writer, uint ArrayIndex) s_Categories = p_EbxWriter.GetArrayWriter(Categories.GetType(), Categories.Count);
		p_Writer.Write(s_Categories.ArrayIndex);
		foreach (var s_Entry in Categories)
		{
			s_Entry.Serialize(s_Categories.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		Description.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Bundles = p_EbxWriter.GetArrayWriter(Bundles.GetType(), Bundles.Count);
		p_Writer.Write(s_Bundles.ArrayIndex);
		foreach (var s_Entry in Bundles)
		{
			s_Entry.Serialize(s_Bundles.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_StartPoints = p_EbxWriter.GetArrayWriter(StartPoints.GetType(), StartPoints.Count);
		p_Writer.Write(s_StartPoints.ArrayIndex);
		foreach (var s_Entry in StartPoints)
		{
			s_Entry.Serialize(s_StartPoints.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_SuperBundles = p_EbxWriter.GetArrayWriter(SuperBundles.GetType(), SuperBundles.Count);
		p_Writer.Write(s_SuperBundles.ArrayIndex);
		foreach (var s_Entry in SuperBundles)
		{
			s_SuperBundles.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		LevelGuid.Serialize(p_Writer);
	}
}

