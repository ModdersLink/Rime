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
	public class StaticCameraData : 
		TargetCameraData
	{
		[ContainerField(160)]
		public List<Vec3> LeftCurve { get; set; } = new();

		[ContainerField(164)]
		public List<Vec3> RightCurve { get; set; } = new();

		[ContainerField(168)]
		public List<Vec3> UpCurve { get; set; } = new();

		[ContainerField(172)]
		public List<Vec3> DownCurve { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable]
		public float UpPitchAngle { get; set; }

		[ContainerField(180)]
		public EntryInputActionEnum YawInputAction { get; set; } = new();

		[ContainerField(184)]
		public List<CtrRef<CameraLoosePartPhysicsData>> LoosePartPhysics { get; set; } = new();

		[ContainerField(188), LayoutImmutable, Blittable]
		public float LeftYawAngle { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public float RightYawAngle { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public float PitchSensitivityZoomed { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public float DownPitchAngle { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public int AverageFilterFrames { get; set; }

		[ContainerField(208)]
		public EntryInputActionEnum PitchInputAction { get; set; } = new();

		[ContainerField(212), LayoutImmutable, Blittable]
		public float YawSensitivityZoomed { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public float PitchSensitivityNonZoomed { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public float YawSensitivityNonZoomed { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public bool ResetAccumulatedInputOnViewChange { get; set; }

		[ContainerField(225), LayoutImmutable, Blittable]
		public bool MirrorHorizontalCurves { get; set; }

		[ContainerField(226), LayoutImmutable, Blittable]
		public bool AccumulateInput { get; set; }

		[ContainerField(227), LayoutImmutable, Blittable]
		public bool MirrorVerticalCurves { get; set; }

		public static void Deserialize(StaticCameraData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.LeftCurve.Clear();
			(RimeReader Reader, uint Count) s_LeftCurve = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LeftCurve.Count; ++i)
			{
				var s_Value = new Vec3();
				fb.Vec3.Deserialize(s_Value, s_LeftCurve.Reader, p_Parser);
				p_Instance.LeftCurve.Add(s_Value);
			}
			
			s_LeftCurve.Reader.Dispose();
			p_Instance.RightCurve.Clear();
			(RimeReader Reader, uint Count) s_RightCurve = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_RightCurve.Count; ++i)
			{
				var s_Value = new Vec3();
				fb.Vec3.Deserialize(s_Value, s_RightCurve.Reader, p_Parser);
				p_Instance.RightCurve.Add(s_Value);
			}
			
			s_RightCurve.Reader.Dispose();
			p_Instance.UpCurve.Clear();
			(RimeReader Reader, uint Count) s_UpCurve = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UpCurve.Count; ++i)
			{
				var s_Value = new Vec3();
				fb.Vec3.Deserialize(s_Value, s_UpCurve.Reader, p_Parser);
				p_Instance.UpCurve.Add(s_Value);
			}
			
			s_UpCurve.Reader.Dispose();
			p_Instance.DownCurve.Clear();
			(RimeReader Reader, uint Count) s_DownCurve = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_DownCurve.Count; ++i)
			{
				var s_Value = new Vec3();
				fb.Vec3.Deserialize(s_Value, s_DownCurve.Reader, p_Parser);
				p_Instance.DownCurve.Add(s_Value);
			}
			
			s_DownCurve.Reader.Dispose();
			p_Instance.UpPitchAngle = p_Reader.ReadSingle();
			p_Instance.YawInputAction = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.LoosePartPhysics.Clear();
			(RimeReader Reader, uint Count) s_LoosePartPhysics = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LoosePartPhysics.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CameraLoosePartPhysicsData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_LoosePartPhysics.Reader.ReadUInt32()));
				p_Instance.LoosePartPhysics.Add(s_CtrRef);
			}
			
			s_LoosePartPhysics.Reader.Dispose();
			p_Instance.LeftYawAngle = p_Reader.ReadSingle();
			p_Instance.RightYawAngle = p_Reader.ReadSingle();
			p_Instance.PitchSensitivityZoomed = p_Reader.ReadSingle();
			p_Instance.DownPitchAngle = p_Reader.ReadSingle();
			p_Instance.AverageFilterFrames = p_Reader.ReadInt32();
			p_Instance.PitchInputAction = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.YawSensitivityZoomed = p_Reader.ReadSingle();
			p_Instance.PitchSensitivityNonZoomed = p_Reader.ReadSingle();
			p_Instance.YawSensitivityNonZoomed = p_Reader.ReadSingle();
			p_Instance.ResetAccumulatedInputOnViewChange = p_Reader.ReadBool();
			p_Instance.MirrorHorizontalCurves = p_Reader.ReadBool();
			p_Instance.AccumulateInput = p_Reader.ReadBool();
			p_Instance.MirrorVerticalCurves = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
