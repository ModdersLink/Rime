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
	[ContainerType(16, 240)]
	public class UavCameraData :
		TargetCameraData
	{
		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float ViewDistance { get; set; }

		[ContainerField(164), JsonProperty(Order = 164)]
		public List<CameraSineCurveData> ViewDistanceCurve { get; set; } = new();

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float ViewAngle { get; set; }

		[ContainerField(172), JsonProperty(Order = 172)]
		public List<CameraSineCurveData> ViewAngleCurve { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float RotationSpeed { get; set; }

		[ContainerField(180), JsonProperty(Order = 180)]
		public List<CameraSineCurveData> RotationSpeedCurve { get; set; } = new();

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float ZoomFov { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public float ZoomDelay { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float ZoomTransitionTime { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public float Fov { get; set; }

		[ContainerField(200), JsonProperty(Order = 200)]
		public UavCameraPointData FocusPoint { get; set; } = new();

		[ContainerField(216), JsonProperty(Order = 216)]
		public UavCameraPointData CenterPoint { get; set; } = new();

		[ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		public float UpWeightDistance { get; set; }

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
