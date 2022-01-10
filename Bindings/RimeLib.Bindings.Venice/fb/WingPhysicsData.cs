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
	[ContainerType(4, 72)]
	public class WingPhysicsData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Lift { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float FlapLift { get; set; }

		[ContainerField(16)]
		public CtrRef<Curve2D> LiftCoefficient { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Drag { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float FlapDrag { get; set; }

		[ContainerField(28)]
		public CtrRef<Curve2D> DragCoefficient { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float AngularVelocityLiftModifier { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float DragRotationModifier { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float BaseAngleOfAttack { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public int InputForFlap { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float FlapTurnSpeed { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float VisualFlapTurnSpeed { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float VisualFlapAngleLimit { get; set; }

		[ContainerField(60)]
		public CtrRef<Curve2D> MaxFlapAngleScaleFactor { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable]
		public float LandingFlapLift { get; set; }

		[ContainerField(68)]
		public CtrRef<LandingFlapData> LandingFlapLogic { get; set; } = new();

		public static void Deserialize(WingPhysicsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Lift = p_Reader.ReadSingle();
			p_Instance.FlapLift = p_Reader.ReadSingle();
			p_Instance.LiftCoefficient.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Drag = p_Reader.ReadSingle();
			p_Instance.FlapDrag = p_Reader.ReadSingle();
			p_Instance.DragCoefficient.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AngularVelocityLiftModifier = p_Reader.ReadSingle();
			p_Instance.DragRotationModifier = p_Reader.ReadSingle();
			p_Instance.BaseAngleOfAttack = p_Reader.ReadSingle();
			p_Instance.InputForFlap = p_Reader.ReadInt32();
			p_Instance.FlapTurnSpeed = p_Reader.ReadSingle();
			p_Instance.VisualFlapTurnSpeed = p_Reader.ReadSingle();
			p_Instance.VisualFlapAngleLimit = p_Reader.ReadSingle();
			p_Instance.MaxFlapAngleScaleFactor.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.LandingFlapLift = p_Reader.ReadSingle();
			p_Instance.LandingFlapLogic.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
