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

namespace fb.Physics;

[ContainerType(16, 384)]
public class VehicleConfigData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<AeroDynamicPhysicsData> AeroDynamicPhysics { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<MotorbikeData> MotorbikePhysics { get; set; } = new();
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 CenterOfMass { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 CenterOfMassHandlingOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 InertiaOverride { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public Vec3 InertiaModifier { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec3 ProximityExtScale { get; set; } = new()
	{
		z = 1.334f,
		y = 1.334f,
		x = 1.334f,
	};
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<MotionDampingData> MotionDamping { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public VehicleInputData Input { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public CtrRef<FloatPhysicsData> FloatPhysics { get; set; } = new();
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<StabilizerData> Stabilizer { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public List<StabilizerSettings> Stabilizers { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public List<ConstantForceData> ConstantForce { get; set; } = new();
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public VehicleMode VehicleModeAtReset { get; set; } = VehicleMode.VmIdle;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public float BodyMass { get; set; } = 5000.000f;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float GravityModifier { get; set; } = 1.000f;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public float YawMin { get; set; } = -1.000f;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float YawMax { get; set; } = 1.000f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public float DownForceBaseFactor { get; set; } = 8.000f;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float DownForceWheelFactor { get; set; } = 40.000f;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float VehicleModeChangeEnteringTime { get; set; } = 1.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float VehicleModeChangeStartingTime { get; set; } = 3.000f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float VehicleModeChangeStoppingTime { get; set; } = 1.000f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float VehicleModeChangeLeavingTime { get; set; } = 3.000f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float StandStillLowSpeedTimeLimit { get; set; } = 2.000f;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public float StaticFrictionBreakCollisionMod { get; set; } = 1.000f;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public float StaticFrictionBreakVelocityMod { get; set; } = 1.000f;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float CoefficientOfAirFriction { get; set; } = 0.500f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public float AirDensity { get; set; } = 1.225f;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public float AirDragArea { get; set; } = 9.000f;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public float WindResistanceBaseFactor { get; set; } = 0.200f;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float WindResistanceVelocityFactor { get; set; } = 100.000f;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public float WindResistanceVelocityFactorMin { get; set; } = 1.000f;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public float WindResistanceVelocityFactorMax { get; set; } = 4.000f;
	
	[ContainerField(0x13c), JsonProperty(Order = 316)]
	public InputThrottle UseInputYawAsThrottle { get; set; } = new();
	
	[ContainerField(0x150), JsonProperty(Order = 336)]
	public AntiRollBars AntiRollBars { get; set; } = new();
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public float MaxGroundSpeed { get; set; } = 0.000f;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public float ProximityHeightTranslation { get; set; } = -1.000f;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public float FrictionAtLowVelocity { get; set; } = 0.000f;
	
	[ContainerField(0x16c), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
	public bool UseDownForce { get; set; } = false;
	
	[ContainerField(0x16d), LayoutImmutable, Blittable, JsonProperty(Order = 365)]
	public bool UseDownForceWheelFactor { get; set; } = true;
	
	[ContainerField(0x16e), LayoutImmutable, Blittable, JsonProperty(Order = 366)]
	public bool UseGearbox { get; set; } = true;
	
	[ContainerField(0x16f), LayoutImmutable, Blittable, JsonProperty(Order = 367)]
	public bool UseStandStillBrake { get; set; } = true;
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public bool UseStandStillSleep { get; set; } = true;
	
	[ContainerField(0x171), LayoutImmutable, Blittable, JsonProperty(Order = 369)]
	public bool UseTurnAroundForce { get; set; } = false;
	
	[ContainerField(0x172), LayoutImmutable, Blittable, JsonProperty(Order = 370)]
	public bool UseMotorcycleControl { get; set; } = false;
	
	[ContainerField(0x173), LayoutImmutable, Blittable, JsonProperty(Order = 371)]
	public bool InvertPitchAllowed { get; set; } = false;
	
	[ContainerField(0x174), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
	public bool UseWindResistance { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(AeroDynamicPhysics));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MotorbikePhysics));
		p_Writer.WriteNullBytes(4);
		CenterOfMass.Serialize(p_Writer, p_EbxWriter);
		CenterOfMassHandlingOffset.Serialize(p_Writer, p_EbxWriter);
		InertiaOverride.Serialize(p_Writer, p_EbxWriter);
		InertiaModifier.Serialize(p_Writer, p_EbxWriter);
		ProximityExtScale.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(MotionDamping));
		p_Writer.WriteNullBytes(4);
		Input.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(FloatPhysics));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Stabilizer));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Stabilizers = p_EbxWriter.GetArrayWriter(Stabilizers.GetType(), Stabilizers.Count);
		p_Writer.Write(s_Stabilizers.ArrayIndex);
		foreach (var s_Entry in Stabilizers)
		{
			s_Entry.Serialize(s_Stabilizers.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ConstantForce = p_EbxWriter.GetArrayWriter(ConstantForce.GetType(), ConstantForce.Count);
		p_Writer.Write(s_ConstantForce.ArrayIndex);
		foreach (var s_Entry in ConstantForce)
		{
			s_Entry.Serialize(s_ConstantForce.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) VehicleModeAtReset);
		p_Writer.Write(BodyMass);
		p_Writer.Write(GravityModifier);
		p_Writer.Write(YawMin);
		p_Writer.Write(YawMax);
		p_Writer.Write(DownForceBaseFactor);
		p_Writer.Write(DownForceWheelFactor);
		p_Writer.Write(VehicleModeChangeEnteringTime);
		p_Writer.Write(VehicleModeChangeStartingTime);
		p_Writer.Write(VehicleModeChangeStoppingTime);
		p_Writer.Write(VehicleModeChangeLeavingTime);
		p_Writer.Write(StandStillLowSpeedTimeLimit);
		p_Writer.Write(StaticFrictionBreakCollisionMod);
		p_Writer.Write(StaticFrictionBreakVelocityMod);
		p_Writer.Write(CoefficientOfAirFriction);
		p_Writer.Write(AirDensity);
		p_Writer.Write(AirDragArea);
		p_Writer.Write(WindResistanceBaseFactor);
		p_Writer.Write(WindResistanceVelocityFactor);
		p_Writer.Write(WindResistanceVelocityFactorMin);
		p_Writer.Write(WindResistanceVelocityFactorMax);
		UseInputYawAsThrottle.Serialize(p_Writer, p_EbxWriter);
		AntiRollBars.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxGroundSpeed);
		p_Writer.Write(ProximityHeightTranslation);
		p_Writer.Write(FrictionAtLowVelocity);
		p_Writer.Write(UseDownForce);
		p_Writer.Write(UseDownForceWheelFactor);
		p_Writer.Write(UseGearbox);
		p_Writer.Write(UseStandStillBrake);
		p_Writer.Write(UseStandStillSleep);
		p_Writer.Write(UseTurnAroundForce);
		p_Writer.Write(UseMotorcycleControl);
		p_Writer.Write(InvertPitchAllowed);
		p_Writer.Write(UseWindResistance);
		p_Writer.WriteNullBytes(11);
	}
}

