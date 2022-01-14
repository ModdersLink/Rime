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
	[ContainerType(4, 72)]
	public class WingPhysicsData :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float Lift { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float FlapLift { get; set; }

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<Curve2D> LiftCoefficient { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float Drag { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float FlapDrag { get; set; }

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<Curve2D> DragCoefficient { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float AngularVelocityLiftModifier { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float DragRotationModifier { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float BaseAngleOfAttack { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public int InputForFlap { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float FlapTurnSpeed { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float VisualFlapTurnSpeed { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float VisualFlapAngleLimit { get; set; }

		[ContainerField(60), JsonProperty(Order = 60)]
		public CtrRef<Curve2D> MaxFlapAngleScaleFactor { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float LandingFlapLift { get; set; }

		[ContainerField(68), JsonProperty(Order = 68)]
		public CtrRef<LandingFlapData> LandingFlapLogic { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Lift);
			p_Writer.Write(FlapLift);
			p_Writer.Write(p_EbxWriter.WriteImport(LiftCoefficient));
			p_Writer.Write(Drag);
			p_Writer.Write(FlapDrag);
			p_Writer.Write(p_EbxWriter.WriteImport(DragCoefficient));
			p_Writer.Write(AngularVelocityLiftModifier);
			p_Writer.Write(DragRotationModifier);
			p_Writer.Write(BaseAngleOfAttack);
			p_Writer.Write(InputForFlap);
			p_Writer.Write(FlapTurnSpeed);
			p_Writer.Write(VisualFlapTurnSpeed);
			p_Writer.Write(VisualFlapAngleLimit);
			p_Writer.Write(p_EbxWriter.WriteImport(MaxFlapAngleScaleFactor));
			p_Writer.Write(LandingFlapLift);
			p_Writer.Write(p_EbxWriter.WriteImport(LandingFlapLogic));
		}
	}
}
