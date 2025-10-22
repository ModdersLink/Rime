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

namespace fb.VeniceShared;

[ContainerType(16, 128)]
public class BFUIElement3SliceStatbarAlignedStyle
	: fb.VeniceShared.BFUIElement3SliceStatbarStyle
{
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public UIElementAlignment HorizontalAlignment { get; set; } = UIElementAlignment.UIElementAlignment_Left;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool Vertical { get; set; } = false;
	
	[ContainerField(0x55), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
	public bool Invert { get; set; } = false;
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public UIElementColor Color { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) HorizontalAlignment);
		p_Writer.Write(Vertical);
		p_Writer.Write(Invert);
		p_Writer.WriteNullBytes(10);
		Color.Serialize(p_Writer, p_EbxWriter);
	}
}

