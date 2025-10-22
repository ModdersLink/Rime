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

[ContainerType(8, 40)]
public class MusicFadeData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public MusicSyncType SyncType { get; set; } = MusicSyncType.MusicSyncType_Immediate;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float FadeOutLength { get; set; } = 0.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public MusicFadeType FadeOutType { get; set; } = MusicFadeType.MusicFadeType_Seconds;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float FadeInLength { get; set; } = 0.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public MusicFadeType FadeInType { get; set; } = MusicFadeType.MusicFadeType_Seconds;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool EqualPower { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) SyncType);
		p_Writer.Write(FadeOutLength);
		p_Writer.Write((int) FadeOutType);
		p_Writer.Write(FadeInLength);
		p_Writer.Write((int) FadeInType);
		p_Writer.Write(EqualPower);
		p_Writer.WriteNullBytes(3);
	}
}

