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
using fb.Render;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 272)]
public class FPSCameraData
	: fb.GameShared.TargetCameraData
{
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public TurnEffectData TurnEffectSettings { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public BlurEffectData BlurEffectSettings { get; set; } = new();
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float FOV { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		TurnEffectSettings.Serialize(p_Writer, p_EbxWriter);
		BlurEffectSettings.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FOV);
		p_Writer.WriteNullBytes(4);
	}
}

