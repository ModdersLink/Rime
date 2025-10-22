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

[ContainerType(8, 64)]
public class UIMinimapLineStyle
	: fb.GameShared.UIElementStyle
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<UIMinimapColorStyle> Color { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string TextureId { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float TextureLengthScaling { get; set; } = 1.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float TextureSize { get; set; } = 0.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float TextureAngle { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float AnimationSpeed { get; set; } = 5.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float Width { get; set; } = 1.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public bool AlignTextureToEndpoints { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Color));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(TextureId));
		p_Writer.Write(TextureLengthScaling);
		p_Writer.Write(TextureSize);
		p_Writer.Write(TextureAngle);
		p_Writer.Write(AnimationSpeed);
		p_Writer.Write(Width);
		p_Writer.Write(AlignTextureToEndpoints);
		p_Writer.WriteNullBytes(3);
	}
}

