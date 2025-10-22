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

[ContainerType(16, 160)]
public class UIStepperWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public int CellSpacing { get; set; } = 2;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public int CellWidth { get; set; } = 300;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public UIElementColor ArrowColor { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float ArrowWidth { get; set; } = 30.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float ArrowHeight { get; set; } = 45.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CellSpacing);
		p_Writer.Write(CellWidth);
		ArrowColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ArrowWidth);
		p_Writer.Write(ArrowHeight);
		p_Writer.WriteNullBytes(8);
	}
}

