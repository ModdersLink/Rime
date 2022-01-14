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
	[ContainerType(16, 128)]
	public class FakeHingeData :
		FakePhysicsData
	{
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 Pivot { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public Vec3 RotationAxis { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public Vec3 ExtensionAxis { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float MinAngle { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float MaxAngle { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float AngularDampening { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float PullbackAcceleration { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float ProgressiveExponent { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float InertiaModifier { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			Pivot.Serialize(p_Writer, p_EbxWriter);
			RotationAxis.Serialize(p_Writer, p_EbxWriter);
			ExtensionAxis.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MinAngle);
			p_Writer.Write(MaxAngle);
			p_Writer.Write(AngularDampening);
			p_Writer.Write(PullbackAcceleration);
			p_Writer.Write(ProgressiveExponent);
			p_Writer.Write(InertiaModifier);
			p_Writer.WriteNullBytes(8);
		}
	}
}
