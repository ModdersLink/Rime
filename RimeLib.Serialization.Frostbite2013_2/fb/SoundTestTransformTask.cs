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

namespace fb.Audio;

[ContainerType(16, 64)]
public class SoundTestTransformTask
	: fb.Audio.SoundTestTaskSpec
{
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 InitialPosition { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public SoundTestTransformBehavior Behavior { get; set; } = SoundTestTransformBehavior.SoundTestTransformBehavior_Static;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool RelativeListener { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		InitialPosition.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Behavior);
		p_Writer.Write(RelativeListener);
		p_Writer.WriteNullBytes(11);
	}
}

