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

[ContainerType(8, 40)]
public class CapturePointScoringHandlerData
	: fb.VeniceShared.ScoringHandlerData
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float SquadCappingBonus { get; set; } = 0.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float CapturePointLeadTickTime { get; set; } = 30.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public uint CapturePointLeadLimit { get; set; } = 1;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float CaptureDominationTickTime { get; set; } = 20.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float CaptureContributionTickLimit { get; set; } = 10.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float CaptureContributionLimit { get; set; } = 20.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SquadCappingBonus);
		p_Writer.Write(CapturePointLeadTickTime);
		p_Writer.Write(CapturePointLeadLimit);
		p_Writer.Write(CaptureDominationTickTime);
		p_Writer.Write(CaptureContributionTickLimit);
		p_Writer.Write(CaptureContributionLimit);
	}
}

