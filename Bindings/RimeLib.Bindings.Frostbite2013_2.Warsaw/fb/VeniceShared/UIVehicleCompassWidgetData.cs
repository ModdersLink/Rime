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

using fb.GameShared;
using fb.Core;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 168)]
public class UIVehicleCompassWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public string MarkerTexture { get; set; } = string.Empty;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public int MarkerOffsetY { get; set; } = 0;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float FullCircleMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public uint Intervals { get; set; } = 45;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public int LabelsOffsetX { get; set; } = 1;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public int LabelsOffsetY { get; set; } = 35;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<UIElementFontStyle> FontStyle { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public int LinesOffsetY { get; set; } = 15;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public string LinesTexture { get; set; } = string.Empty;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public uint DegreesPerTexture { get; set; } = 10;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public bool DisplaySWNE { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(MarkerTexture));
		p_Writer.Write(MarkerOffsetY);
		p_Writer.Write(FullCircleMultiplier);
		p_Writer.Write(Intervals);
		p_Writer.Write(LabelsOffsetX);
		p_Writer.Write(LabelsOffsetY);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(LinesOffsetY);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(LinesTexture));
		p_Writer.Write(DegreesPerTexture);
		p_Writer.Write(DisplaySWNE);
		p_Writer.WriteNullBytes(3);
	}
}

