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

[ContainerType(8, 80)]
public class Minimap2DTextureAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<Minimap2DTile> Tiles { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public GUID ImageDataURLChunk { get; set; } = GUID.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint ImageDataURLChunkSize { get; set; } = 0;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public int RootTileIndex { get; set; } = -1;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint OutputSize { get; set; } = 0;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public uint TextureTileSize { get; set; } = 0;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public uint LowestTileResolution { get; set; } = 0;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public uint SkipMips { get; set; } = 0;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public uint LowDetailSkipMips { get; set; } = 0;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public bool UseMipMappedStaticTile { get; set; } = false;
	
	[ContainerField(0x4d), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
	public bool HasDetailVolumes { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Tiles = p_EbxWriter.GetArrayWriter(Tiles.GetType(), Tiles.Count);
		p_Writer.Write(s_Tiles.ArrayIndex);
		foreach (var s_Entry in Tiles)
		{
			s_Entry.Serialize(s_Tiles.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		ImageDataURLChunk.Serialize(p_Writer);
		p_Writer.Write(ImageDataURLChunkSize);
		p_Writer.Write(RootTileIndex);
		p_Writer.Write(OutputSize);
		p_Writer.Write(TextureTileSize);
		p_Writer.Write(LowestTileResolution);
		p_Writer.Write(SkipMips);
		p_Writer.Write(LowDetailSkipMips);
		p_Writer.Write(UseMipMappedStaticTile);
		p_Writer.Write(HasDetailVolumes);
		p_Writer.WriteNullBytes(2);
	}
}

