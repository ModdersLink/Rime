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
	[ContainerType(4, 56)]
	public partial class RotationBodyData :
		MovingBodyData
	{
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _AngularMomentumMultiplier;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _AngularMomentumThreshold;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _AngularMomentumDamping;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _AngularMomentumDampingAcc;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _AngularMomentumDampingDeacc;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _AngularConstraintMin;

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private CtrRef<ExtendedConstraintsData> _ExtendedConstraints = new();

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _AngularConstraintMax;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private int _RotationAxis;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private bool _UsePostSatisfyConstraints;

		[ObservableProperty]
		[property: ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		private bool _UseAngularMomentumThreshold;

		[ObservableProperty]
		[property: ContainerField(54), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
		private bool _UseAngularMomentumDamping;

		[ObservableProperty]
		[property: ContainerField(55), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
		private bool _UseAngularConstraint;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AngularMomentumMultiplier);
			p_Writer.Write(AngularMomentumThreshold);
			p_Writer.Write(AngularMomentumDamping);
			p_Writer.Write(AngularMomentumDampingAcc);
			p_Writer.Write(AngularMomentumDampingDeacc);
			p_Writer.Write(AngularConstraintMin);
			p_Writer.Write(p_EbxWriter.WriteImport(ExtendedConstraints));
			p_Writer.Write(AngularConstraintMax);
			p_Writer.Write(RotationAxis);
			p_Writer.Write(UsePostSatisfyConstraints);
			p_Writer.Write(UseAngularMomentumThreshold);
			p_Writer.Write(UseAngularMomentumDamping);
			p_Writer.Write(UseAngularConstraint);
		}
	}
}
