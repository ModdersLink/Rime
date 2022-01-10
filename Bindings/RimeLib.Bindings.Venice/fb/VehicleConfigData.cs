///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 288)]
	public class VehicleConfigData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CenterOfMass { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CenterOfMassHandlingOffset { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InertiaModifier { get; set; } = new();

		[ContainerField(64)]
		public CtrRef<AeroDynamicPhysicsData> AeroDynamicPhysics { get; set; } = new();

		[ContainerField(68)]
		public CtrRef<VehicleParachuteData> ParachutePhysics { get; set; } = new();

		[ContainerField(72)]
		public CtrRef<MotorbikeData> MotorbikePhysics { get; set; } = new();

		[ContainerField(76)]
		public CtrRef<MotionDampingData> MotionDamping { get; set; } = new();

		[ContainerField(80)]
		public VehicleInputData Input { get; set; } = new();

		[ContainerField(160)]
		public CtrRef<FloatPhysicsData> FloatPhysics { get; set; } = new();

		[ContainerField(164)]
		public CtrRef<StabilizerData> Stabilizer { get; set; } = new();

		[ContainerField(168)]
		public List<StabilizerSettings> Stabilizers { get; set; } = new();

		[ContainerField(172)]
		public List<ConstantForceData> ConstantForce { get; set; } = new();

		[ContainerField(176)]
		public VehicleMode VehicleModeAtReset { get; set; } = new();

		[ContainerField(180), LayoutImmutable, Blittable]
		public float BodyMass { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float GravityModifier { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public float YawMin { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public float YawMax { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public float DownForceBaseFactor { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public float DownForceWheelFactor { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public float VehicleModeChangeEnteringTime { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public float VehicleModeChangeStartingTime { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public float VehicleModeChangeStoppingTime { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public float VehicleModeChangeLeavingTime { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public float StandStillLowSpeedTimeLimit { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public float StaticFrictionBreakCollisionMod { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable]
		public float StaticFrictionBreakVelocityMod { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable]
		public float CoefficientOfAirFriction { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable]
		public float AirDensity { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable]
		public float AirDragArea { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable]
		public float WindResistanceBaseFactor { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable]
		public float WindResistanceVelocityFactor { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable]
		public float WindResistanceVelocityFactorMin { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable]
		public float WindResistanceVelocityFactorMax { get; set; }

		[ContainerField(260)]
		public AntiRollBars AntiRollBars { get; set; } = new();

		[ContainerField(268), LayoutImmutable, Blittable]
		public bool UseDownForceWheelFactor { get; set; }

		[ContainerField(269), LayoutImmutable, Blittable]
		public bool UseGearbox { get; set; }

		[ContainerField(270), LayoutImmutable, Blittable]
		public bool UseStandStillBrake { get; set; }

		[ContainerField(271), LayoutImmutable, Blittable]
		public bool UseStandStillSleep { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable]
		public bool UseTurnAroundForce { get; set; }

		[ContainerField(273), LayoutImmutable, Blittable]
		public bool UseMotorcycleControl { get; set; }

		[ContainerField(274), LayoutImmutable, Blittable]
		public bool InvertPitchAllowed { get; set; }

		[ContainerField(275), LayoutImmutable, Blittable]
		public bool UseWindResistance { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable]
		public bool UseDownForce { get; set; }

		public static void Deserialize(VehicleConfigData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.CenterOfMass, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.CenterOfMassHandlingOffset, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.InertiaModifier, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.AeroDynamicPhysics.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ParachutePhysics.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.MotorbikePhysics.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.MotionDamping.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.VehicleInputData.Deserialize(p_Instance.Input, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.FloatPhysics.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Stabilizer.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Stabilizers.Clear();
			(RimeReader Reader, uint Count) s_Stabilizers = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Stabilizers.Count; ++i)
			{
				var s_Value = new StabilizerSettings();
				fb.StabilizerSettings.Deserialize(s_Value, s_Stabilizers.Reader, p_Parser);
				p_Instance.Stabilizers.Add(s_Value);
			}
			
			s_Stabilizers.Reader.Dispose();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ConstantForce.Clear();
			(RimeReader Reader, uint Count) s_ConstantForce = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ConstantForce.Count; ++i)
			{
				var s_Value = new ConstantForceData();
				fb.ConstantForceData.Deserialize(s_Value, s_ConstantForce.Reader, p_Parser);
				p_Instance.ConstantForce.Add(s_Value);
			}
			
			s_ConstantForce.Reader.Dispose();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.VehicleModeAtReset = (VehicleMode) p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.BodyMass = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.GravityModifier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.YawMin = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.YawMax = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.DownForceBaseFactor = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.DownForceWheelFactor = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.VehicleModeChangeEnteringTime = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.VehicleModeChangeStartingTime = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.VehicleModeChangeStoppingTime = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.VehicleModeChangeLeavingTime = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.StandStillLowSpeedTimeLimit = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.StaticFrictionBreakCollisionMod = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.StaticFrictionBreakVelocityMod = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CoefficientOfAirFriction = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.AirDensity = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.AirDragArea = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WindResistanceBaseFactor = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WindResistanceVelocityFactor = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WindResistanceVelocityFactorMin = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WindResistanceVelocityFactorMax = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.AntiRollBars.Deserialize(p_Instance.AntiRollBars, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UseDownForceWheelFactor = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UseGearbox = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UseStandStillBrake = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UseStandStillSleep = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UseTurnAroundForce = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UseMotorcycleControl = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.InvertPitchAllowed = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UseWindResistance = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UseDownForce = p_Reader.ReadBool();
			p_Reader.Seek(19, SeekOrigin.Current);
		}

	}
}
