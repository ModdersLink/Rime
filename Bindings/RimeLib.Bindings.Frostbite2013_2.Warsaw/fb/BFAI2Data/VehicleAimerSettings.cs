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

namespace fb.BFAI2Data;

[ContainerType(8, 24)]
public class VehicleAimerSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float MinPrecisionToFire { get; set; } = 5.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public bool IsParabolic { get; set; } = true;
	
	[ContainerField(0x15), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
	public bool AimHigh { get; set; } = false;
	
	[ContainerField(0x16), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
	public bool TrackTowardsTarget { get; set; } = false;
	
	[ContainerField(0x17), LayoutImmutable, Blittable, JsonProperty(Order = 23)]
	public bool TrackBeyondTarget { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MinPrecisionToFire);
		p_Writer.Write(IsParabolic);
		p_Writer.Write(AimHigh);
		p_Writer.Write(TrackTowardsTarget);
		p_Writer.Write(TrackBeyondTarget);
	}
}

