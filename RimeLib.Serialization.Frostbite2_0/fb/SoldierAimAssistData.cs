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
	[ContainerType(16, 192)]
	public partial class SoldierAimAssistData :
		GameDataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _EyePosOffset = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _StickyBoxScale = new();

		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec3 _SnapDistanceScale = new();

		[ObservableProperty]
		[property: ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private Vec3 _SnapBoxScale = new();

		[ObservableProperty]
		[property: ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private Vec3 _StickyDistanceScale = new();

		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec2 _MaxAcceleration = new();

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _AccelerationDamping;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _AccelerationInputThreshold;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _AccelerationMultiplier;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _SquaredAcceleration;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _YawSpeedStrength;

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private List<float> _ZoomedInputPolynomial = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _AccelerationTimeThreshold;

		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private List<float> _AttractDistanceFallOff = new();

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _AttractUserInputMultiplier;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _AttractOwnSpeedInfluence;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _AttractTargetSpeedInfluence;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _AttractOwnRequiredMovementForMaximumAttract;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _AttractStartInputThreshold;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _AttractZoomingMultiplier;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _AttractZoomingPostTime;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _AttractYawStrength;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _AttractPitchStrength;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private float _PitchSpeedStrength;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _AttractSoftZone;

		[ObservableProperty]
		[property: ContainerField(180), JsonProperty(Order = 180)]
		private List<float> _InputPolynomial = new();

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private bool _UseYawAcceleration;

		[ObservableProperty]
		[property: ContainerField(185), LayoutImmutable, Blittable, JsonProperty(Order = 185)]
		private bool _UsePitchAcceleration;

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
