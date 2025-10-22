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

namespace fb.Terrain;

[ContainerType(8, 64)]
public class TerrainData
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<TerrainLayerData> TerrainLayers { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public ResourceRef TerrainStreamingTreeResource { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public ResourceRef VisualResource { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public ResourceRef TerrainLayerCombinationsResource { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool DestructionMaskEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_TerrainLayers = p_EbxWriter.GetArrayWriter(TerrainLayers.GetType(), TerrainLayers.Count);
		p_Writer.Write(s_TerrainLayers.ArrayIndex);
		foreach (var s_Entry in TerrainLayers)
		{
			s_TerrainLayers.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		TerrainStreamingTreeResource.Serialize(p_Writer);
		VisualResource.Serialize(p_Writer);
		TerrainLayerCombinationsResource.Serialize(p_Writer);
		p_Writer.Write(DestructionMaskEnable);
		p_Writer.WriteNullBytes(7);
	}
}

