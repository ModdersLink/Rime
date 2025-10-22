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

[ContainerType(4, 136)]
public class GameTweakCommon
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float SensingConeRange { get; set; } = 40.000f;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public float SensingConeRangeWhenAlerted { get; set; } = 60.000f;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public float SensingConeAngle { get; set; } = 60.000f;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public float SensingConeAngleWhenAlerted { get; set; } = 60.000f;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float SensingConeAngleAbove { get; set; } = 15.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float SensingConeAngleBelow { get; set; } = 55.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float SensingShotFiredDistance { get; set; } = 120.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float SensingHumanDrivenVehicleDistance { get; set; } = 50.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float SensingExplosionDistance { get; set; } = 120.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float SensingGrenadeDistance { get; set; } = 12.000f;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public TinyPiecewiseLinearCurve DistanceToAwareTimeCurveCentral { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float AwareCurveCentralAngle { get; set; } = 30.000f;
	
	[ContainerField(0x3c), JsonProperty(Order = 60)]
	public TinyPiecewiseLinearCurve DistanceToAwareTimeCurvePeripheral { get; set; } = new();
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float AwareStandingPenaltyMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float AwareToAlertTime { get; set; } = 0.100f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float HighIntensityRadius { get; set; } = 10.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float ConcealmentCoolDownTime { get; set; } = 6.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float ConcealmentDisableAtDistance { get; set; } = 2.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float PassiveTime { get; set; } = 10.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float GrenadeMinimumTime { get; set; } = 10.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float GrenadeMaximumTime { get; set; } = 20.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float ChargeGrenadeMinimumTime { get; set; } = 10.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float ChargeGrenadeMaximumTime { get; set; } = 20.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public int SimultaneousChargeCount { get; set; } = 4;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public int SimultaneousVehicleUsage { get; set; } = 2;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float MinVehicleBookingDelayOnTokenAvailable { get; set; } = 2.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float MaxVehicleBookingDelayOnTokenAvailable { get; set; } = 8.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float EnemyMinTimeInMediumIntensity { get; set; } = 10.000f;
	
}

