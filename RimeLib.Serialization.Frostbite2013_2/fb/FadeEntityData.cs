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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 40)]
public class FadeEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float FadeTime { get; set; } = 1.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float MaxWaitFadedWhileStreamingTime { get; set; } = 0.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool FadeScreen { get; set; } = true;
	
	[ContainerField(0x21), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
	public bool FadeUI { get; set; } = false;
	
	[ContainerField(0x22), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
	public bool FadeAudio { get; set; } = false;
	
	[ContainerField(0x23), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
	public bool FadeMovie { get; set; } = false;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool FadeRumble { get; set; } = false;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool StartFaded { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FadeTime);
		p_Writer.Write(MaxWaitFadedWhileStreamingTime);
		p_Writer.Write(FadeScreen);
		p_Writer.Write(FadeUI);
		p_Writer.Write(FadeAudio);
		p_Writer.Write(FadeMovie);
		p_Writer.Write(FadeRumble);
		p_Writer.Write(StartFaded);
		p_Writer.WriteNullBytes(2);
	}
}

