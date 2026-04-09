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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 288)]
	public partial class VehicleConfigData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _CenterOfMass = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _CenterOfMassHandlingOffset = new();

		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec3 _InertiaModifier = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private CtrRef<AeroDynamicPhysicsData> _AeroDynamicPhysics = new();

		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private CtrRef<VehicleParachuteData> _ParachutePhysics = new();

		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private CtrRef<MotorbikeData> _MotorbikePhysics = new();

		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private CtrRef<MotionDampingData> _MotionDamping = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private VehicleInputData _Input = new();

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private CtrRef<FloatPhysicsData> _FloatPhysics = new();

		[ObservableProperty]
		[property: ContainerField(164), JsonProperty(Order = 164)]
		private CtrRef<StabilizerData> _Stabilizer = new();

		[ObservableProperty]
		[property: ContainerField(168), JsonProperty(Order = 168)]
		private List<StabilizerSettings> _Stabilizers = new();

		[ObservableProperty]
		[property: ContainerField(172), JsonProperty(Order = 172)]
		private List<ConstantForceData> _ConstantForce = new();

		[ObservableProperty]
		[property: ContainerField(176), JsonProperty(Order = 176)]
		private VehicleMode _VehicleModeAtReset = new();

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _BodyMass;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _GravityModifier;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private float _YawMin;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _YawMax;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private float _DownForceBaseFactor;

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private float _DownForceWheelFactor;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private float _VehicleModeChangeEnteringTime;

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private float _VehicleModeChangeStartingTime;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private float _VehicleModeChangeStoppingTime;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _VehicleModeChangeLeavingTime;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private float _StandStillLowSpeedTimeLimit;

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private float _StaticFrictionBreakCollisionMod;

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private float _StaticFrictionBreakVelocityMod;

		[ObservableProperty]
		[property: ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		private float _CoefficientOfAirFriction;

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private float _AirDensity;

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private float _AirDragArea;

		[ObservableProperty]
		[property: ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		private float _WindResistanceBaseFactor;

		[ObservableProperty]
		[property: ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		private float _WindResistanceVelocityFactor;

		[ObservableProperty]
		[property: ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		private float _WindResistanceVelocityFactorMin;

		[ObservableProperty]
		[property: ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		private float _WindResistanceVelocityFactorMax;

		[ObservableProperty]
		[property: ContainerField(260), JsonProperty(Order = 260)]
		private AntiRollBars _AntiRollBars = new();

		[ObservableProperty]
		[property: ContainerField(268), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
		private bool _UseDownForceWheelFactor;

		[ObservableProperty]
		[property: ContainerField(269), LayoutImmutable, Blittable, JsonProperty(Order = 269)]
		private bool _UseGearbox;

		[ObservableProperty]
		[property: ContainerField(270), LayoutImmutable, Blittable, JsonProperty(Order = 270)]
		private bool _UseStandStillBrake;

		[ObservableProperty]
		[property: ContainerField(271), LayoutImmutable, Blittable, JsonProperty(Order = 271)]
		private bool _UseStandStillSleep;

		[ObservableProperty]
		[property: ContainerField(272), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		private bool _UseTurnAroundForce;

		[ObservableProperty]
		[property: ContainerField(273), LayoutImmutable, Blittable, JsonProperty(Order = 273)]
		private bool _UseMotorcycleControl;

		[ObservableProperty]
		[property: ContainerField(274), LayoutImmutable, Blittable, JsonProperty(Order = 274)]
		private bool _InvertPitchAllowed;

		[ObservableProperty]
		[property: ContainerField(275), LayoutImmutable, Blittable, JsonProperty(Order = 275)]
		private bool _UseWindResistance;

		[ObservableProperty]
		[property: ContainerField(276), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
		private bool _UseDownForce;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
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
