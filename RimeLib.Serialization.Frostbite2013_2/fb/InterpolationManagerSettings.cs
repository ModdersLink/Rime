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

namespace fb.Network;

[ContainerType(8, 72)]
public class InterpolationManagerSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float TimeNudgePIDConstKPos { get; set; } = 2.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float TimeNudgePIDConstKNeg { get; set; } = 0.500f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float TimeNudgePIDConstKNegHF { get; set; } = 1.500f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float TimeNudgePIDConstTIPos { get; set; } = 0.200f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float TimeNudgePIDConstTINeg { get; set; } = 0.200f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float TimeNudgePIDConstTDPos { get; set; } = 0.025f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float TimeNudgePIDConstTDNeg { get; set; } = 0.013f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float TimeNudgePIDLatencyTol { get; set; } = 0.010f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float TimeNudgePIDPacketDeltaTimeTol { get; set; } = 0.010f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float TimeNudgePIDIncreaseDueToMissingPacket { get; set; } = 0.200f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float TimeNudgePIDMaxChangePerSec { get; set; } = 0.900f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float PIDMissingPacketTime { get; set; } = 0.200f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float PIDMissingPacketCorrTimer { get; set; } = 1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float TimeNudgePIDMaxChangePerSecHFScale { get; set; } = 0.030f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TimeNudgePIDConstKPos);
		p_Writer.Write(TimeNudgePIDConstKNeg);
		p_Writer.Write(TimeNudgePIDConstKNegHF);
		p_Writer.Write(TimeNudgePIDConstTIPos);
		p_Writer.Write(TimeNudgePIDConstTINeg);
		p_Writer.Write(TimeNudgePIDConstTDPos);
		p_Writer.Write(TimeNudgePIDConstTDNeg);
		p_Writer.Write(TimeNudgePIDLatencyTol);
		p_Writer.Write(TimeNudgePIDPacketDeltaTimeTol);
		p_Writer.Write(TimeNudgePIDIncreaseDueToMissingPacket);
		p_Writer.Write(TimeNudgePIDMaxChangePerSec);
		p_Writer.Write(PIDMissingPacketTime);
		p_Writer.Write(PIDMissingPacketCorrTimer);
		p_Writer.Write(TimeNudgePIDMaxChangePerSecHFScale);
	}
}

