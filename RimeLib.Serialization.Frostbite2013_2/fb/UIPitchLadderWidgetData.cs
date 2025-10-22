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
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 216)]
public class UIPitchLadderWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIElementFontStyle> FontStyle { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public uint Width { get; set; } = 250;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public string VelocityVectorTexture { get; set; } = string.Empty;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public uint LineSpacingDegrees { get; set; } = 5;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public uint LineSpacingPixels { get; set; } = 100;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float LinesRotationFactor { get; set; } = 0.500f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public string SideLexture { get; set; } = string.Empty;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public string AboveZeroTexture { get; set; } = string.Empty;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public string BelowZeroTexture { get; set; } = string.Empty;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public string ZeroTexture { get; set; } = string.Empty;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public int OffsetYHorizontalZeroAbove { get; set; } = 0;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public int OffsetYHorizontalNegative { get; set; } = 0;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public int OffsetXHorizontalLines { get; set; } = 0;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public int NumbersOffsetXPixels { get; set; } = 10;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public int NumbersOffsetYPixels { get; set; } = 0;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float VelocityVectorScaleX { get; set; } = 1.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float VelocityVectorScaleY { get; set; } = 1.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public bool UseVelocityVector { get; set; } = true;
	
	[ContainerField(0xcd), LayoutImmutable, Blittable, JsonProperty(Order = 205)]
	public bool VirtualHorizon { get; set; } = false;
	
	[ContainerField(0xce), LayoutImmutable, Blittable, JsonProperty(Order = 206)]
	public bool UseLeftSide { get; set; } = true;
	
	[ContainerField(0xcf), LayoutImmutable, Blittable, JsonProperty(Order = 207)]
	public bool UseRightSide { get; set; } = true;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public bool MultiLine { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(FontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Width);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(VelocityVectorTexture));
		p_Writer.Write(LineSpacingDegrees);
		p_Writer.Write(LineSpacingPixels);
		p_Writer.Write(LinesRotationFactor);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(SideLexture));
		p_Writer.Write(p_EbxWriter.WriteString(AboveZeroTexture));
		p_Writer.Write(p_EbxWriter.WriteString(BelowZeroTexture));
		p_Writer.Write(p_EbxWriter.WriteString(ZeroTexture));
		p_Writer.Write(OffsetYHorizontalZeroAbove);
		p_Writer.Write(OffsetYHorizontalNegative);
		p_Writer.Write(OffsetXHorizontalLines);
		p_Writer.Write(NumbersOffsetXPixels);
		p_Writer.Write(NumbersOffsetYPixels);
		p_Writer.Write(VelocityVectorScaleX);
		p_Writer.Write(VelocityVectorScaleY);
		p_Writer.Write(UseVelocityVector);
		p_Writer.Write(VirtualHorizon);
		p_Writer.Write(UseLeftSide);
		p_Writer.Write(UseRightSide);
		p_Writer.Write(MultiLine);
		p_Writer.WriteNullBytes(7);
	}
}

