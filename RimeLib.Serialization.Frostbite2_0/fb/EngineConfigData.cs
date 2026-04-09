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
	[ContainerType(16, 96)]
	public partial class EngineConfigData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _Position = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private List<float> _RpmCurvePoints = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private List<float> _TorqueCurvePoints = new();

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _RpmMin;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _RpmMax;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _RpmCut;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _EnginePowerMultiplier;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _InternalAccelerationFactor;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _InternalDeaccelerationFactor;

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private Boost _Boost = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
			Position.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_RpmCurvePoints = p_EbxWriter.GetArrayWriter(RpmCurvePoints.GetType(), RpmCurvePoints.Count);
			p_Writer.Write(s_RpmCurvePoints.ArrayIndex);
			foreach (var s_Entry in RpmCurvePoints)
			{
				s_RpmCurvePoints.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_TorqueCurvePoints = p_EbxWriter.GetArrayWriter(TorqueCurvePoints.GetType(), TorqueCurvePoints.Count);
			p_Writer.Write(s_TorqueCurvePoints.ArrayIndex);
			foreach (var s_Entry in TorqueCurvePoints)
			{
				s_TorqueCurvePoints.Writer.Write(s_Entry);
			}
			p_Writer.Write(RpmMin);
			p_Writer.Write(RpmMax);
			p_Writer.Write(RpmCut);
			p_Writer.Write(EnginePowerMultiplier);
			p_Writer.Write(InternalAccelerationFactor);
			p_Writer.Write(InternalDeaccelerationFactor);
			Boost.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
		}
	}
}
