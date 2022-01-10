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
	[ContainerType(4, 152)]
	public class DriverSettings : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MinRadius { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float RadiusGrowthSpeed { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float StoppingDeceleration { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float SteeringSensitivity { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxBrakeOutput { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float MaxDec { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float LookAheadTime { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float AngleDiffForNoSlowdown { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float AngleDiffForFullSlowdown { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float VelocityAtFullSlowdown { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float VelDiffAtMinAcc { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float VelDiffAtMaxAcc { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float MaxYawToApplySprint { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float MinAcc { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float MaxAcc { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float VelDiffAtMinDec { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float VelDiffAtMaxDec { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float AccDiffAtMinThrottleVelocityDecelerating { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float MinDec { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float MinThrottleVelocityDecelerating { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float AccDiffAtMinThrottleVelocityAccelerating { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float AccDiffAtMaxThrottleVelocityAccelerating { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float MaxThrottleVelocityDecelerating { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float MinThrottleVelocityAccelerating { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float MaxThrottleVelocityAccelerating { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float MaxPTerm { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float AccDiffAtMaxThrottleVelocityDecelerating { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float P { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float I { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float MaxError { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float MaxITerm { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float MaxSumError { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float D { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public bool UseSquareVelDiffCurveDec { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable]
		public bool UseSquareAccDiffCurveDec { get; set; }

		[ContainerField(146), LayoutImmutable, Blittable]
		public bool SquareBrakeOutput { get; set; }

		[ContainerField(147), LayoutImmutable, Blittable]
		public bool UseSquareVelDiffCurveAcc { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public bool UsePIDRegulator { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable]
		public bool UseSquareAccDiffCurveAcc { get; set; }

		public static void Deserialize(DriverSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MinRadius = p_Reader.ReadSingle();
			p_Instance.RadiusGrowthSpeed = p_Reader.ReadSingle();
			p_Instance.StoppingDeceleration = p_Reader.ReadSingle();
			p_Instance.SteeringSensitivity = p_Reader.ReadSingle();
			p_Instance.MaxBrakeOutput = p_Reader.ReadSingle();
			p_Instance.MaxDec = p_Reader.ReadSingle();
			p_Instance.LookAheadTime = p_Reader.ReadSingle();
			p_Instance.AngleDiffForNoSlowdown = p_Reader.ReadSingle();
			p_Instance.AngleDiffForFullSlowdown = p_Reader.ReadSingle();
			p_Instance.VelocityAtFullSlowdown = p_Reader.ReadSingle();
			p_Instance.VelDiffAtMinAcc = p_Reader.ReadSingle();
			p_Instance.VelDiffAtMaxAcc = p_Reader.ReadSingle();
			p_Instance.MaxYawToApplySprint = p_Reader.ReadSingle();
			p_Instance.MinAcc = p_Reader.ReadSingle();
			p_Instance.MaxAcc = p_Reader.ReadSingle();
			p_Instance.VelDiffAtMinDec = p_Reader.ReadSingle();
			p_Instance.VelDiffAtMaxDec = p_Reader.ReadSingle();
			p_Instance.AccDiffAtMinThrottleVelocityDecelerating = p_Reader.ReadSingle();
			p_Instance.MinDec = p_Reader.ReadSingle();
			p_Instance.MinThrottleVelocityDecelerating = p_Reader.ReadSingle();
			p_Instance.AccDiffAtMinThrottleVelocityAccelerating = p_Reader.ReadSingle();
			p_Instance.AccDiffAtMaxThrottleVelocityAccelerating = p_Reader.ReadSingle();
			p_Instance.MaxThrottleVelocityDecelerating = p_Reader.ReadSingle();
			p_Instance.MinThrottleVelocityAccelerating = p_Reader.ReadSingle();
			p_Instance.MaxThrottleVelocityAccelerating = p_Reader.ReadSingle();
			p_Instance.MaxPTerm = p_Reader.ReadSingle();
			p_Instance.AccDiffAtMaxThrottleVelocityDecelerating = p_Reader.ReadSingle();
			p_Instance.P = p_Reader.ReadSingle();
			p_Instance.I = p_Reader.ReadSingle();
			p_Instance.MaxError = p_Reader.ReadSingle();
			p_Instance.MaxITerm = p_Reader.ReadSingle();
			p_Instance.MaxSumError = p_Reader.ReadSingle();
			p_Instance.D = p_Reader.ReadSingle();
			p_Instance.UseSquareVelDiffCurveDec = p_Reader.ReadBool();
			p_Instance.UseSquareAccDiffCurveDec = p_Reader.ReadBool();
			p_Instance.SquareBrakeOutput = p_Reader.ReadBool();
			p_Instance.UseSquareVelDiffCurveAcc = p_Reader.ReadBool();
			p_Instance.UsePIDRegulator = p_Reader.ReadBool();
			p_Instance.UseSquareAccDiffCurveAcc = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
