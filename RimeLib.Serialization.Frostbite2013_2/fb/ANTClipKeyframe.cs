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

using fb.Ant;
using fb.Core;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 64)]
public class ANTClipKeyframe
	: fb.Entity.TimelineKeyframeData
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float Time { get; set; } = 0.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float Length { get; set; } = 0.000f;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AntRef Controller { get; set; } = new();
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float ClipStartTrim { get; set; } = 0.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float ClipEndTrim { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float ClipCycleStartOffset { get; set; } = 0.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float ClipTimeScale { get; set; } = 1.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public ANTClipEndRule ClipEndRule { get; set; } = ANTClipEndRule.ANTClipEndRule_None;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Time);
		p_Writer.Write(Length);
		Controller.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ClipStartTrim);
		p_Writer.Write(ClipEndTrim);
		p_Writer.Write(ClipCycleStartOffset);
		p_Writer.Write(ClipTimeScale);
		p_Writer.Write((int) ClipEndRule);
	}
}

