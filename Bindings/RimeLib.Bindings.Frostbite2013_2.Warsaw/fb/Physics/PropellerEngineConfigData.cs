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

[ContainerType(16, 320)]
public class PropellerEngineConfigData
	: fb.Physics.EngineConfigData
{
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 HorisontalForceOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public PropellerType PropellerType { get; set; } = fb.Physics.PropellerType.PropellerType_Rotor;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<RotorParameters> RotorConfig { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public ForceMagnitudeInputType ForceMagnitudeInputType { get; set; } = fb.Physics.ForceMagnitudeInputType.FMITYaw;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public uint DirectionVectorIndex { get; set; } = 0;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float ForceMagnitudeMultiplier { get; set; } = 2.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float LiftForceSpringConstant { get; set; } = 40000.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float LiftForceDampingConstant { get; set; } = 20000.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float CyclicInputScaleRoll { get; set; } = 0.200f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float CyclicRollLiftMod { get; set; } = 1.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float CyclicRollStrafeMod { get; set; } = 1.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float CyclicInputScalePitch { get; set; } = 0.200f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float CyclicPitchLiftMod { get; set; } = 1.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float CyclicPitchStrafeMod { get; set; } = 1.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float CyclicPitchStrafeBrakeMod { get; set; } = 1.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float CollectiveInputIdle { get; set; } = 0.900f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float CollectiveThrottleInputScale { get; set; } = 1.100f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float CollectiveBrakeInputScale { get; set; } = 1.100f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float DefaultAngleOfAttack { get; set; } = 0.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float AttackAngleMod { get; set; } = 1.000f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float StabilizerMod { get; set; } = 1.000f;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float HorisontalMinEffectVelocity { get; set; } = 20.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float HorisontalMinEffectMod { get; set; } = 0.200f;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public ForceMagnitudeInputType SPForwardInput { get; set; } = ForceMagnitudeInputType.FMITStrafe;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public ForceMagnitudeInputType SPSidewaysInput { get; set; } = ForceMagnitudeInputType.FMITRoll;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public ForceMagnitudeInputType SPVerticalInput { get; set; } = ForceMagnitudeInputType.FMITThrottle;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public ForceMagnitudeInputType SPPitchInput { get; set; } = ForceMagnitudeInputType.FMITPitch;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public ForceMagnitudeInputType SPYawInput { get; set; } = ForceMagnitudeInputType.FMITYaw;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public float SPForwardStrength { get; set; } = 30.000f;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float SPSidewaysStrength { get; set; } = 10.000f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public float SPVerticalStrength { get; set; } = 10.000f;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float SPReverseForceMod { get; set; } = 0.500f;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float PitchStrength { get; set; } = 20.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float PitchLimit { get; set; } = 0.500f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float PitchFromVel { get; set; } = 20.000f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float VelocityFromPitch { get; set; } = 0.000f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float RollStrength { get; set; } = 25.000f;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public float BankingStrength { get; set; } = 40.000f;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public float BankingLimit { get; set; } = 10.000f;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float PitchUpWhenBankStrength { get; set; } = 6.000f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public float PitchUpWhenBankLimit { get; set; } = 2.000f;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public float GravityMod { get; set; } = 0.100f;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public float MaxHorizontalVelocity { get; set; } = 0.000f;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public bool ApplyForceAsTorque { get; set; } = false;
	
	[ContainerField(0x131), LayoutImmutable, Blittable, JsonProperty(Order = 305)]
	public bool EnableNewHelicopter { get; set; } = true;
	
	[ContainerField(0x132), LayoutImmutable, Blittable, JsonProperty(Order = 306)]
	public bool SPAllowed { get; set; } = false;
	
	[ContainerField(0x133), LayoutImmutable, Blittable, JsonProperty(Order = 307)]
	public bool SPDefault { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		HorisontalForceOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) PropellerType);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(RotorConfig));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) ForceMagnitudeInputType);
		p_Writer.Write(DirectionVectorIndex);
		p_Writer.Write(ForceMagnitudeMultiplier);
		p_Writer.Write(LiftForceSpringConstant);
		p_Writer.Write(LiftForceDampingConstant);
		p_Writer.Write(CyclicInputScaleRoll);
		p_Writer.Write(CyclicRollLiftMod);
		p_Writer.Write(CyclicRollStrafeMod);
		p_Writer.Write(CyclicInputScalePitch);
		p_Writer.Write(CyclicPitchLiftMod);
		p_Writer.Write(CyclicPitchStrafeMod);
		p_Writer.Write(CyclicPitchStrafeBrakeMod);
		p_Writer.Write(CollectiveInputIdle);
		p_Writer.Write(CollectiveThrottleInputScale);
		p_Writer.Write(CollectiveBrakeInputScale);
		p_Writer.Write(DefaultAngleOfAttack);
		p_Writer.Write(AttackAngleMod);
		p_Writer.Write(StabilizerMod);
		p_Writer.Write(HorisontalMinEffectVelocity);
		p_Writer.Write(HorisontalMinEffectMod);
		p_Writer.Write((int) SPForwardInput);
		p_Writer.Write((int) SPSidewaysInput);
		p_Writer.Write((int) SPVerticalInput);
		p_Writer.Write((int) SPPitchInput);
		p_Writer.Write((int) SPYawInput);
		p_Writer.Write(SPForwardStrength);
		p_Writer.Write(SPSidewaysStrength);
		p_Writer.Write(SPVerticalStrength);
		p_Writer.Write(SPReverseForceMod);
		p_Writer.Write(PitchStrength);
		p_Writer.Write(PitchLimit);
		p_Writer.Write(PitchFromVel);
		p_Writer.Write(VelocityFromPitch);
		p_Writer.Write(RollStrength);
		p_Writer.Write(BankingStrength);
		p_Writer.Write(BankingLimit);
		p_Writer.Write(PitchUpWhenBankStrength);
		p_Writer.Write(PitchUpWhenBankLimit);
		p_Writer.Write(GravityMod);
		p_Writer.Write(MaxHorizontalVelocity);
		p_Writer.Write(ApplyForceAsTorque);
		p_Writer.Write(EnableNewHelicopter);
		p_Writer.Write(SPAllowed);
		p_Writer.Write(SPDefault);
		p_Writer.WriteNullBytes(12);
	}
}

