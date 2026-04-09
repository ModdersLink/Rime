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
	[ContainerType(16, 240)]
	public partial class UavCameraData :
		TargetCameraData
	{
		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _ViewDistance;

		[ObservableProperty]
		[property: ContainerField(164), JsonProperty(Order = 164)]
		private List<CameraSineCurveData> _ViewDistanceCurve = new();

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _ViewAngle;

		[ObservableProperty]
		[property: ContainerField(172), JsonProperty(Order = 172)]
		private List<CameraSineCurveData> _ViewAngleCurve = new();

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _RotationSpeed;

		[ObservableProperty]
		[property: ContainerField(180), JsonProperty(Order = 180)]
		private List<CameraSineCurveData> _RotationSpeedCurve = new();

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _ZoomFov;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private float _ZoomDelay;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _ZoomTransitionTime;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private float _Fov;

		[ObservableProperty]
		[property: ContainerField(200), JsonProperty(Order = 200)]
		private UavCameraPointData _FocusPoint = new();

		[ObservableProperty]
		[property: ContainerField(216), JsonProperty(Order = 216)]
		private UavCameraPointData _CenterPoint = new();

		[ObservableProperty]
		[property: ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		private float _UpWeightDistance;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ViewDistance);
			(RimeWriter Writer, uint ArrayIndex) s_ViewDistanceCurve = p_EbxWriter.GetArrayWriter(ViewDistanceCurve.GetType(), ViewDistanceCurve.Count);
			p_Writer.Write(s_ViewDistanceCurve.ArrayIndex);
			foreach (var s_Entry in ViewDistanceCurve)
			{
				s_Entry.Serialize(s_ViewDistanceCurve.Writer, p_EbxWriter);
			}
			p_Writer.Write(ViewAngle);
			(RimeWriter Writer, uint ArrayIndex) s_ViewAngleCurve = p_EbxWriter.GetArrayWriter(ViewAngleCurve.GetType(), ViewAngleCurve.Count);
			p_Writer.Write(s_ViewAngleCurve.ArrayIndex);
			foreach (var s_Entry in ViewAngleCurve)
			{
				s_Entry.Serialize(s_ViewAngleCurve.Writer, p_EbxWriter);
			}
			p_Writer.Write(RotationSpeed);
			(RimeWriter Writer, uint ArrayIndex) s_RotationSpeedCurve = p_EbxWriter.GetArrayWriter(RotationSpeedCurve.GetType(), RotationSpeedCurve.Count);
			p_Writer.Write(s_RotationSpeedCurve.ArrayIndex);
			foreach (var s_Entry in RotationSpeedCurve)
			{
				s_Entry.Serialize(s_RotationSpeedCurve.Writer, p_EbxWriter);
			}
			p_Writer.Write(ZoomFov);
			p_Writer.Write(ZoomDelay);
			p_Writer.Write(ZoomTransitionTime);
			p_Writer.Write(Fov);
			FocusPoint.Serialize(p_Writer, p_EbxWriter);
			CenterPoint.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(UpWeightDistance);
			p_Writer.WriteNullBytes(4);
		}
	}
}
