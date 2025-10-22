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

namespace fb.GameShared;

[ContainerType(16, 80)]
public class UIElementTextFilterGlow
	: fb.GameShared.UIElementTextFilter
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float X { get; set; } = 4.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float Y { get; set; } = 4.000f;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public UIElementColor Color { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float Strength { get; set; } = 100.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public bool KnockOut { get; set; } = false;
	
	[ContainerField(0x45), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
	public bool HideObject { get; set; } = false;
	
	[ContainerField(0x46), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
	public bool FineBlur { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(X);
		p_Writer.Write(Y);
		p_Writer.WriteNullBytes(8);
		Color.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Strength);
		p_Writer.Write(KnockOut);
		p_Writer.Write(HideObject);
		p_Writer.Write(FineBlur);
		p_Writer.WriteNullBytes(9);
	}
}

