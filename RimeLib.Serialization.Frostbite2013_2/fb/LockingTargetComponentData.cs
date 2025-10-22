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
using fb.GameShared;
using fb.Entity;

namespace fb.Venice;

[ContainerType(16, 208)]
public class LockingTargetComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public SmokeJammingData SmokeJamming { get; set; } = new();
	
	[ContainerField(0x84), JsonProperty(Order = 132)]
	public AirMissileJammingData AirMissileJamming { get; set; } = new();
	
	[ContainerField(0xb4), JsonProperty(Order = 180)]
	public VehicleLockableInfoData VehicleLockableInfo { get; set; } = new();
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float LockingTimeMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float HighAltitudeLockHeight { get; set; } = 0.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public bool IsLockable { get; set; } = true;
	
	[ContainerField(0xcd), LayoutImmutable, Blittable, JsonProperty(Order = 205)]
	public bool UseLowAltitudeHeatSignature { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		SmokeJamming.Serialize(p_Writer, p_EbxWriter);
		AirMissileJamming.Serialize(p_Writer, p_EbxWriter);
		VehicleLockableInfo.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LockingTimeMultiplier);
		p_Writer.Write(HighAltitudeLockHeight);
		p_Writer.Write(IsLockable);
		p_Writer.Write(UseLowAltitudeHeatSignature);
		p_Writer.WriteNullBytes(2);
	}
}

