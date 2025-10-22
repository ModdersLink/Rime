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

[ContainerType(8, 72)]
public class UILevelLoadData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public GUID LoadingMovieGuid { get; set; } = GUID.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string ScreenDataPath { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint MaxLoadingImagesGen4 { get; set; } = 2;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string WidgetDataPath { get; set; } = string.Empty;
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<UILevelLoadGameModeData> GameModeData { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool HasLoadingMovie { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		LoadingMovieGuid.Serialize(p_Writer);
		p_Writer.Write(p_EbxWriter.WriteString(ScreenDataPath));
		p_Writer.Write(MaxLoadingImagesGen4);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(WidgetDataPath));
		(RimeWriter Writer, uint ArrayIndex) s_GameModeData = p_EbxWriter.GetArrayWriter(GameModeData.GetType(), GameModeData.Count);
		p_Writer.Write(s_GameModeData.ArrayIndex);
		foreach (var s_Entry in GameModeData)
		{
			s_Entry.Serialize(s_GameModeData.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(HasLoadingMovie);
		p_Writer.WriteNullBytes(7);
	}
}

