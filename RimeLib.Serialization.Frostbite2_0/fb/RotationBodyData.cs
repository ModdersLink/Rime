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
	[ContainerType(4, 56)]
	public class RotationBodyData :
		MovingBodyData
	{
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float AngularMomentumMultiplier { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float AngularMomentumThreshold { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float AngularMomentumDamping { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float AngularMomentumDampingAcc { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float AngularMomentumDampingDeacc { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float AngularConstraintMin { get; set; }

		[ContainerField(40), JsonProperty(Order = 40)]
		public CtrRef<ExtendedConstraintsData> ExtendedConstraints { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float AngularConstraintMax { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public int RotationAxis { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public bool UsePostSatisfyConstraints { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		public bool UseAngularMomentumThreshold { get; set; }

		[ContainerField(54), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
		public bool UseAngularMomentumDamping { get; set; }

		[ContainerField(55), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
		public bool UseAngularConstraint { get; set; }

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
