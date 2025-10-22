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

namespace fb.VeniceShared;

[ContainerType(8, 200)]
public class UILevelDescriptionComponent
	: fb.GameShared.LevelDescriptionComponent
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string LoadingMusicPath { get; set; } = string.Empty;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string LevelImagePath { get; set; } = string.Empty;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<GameTipAsset> HintAsset { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public UIMinimapData MinimapData { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public UIMapNavigationData MapNavigationData { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public UILevelStatData LevelCompledStatData { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public UILevelStatData LevelScoreStatData { get; set; } = new();
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public int SortIndex { get; set; } = -1;
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public UIGPSPosition GPSPosition { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<UILevelLoadData> LevelLoadData { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public List<string> LevelAwardCodes { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public List<uint> LevelConsumableUnlocksIds { get; set; } = new();
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public bool IsMenuLevel { get; set; } = false;
	
	[ContainerField(0xc1), LayoutImmutable, Blittable, JsonProperty(Order = 193)]
	public bool IsPlaygroundLevel { get; set; } = false;
	
	[ContainerField(0xc2), LayoutImmutable, Blittable, JsonProperty(Order = 194)]
	public bool LoadingMusicAutomaticStop { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(LoadingMusicPath));
		p_Writer.Write(p_EbxWriter.WriteString(LevelImagePath));
		p_Writer.Write(p_EbxWriter.WriteImport(HintAsset));
		p_Writer.WriteNullBytes(4);
		MinimapData.Serialize(p_Writer, p_EbxWriter);
		MapNavigationData.Serialize(p_Writer, p_EbxWriter);
		LevelCompledStatData.Serialize(p_Writer, p_EbxWriter);
		LevelScoreStatData.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SortIndex);
		p_Writer.WriteNullBytes(4);
		GPSPosition.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(LevelLoadData));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LevelAwardCodes = p_EbxWriter.GetArrayWriter(LevelAwardCodes.GetType(), LevelAwardCodes.Count);
		p_Writer.Write(s_LevelAwardCodes.ArrayIndex);
		foreach (var s_Entry in LevelAwardCodes)
		{
			s_LevelAwardCodes.Writer.Write(p_EbxWriter.WriteString(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LevelConsumableUnlocksIds = p_EbxWriter.GetArrayWriter(LevelConsumableUnlocksIds.GetType(), LevelConsumableUnlocksIds.Count);
		p_Writer.Write(s_LevelConsumableUnlocksIds.ArrayIndex);
		foreach (var s_Entry in LevelConsumableUnlocksIds)
		{
			s_LevelConsumableUnlocksIds.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(IsMenuLevel);
		p_Writer.Write(IsPlaygroundLevel);
		p_Writer.Write(LoadingMusicAutomaticStop);
		p_Writer.WriteNullBytes(5);
	}
}

