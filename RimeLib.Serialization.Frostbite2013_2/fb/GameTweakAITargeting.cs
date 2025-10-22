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

[ContainerType(4, 100)]
public class GameTweakAITargeting
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float IntervalBetweenAdditionalEnemiesTargetingPlayer { get; set; } = 1.000f;
	
	[ContainerField(0x4), JsonProperty(Order = 4)]
	public TinyPiecewiseLinearCurve FiringDelayAfterAquiringTarget { get; set; } = new();
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float ReaquireTargetDistanceThreshold { get; set; } = 5.000f;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public TinyPiecewiseLinearCurve FiringDelayAfterReaquiringTarget { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public TinyPiecewiseLinearCurve TimeUntilDamageFromStartOfFirstBurst { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public TinyPiecewiseLinearCurve TimeUntilDamageTimeIsFullyRestored { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public AccuracyPenaltySettings AccuracyPenaltySettings { get; set; } = new();
	
}

