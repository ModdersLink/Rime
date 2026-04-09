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
	[ContainerType(4, 72)]
	public partial class WingPhysicsData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _Lift;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _FlapLift;

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<Curve2D> _LiftCoefficient = new();

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _Drag;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _FlapDrag;

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CtrRef<Curve2D> _DragCoefficient = new();

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _AngularVelocityLiftModifier;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _DragRotationModifier;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _BaseAngleOfAttack;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private int _InputForFlap;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _FlapTurnSpeed;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _VisualFlapTurnSpeed;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _VisualFlapAngleLimit;

		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private CtrRef<Curve2D> _MaxFlapAngleScaleFactor = new();

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _LandingFlapLift;

		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private CtrRef<LandingFlapData> _LandingFlapLogic = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
