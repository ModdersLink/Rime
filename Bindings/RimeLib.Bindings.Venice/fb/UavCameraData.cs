///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 240)]
	public class UavCameraData : 
		TargetCameraData
	{
		[ContainerField(160), LayoutImmutable, Blittable]
		public float ViewDistance { get; set; }

		[ContainerField(164)]
		public List<CameraSineCurveData> ViewDistanceCurve { get; set; } = new();

		[ContainerField(168), LayoutImmutable, Blittable]
		public float ViewAngle { get; set; }

		[ContainerField(172)]
		public List<CameraSineCurveData> ViewAngleCurve { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable]
		public float RotationSpeed { get; set; }

		[ContainerField(180)]
		public List<CameraSineCurveData> RotationSpeedCurve { get; set; } = new();

		[ContainerField(184), LayoutImmutable, Blittable]
		public float ZoomFov { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public float ZoomDelay { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public float ZoomTransitionTime { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public float Fov { get; set; }

		[ContainerField(200)]
		public UavCameraPointData FocusPoint { get; set; } = new();

		[ContainerField(216)]
		public UavCameraPointData CenterPoint { get; set; } = new();

		[ContainerField(232), LayoutImmutable, Blittable]
		public float UpWeightDistance { get; set; }

		public static void Deserialize(UavCameraData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ViewDistance = p_Reader.ReadSingle();
			p_Instance.ViewDistanceCurve.Clear();
			(RimeReader Reader, uint Count) s_ViewDistanceCurve = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ViewDistanceCurve.Count; ++i)
			{
				var s_Value = new CameraSineCurveData();
				fb.CameraSineCurveData.Deserialize(s_Value, s_ViewDistanceCurve.Reader, p_Parser);
				p_Instance.ViewDistanceCurve.Add(s_Value);
			}
			
			s_ViewDistanceCurve.Reader.Dispose();
			p_Instance.ViewAngle = p_Reader.ReadSingle();
			p_Instance.ViewAngleCurve.Clear();
			(RimeReader Reader, uint Count) s_ViewAngleCurve = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ViewAngleCurve.Count; ++i)
			{
				var s_Value = new CameraSineCurveData();
				fb.CameraSineCurveData.Deserialize(s_Value, s_ViewAngleCurve.Reader, p_Parser);
				p_Instance.ViewAngleCurve.Add(s_Value);
			}
			
			s_ViewAngleCurve.Reader.Dispose();
			p_Instance.RotationSpeed = p_Reader.ReadSingle();
			p_Instance.RotationSpeedCurve.Clear();
			(RimeReader Reader, uint Count) s_RotationSpeedCurve = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_RotationSpeedCurve.Count; ++i)
			{
				var s_Value = new CameraSineCurveData();
				fb.CameraSineCurveData.Deserialize(s_Value, s_RotationSpeedCurve.Reader, p_Parser);
				p_Instance.RotationSpeedCurve.Add(s_Value);
			}
			
			s_RotationSpeedCurve.Reader.Dispose();
			p_Instance.ZoomFov = p_Reader.ReadSingle();
			p_Instance.ZoomDelay = p_Reader.ReadSingle();
			p_Instance.ZoomTransitionTime = p_Reader.ReadSingle();
			p_Instance.Fov = p_Reader.ReadSingle();
			fb.UavCameraPointData.Deserialize(p_Instance.FocusPoint, p_Reader, p_Parser);
			fb.UavCameraPointData.Deserialize(p_Instance.CenterPoint, p_Reader, p_Parser);
			p_Instance.UpWeightDistance = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
