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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 288)]
	public class VehicleConfigData :
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 CenterOfMass { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 CenterOfMassHandlingOffset { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 InertiaModifier { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public CtrRef<AeroDynamicPhysicsData> AeroDynamicPhysics { get; set; } = new();

		[ContainerField(68), JsonProperty(Order = 68)]
		public CtrRef<VehicleParachuteData> ParachutePhysics { get; set; } = new();

		[ContainerField(72), JsonProperty(Order = 72)]
		public CtrRef<MotorbikeData> MotorbikePhysics { get; set; } = new();

		[ContainerField(76), JsonProperty(Order = 76)]
		public CtrRef<MotionDampingData> MotionDamping { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public VehicleInputData Input { get; set; } = new();

		[ContainerField(160), JsonProperty(Order = 160)]
		public CtrRef<FloatPhysicsData> FloatPhysics { get; set; } = new();

		[ContainerField(164), JsonProperty(Order = 164)]
		public CtrRef<StabilizerData> Stabilizer { get; set; } = new();

		[ContainerField(168), JsonProperty(Order = 168)]
		public List<StabilizerSettings> Stabilizers { get; set; } = new();

		[ContainerField(172), JsonProperty(Order = 172)]
		public List<ConstantForceData> ConstantForce { get; set; } = new();

		[ContainerField(176), JsonProperty(Order = 176)]
		public VehicleMode VehicleModeAtReset { get; set; } = new();

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public float BodyMass { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float GravityModifier { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public float YawMin { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float YawMax { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public float DownForceBaseFactor { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public float DownForceWheelFactor { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public float VehicleModeChangeEnteringTime { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public float VehicleModeChangeStartingTime { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public float VehicleModeChangeStoppingTime { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float VehicleModeChangeLeavingTime { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public float StandStillLowSpeedTimeLimit { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public float StaticFrictionBreakCollisionMod { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public float StaticFrictionBreakVelocityMod { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		public float CoefficientOfAirFriction { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public float AirDensity { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public float AirDragArea { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		public float WindResistanceBaseFactor { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		public float WindResistanceVelocityFactor { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		public float WindResistanceVelocityFactorMin { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		public float WindResistanceVelocityFactorMax { get; set; }

		[ContainerField(260), JsonProperty(Order = 260)]
		public AntiRollBars AntiRollBars { get; set; } = new();

		[ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		public bool UseDownForceWheelFactor { get; set; }

		[ContainerField(269), LayoutImmutable, Blittable, JsonProperty(Order = 269)]
		public bool UseGearbox { get; set; }

		[ContainerField(270), LayoutImmutable, Blittable, JsonProperty(Order = 270)]
		public bool UseStandStillBrake { get; set; }

		[ContainerField(271), LayoutImmutable, Blittable, JsonProperty(Order = 271)]
		public bool UseStandStillSleep { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		public bool UseTurnAroundForce { get; set; }

		[ContainerField(273), LayoutImmutable, Blittable, JsonProperty(Order = 273)]
		public bool UseMotorcycleControl { get; set; }

		[ContainerField(274), LayoutImmutable, Blittable, JsonProperty(Order = 274)]
		public bool InvertPitchAllowed { get; set; }

		[ContainerField(275), LayoutImmutable, Blittable, JsonProperty(Order = 275)]
		public bool UseWindResistance { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		public bool UseDownForce { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			CenterOfMass.Serialize(p_Writer, p_EbxWriter);
			CenterOfMassHandlingOffset.Serialize(p_Writer, p_EbxWriter);
			InertiaModifier.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(AeroDynamicPhysics));
			p_Writer.Write(p_EbxWriter.WriteImport(ParachutePhysics));
			p_Writer.Write(p_EbxWriter.WriteImport(MotorbikePhysics));
			p_Writer.Write(p_EbxWriter.WriteImport(MotionDamping));
			Input.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(FloatPhysics));
			p_Writer.Write(p_EbxWriter.WriteImport(Stabilizer));
			(RimeWriter Writer, uint ArrayIndex) s_Stabilizers = p_EbxWriter.GetArrayWriter(Stabilizers.GetType(), Stabilizers.Count);
			p_Writer.Write(s_Stabilizers.ArrayIndex);
			foreach (var s_Entry in Stabilizers)
			{
				s_Entry.Serialize(s_Stabilizers.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ConstantForce = p_EbxWriter.GetArrayWriter(ConstantForce.GetType(), ConstantForce.Count);
			p_Writer.Write(s_ConstantForce.ArrayIndex);
			foreach (var s_Entry in ConstantForce)
			{
				s_Entry.Serialize(s_ConstantForce.Writer, p_EbxWriter);
			}
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
			AntiRollBars.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(UseDownForceWheelFactor);
			p_Writer.Write(UseGearbox);
			p_Writer.Write(UseStandStillBrake);
			p_Writer.Write(UseStandStillSleep);
			p_Writer.Write(UseTurnAroundForce);
			p_Writer.Write(UseMotorcycleControl);
			p_Writer.Write(InvertPitchAllowed);
			p_Writer.Write(UseWindResistance);
			p_Writer.Write(UseDownForce);
			p_Writer.WriteNullBytes(11);
		}
	}
}
