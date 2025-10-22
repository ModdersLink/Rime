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

using fb.Render;
using fb.Core;
using fb.UI;

namespace fb.VeniceShared;

[ContainerType(8, 96)]
public class UIPostProcessComponentData
	: fb.UI.UIComponentData
{
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float XPower { get; set; } = 1.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float YPower { get; set; } = 1.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float Slices { get; set; } = 4.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float TimeScale { get; set; } = 1.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float RShift { get; set; } = 0.025f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float GShift { get; set; } = 0.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float BShift { get; set; } = 0.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float ScanlinesVerticalWrap { get; set; } = 36.000f;
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<TextureAsset> NoiseTexture { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<TextureAsset> ScanlinesTexture { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(XPower);
		p_Writer.Write(YPower);
		p_Writer.Write(Slices);
		p_Writer.Write(TimeScale);
		p_Writer.Write(RShift);
		p_Writer.Write(GShift);
		p_Writer.Write(BShift);
		p_Writer.Write(ScanlinesVerticalWrap);
		p_Writer.Write(p_EbxWriter.WriteImport(NoiseTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ScanlinesTexture));
		p_Writer.WriteNullBytes(4);
	}
}

