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
public class UIProgressionBarWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float IncreaseBarAnimationDuration { get; set; } = 2.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float DecreaseBarAnimationDuration { get; set; } = 2.000f;
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 IconGlowColor { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float NegativeFadeInAnimationDuration { get; set; } = 0.500f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float NegativeFadeOutAnimationDuration { get; set; } = 0.500f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float GrowAnimationDuration { get; set; } = 0.250f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float ShrinkAnimationDuration { get; set; } = 0.500f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float GrowAnimationScale { get; set; } = 1.500f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float IconUnavalibleAlpha { get; set; } = 0.500f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(IncreaseBarAnimationDuration);
		p_Writer.Write(DecreaseBarAnimationDuration);
		IconGlowColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(NegativeFadeInAnimationDuration);
		p_Writer.Write(NegativeFadeOutAnimationDuration);
		p_Writer.Write(GrowAnimationDuration);
		p_Writer.Write(ShrinkAnimationDuration);
		p_Writer.Write(GrowAnimationScale);
		p_Writer.Write(IconUnavalibleAlpha);
		p_Writer.WriteNullBytes(8);
	}
}

