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
public class UIElementTextFilterDropShadow
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
	public float Angle { get; set; } = 90.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float Distance { get; set; } = 4.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public bool KnockOut { get; set; } = false;
	
	[ContainerField(0x4d), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
	public bool HideObject { get; set; } = false;
	
	[ContainerField(0x4e), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
	public bool FineBlur { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(X);
		p_Writer.Write(Y);
		p_Writer.WriteNullBytes(8);
		Color.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Strength);
		p_Writer.Write(Angle);
		p_Writer.Write(Distance);
		p_Writer.Write(KnockOut);
		p_Writer.Write(HideObject);
		p_Writer.Write(FineBlur);
		p_Writer.WriteNullBytes(1);
	}
}

