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
	[ContainerType(16, 96)]
	public class EngineConfigData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get; set; } = new();

		[ContainerField(32)]
		public List<float> RpmCurvePoints { get; set; } = new();

		[ContainerField(36)]
		public List<float> TorqueCurvePoints { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable]
		public float RpmMin { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float RpmMax { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float RpmCut { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float EnginePowerMultiplier { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float InternalAccelerationFactor { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float InternalDeaccelerationFactor { get; set; }

		[ContainerField(64)]
		public Boost Boost { get; set; } = new();

		public static void Deserialize(EngineConfigData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.Position, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.RpmCurvePoints.Clear();
			(RimeReader Reader, uint Count) s_RpmCurvePoints = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_RpmCurvePoints.Count; ++i)
			{
				var s_Value = s_RpmCurvePoints.Reader.ReadSingle();
				p_Instance.RpmCurvePoints.Add(s_Value);
			}
			
			s_RpmCurvePoints.Reader.Dispose();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.TorqueCurvePoints.Clear();
			(RimeReader Reader, uint Count) s_TorqueCurvePoints = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TorqueCurvePoints.Count; ++i)
			{
				var s_Value = s_TorqueCurvePoints.Reader.ReadSingle();
				p_Instance.TorqueCurvePoints.Add(s_Value);
			}
			
			s_TorqueCurvePoints.Reader.Dispose();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.RpmMin = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.RpmMax = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.RpmCut = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.EnginePowerMultiplier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.InternalAccelerationFactor = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.InternalDeaccelerationFactor = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Boost.Deserialize(p_Instance.Boost, p_Reader, p_Parser);
			p_Reader.Seek(16, SeekOrigin.Current);
		}

	}
}
