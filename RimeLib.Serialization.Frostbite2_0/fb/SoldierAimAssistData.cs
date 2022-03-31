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

namespace fb
{
	[ContainerType(16, 192)]
	public class SoldierAimAssistData :
		GameDataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 EyePosOffset { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 StickyBoxScale { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 SnapDistanceScale { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public Vec3 SnapBoxScale { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public Vec3 StickyDistanceScale { get; set; } = new();

		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec2 MaxAcceleration { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float AccelerationDamping { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float AccelerationInputThreshold { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float AccelerationMultiplier { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float SquaredAcceleration { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float YawSpeedStrength { get; set; }

		[ContainerField(124), JsonProperty(Order = 124)]
		public List<float> ZoomedInputPolynomial { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float AccelerationTimeThreshold { get; set; }

		[ContainerField(132), JsonProperty(Order = 132)]
		public List<float> AttractDistanceFallOff { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float AttractUserInputMultiplier { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float AttractOwnSpeedInfluence { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float AttractTargetSpeedInfluence { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float AttractOwnRequiredMovementForMaximumAttract { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float AttractStartInputThreshold { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float AttractZoomingMultiplier { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float AttractZoomingPostTime { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float AttractYawStrength { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float AttractPitchStrength { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public float PitchSpeedStrength { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float AttractSoftZone { get; set; }

		[ContainerField(180), JsonProperty(Order = 180)]
		public List<float> InputPolynomial { get; set; } = new();

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public bool UseYawAcceleration { get; set; }

		[ContainerField(185), LayoutImmutable, Blittable, JsonProperty(Order = 185)]
		public bool UsePitchAcceleration { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			EyePosOffset.Serialize(p_Writer, p_EbxWriter);
			StickyBoxScale.Serialize(p_Writer, p_EbxWriter);
			SnapDistanceScale.Serialize(p_Writer, p_EbxWriter);
			SnapBoxScale.Serialize(p_Writer, p_EbxWriter);
			StickyDistanceScale.Serialize(p_Writer, p_EbxWriter);
			MaxAcceleration.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AccelerationDamping);
			p_Writer.Write(AccelerationInputThreshold);
			p_Writer.Write(AccelerationMultiplier);
			p_Writer.Write(SquaredAcceleration);
			p_Writer.Write(YawSpeedStrength);
			(RimeWriter Writer, uint ArrayIndex) s_ZoomedInputPolynomial = p_EbxWriter.GetArrayWriter(ZoomedInputPolynomial.GetType(), ZoomedInputPolynomial.Count);
			p_Writer.Write(s_ZoomedInputPolynomial.ArrayIndex);
			foreach (var s_Entry in ZoomedInputPolynomial)
			{
				s_ZoomedInputPolynomial.Writer.Write(s_Entry);
			}
			p_Writer.Write(AccelerationTimeThreshold);
			(RimeWriter Writer, uint ArrayIndex) s_AttractDistanceFallOff = p_EbxWriter.GetArrayWriter(AttractDistanceFallOff.GetType(), AttractDistanceFallOff.Count);
			p_Writer.Write(s_AttractDistanceFallOff.ArrayIndex);
			foreach (var s_Entry in AttractDistanceFallOff)
			{
				s_AttractDistanceFallOff.Writer.Write(s_Entry);
			}
			p_Writer.Write(AttractUserInputMultiplier);
			p_Writer.Write(AttractOwnSpeedInfluence);
			p_Writer.Write(AttractTargetSpeedInfluence);
			p_Writer.Write(AttractOwnRequiredMovementForMaximumAttract);
			p_Writer.Write(AttractStartInputThreshold);
			p_Writer.Write(AttractZoomingMultiplier);
			p_Writer.Write(AttractZoomingPostTime);
			p_Writer.Write(AttractYawStrength);
			p_Writer.Write(AttractPitchStrength);
			p_Writer.Write(PitchSpeedStrength);
			p_Writer.Write(AttractSoftZone);
			(RimeWriter Writer, uint ArrayIndex) s_InputPolynomial = p_EbxWriter.GetArrayWriter(InputPolynomial.GetType(), InputPolynomial.Count);
			p_Writer.Write(s_InputPolynomial.ArrayIndex);
			foreach (var s_Entry in InputPolynomial)
			{
				s_InputPolynomial.Writer.Write(s_Entry);
			}
			p_Writer.Write(UseYawAcceleration);
			p_Writer.Write(UsePitchAcceleration);
			p_Writer.WriteNullBytes(6);
		}
	}
}
