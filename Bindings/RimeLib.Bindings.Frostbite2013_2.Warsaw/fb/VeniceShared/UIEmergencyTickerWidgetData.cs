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

[ContainerType(16, 192)]
public class UIEmergencyTickerWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float ScrollingSpeed { get; set; } = 0.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float StartFreezeTime { get; set; } = 3.000f;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public UIElementColor WarningTriangleColor { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public UIElementColor BoostIconColor { get; set; } = new();
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float EndFreezeTime { get; set; } = 2.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ScrollingSpeed);
		p_Writer.Write(StartFreezeTime);
		WarningTriangleColor.Serialize(p_Writer, p_EbxWriter);
		BoostIconColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(EndFreezeTime);
		p_Writer.WriteNullBytes(12);
	}
}

