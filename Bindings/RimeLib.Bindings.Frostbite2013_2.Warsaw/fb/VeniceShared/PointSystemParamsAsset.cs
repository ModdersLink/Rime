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

namespace fb.VeniceShared;

[ContainerType(8, 64)]
public class PointSystemParamsAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float MultiKillTimeLimit { get; set; } = 0.800f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float TimedKillStreakMinTime { get; set; } = 0.800f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float TimedKillStreakMaxTime { get; set; } = 3.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float DnfTimeout { get; set; } = 60.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint KillStreakX { get; set; } = 6;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint KillStreakHVT { get; set; } = 7;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint NemesisKillX { get; set; } = 5;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float AdrenalineKillHealthLimit { get; set; } = 0.300f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float UnanimousSupportThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float UnanimousSupportTickTime { get; set; } = 30.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MultiKillTimeLimit);
		p_Writer.Write(TimedKillStreakMinTime);
		p_Writer.Write(TimedKillStreakMaxTime);
		p_Writer.Write(DnfTimeout);
		p_Writer.Write(KillStreakX);
		p_Writer.Write(KillStreakHVT);
		p_Writer.Write(NemesisKillX);
		p_Writer.Write(AdrenalineKillHealthLimit);
		p_Writer.Write(UnanimousSupportThreshold);
		p_Writer.Write(UnanimousSupportTickTime);
	}
}

