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

namespace fb.Render;

[ContainerType(8, 72)]
public class StaticEnlightenData
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<TextureAsset> StaticIrradianceChromaTexture { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public ResourceRef DatabaseResource { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<TextureAsset> StaticIrradianceLumaTexture { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<TextureAsset> StaticDirectionTexture { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RefArray<TextureAsset> StaticCubeMapTextures { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool StaticGen4Enable { get; set; } = true;
	
	[ContainerField(0x41), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
	public bool CubeMapsGen3Enable { get; set; } = false;
	
	[ContainerField(0x42), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
	public bool TextureCompressionEnable { get; set; } = false;
	
	[ContainerField(0x43), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
	public bool ChromaCompressionEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(StaticIrradianceChromaTexture));
		p_Writer.WriteNullBytes(4);
		DatabaseResource.Serialize(p_Writer);
		p_Writer.Write(p_EbxWriter.WriteImport(StaticIrradianceLumaTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(StaticDirectionTexture));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_StaticCubeMapTextures = p_EbxWriter.GetArrayWriter(StaticCubeMapTextures.GetType(), StaticCubeMapTextures.Count);
		p_Writer.Write(s_StaticCubeMapTextures.ArrayIndex);
		foreach (var s_Entry in StaticCubeMapTextures)
		{
			s_StaticCubeMapTextures.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(StaticGen4Enable);
		p_Writer.Write(CubeMapsGen3Enable);
		p_Writer.Write(TextureCompressionEnable);
		p_Writer.Write(ChromaCompressionEnable);
		p_Writer.WriteNullBytes(4);
	}
}

