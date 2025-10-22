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
using fb.Entity;

namespace fb.Venice;

[ContainerType(16, 128)]
public class DeathExperienceEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float VictimOffsetVehicleMultiplier { get; set; } = 1.500f;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 VictimOffset { get; set; } = new()
	{
		z = -5.000f,
		y = 2.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 KillerOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 1.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float KillerTrackingSmoothness { get; set; } = 1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float ViewportHeightForSoldier { get; set; } = 4.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float ViewportHeightForVehicle { get; set; } = 10.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float AbsoluteMinFOV { get; set; } = 10.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float ViewportHeightBlendFactor { get; set; } = 1.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float TimeToStopCameraOnRevive { get; set; } = 1.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float FovBlendFactor { get; set; } = 0.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float MinimumHeightOverTerrain { get; set; } = 1.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float RotationBlendFactor { get; set; } = 0.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float InnerRadius { get; set; } = 2.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float OuterRadius { get; set; } = 5.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float VictimFocusingDistance { get; set; } = 10.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float CapsuleRadius { get; set; } = 1.500f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public bool CollisionEnabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(VictimOffsetVehicleMultiplier);
		p_Writer.WriteNullBytes(4);
		VictimOffset.Serialize(p_Writer, p_EbxWriter);
		KillerOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(KillerTrackingSmoothness);
		p_Writer.Write(ViewportHeightForSoldier);
		p_Writer.Write(ViewportHeightForVehicle);
		p_Writer.Write(AbsoluteMinFOV);
		p_Writer.Write(ViewportHeightBlendFactor);
		p_Writer.Write(TimeToStopCameraOnRevive);
		p_Writer.Write(FovBlendFactor);
		p_Writer.Write(MinimumHeightOverTerrain);
		p_Writer.Write(RotationBlendFactor);
		p_Writer.Write(InnerRadius);
		p_Writer.Write(OuterRadius);
		p_Writer.Write(VictimFocusingDistance);
		p_Writer.Write(CapsuleRadius);
		p_Writer.Write(CollisionEnabled);
		p_Writer.WriteNullBytes(11);
	}
}

