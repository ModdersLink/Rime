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

[ContainerType(4, 64)]
public class AttackCoverRequestSettings
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float MinimumTimeInCoverToRequest { get; set; } = 1.000f;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public float MaximumTimeInCoverToRequest { get; set; } = 6.000f;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public float MinimumTimeIntervalToRequestProtectiveCover { get; set; } = 2.500f;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public float MaximumTimeIntervalToRequestProtectiveCover { get; set; } = 5.000f;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float MinimumTimeInCoverAfterTargetLost { get; set; } = 10.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float MaximumTimeInCoverAfterTargetLost { get; set; } = 20.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float DistanceToTargetCompromisedThreshold { get; set; } = 6.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float MinimumDistanceToTarget { get; set; } = 5.000f;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public TinyPiecewiseLinearCurve MinimumInitialDelay { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public TinyPiecewiseLinearCurve MaximumInitialDelay { get; set; } = new();
	
}

