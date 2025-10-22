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

[ContainerType(8, 136)]
public class UIMinimapObjectiveWidgetData
	: fb.VeniceShared.UIObjectiveWidgetBaseData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float AnimationSpeed { get; set; } = 1.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float TextAlphaSpeed { get; set; } = 15.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float DelayBeforeComplted { get; set; } = 0.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float DelayBeforeRemoved { get; set; } = 5.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float CursorFrameRate { get; set; } = 30.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float BackplateFadeSpeed { get; set; } = 1.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float TextFadeInSpeed { get; set; } = 1.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float BackplateOffsetWhenHidden { get; set; } = 32.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AnimationSpeed);
		p_Writer.Write(TextAlphaSpeed);
		p_Writer.Write(DelayBeforeComplted);
		p_Writer.Write(DelayBeforeRemoved);
		p_Writer.Write(CursorFrameRate);
		p_Writer.Write(BackplateFadeSpeed);
		p_Writer.Write(TextFadeInSpeed);
		p_Writer.Write(BackplateOffsetWhenHidden);
	}
}

