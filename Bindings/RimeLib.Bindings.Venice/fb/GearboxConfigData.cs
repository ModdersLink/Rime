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
	[ContainerType(4, 64)]
	public class GearboxConfigData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<float> ForwardGearRatios { get; set; } = new();

		[ContainerField(12)]
		public List<float> ForwardGearSpeeds { get; set; } = new();

		[ContainerField(16)]
		public List<float> ReverseGearRatios { get; set; } = new();

		[ContainerField(20)]
		public List<float> ReverseGearSpeeds { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public int GearboxType { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public int GearboxMode { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float GearChangeTime { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float GearDownSpeedFactor { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float OppositeDirGearChangeMaxSpeed { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float OppositeDirGearChangeTime { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float ClutchSpeedFactor { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float TransmissionEfficiency { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float BackwardThrottleLimit { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool UseClassicGearBoxAutoClutch { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable]
		public bool UseNeutralGear { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable]
		public bool LimitBackwardThrottle { get; set; }

		[ContainerField(63), LayoutImmutable, Blittable]
		public bool UseAutoClutch { get; set; }

		public static void Deserialize(GearboxConfigData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ForwardGearRatios.Clear();
			(RimeReader Reader, uint Count) s_ForwardGearRatios = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ForwardGearRatios.Count; ++i)
			{
				var s_Value = s_ForwardGearRatios.Reader.ReadSingle();
				p_Instance.ForwardGearRatios.Add(s_Value);
			}
			
			s_ForwardGearRatios.Reader.Dispose();
			p_Instance.ForwardGearSpeeds.Clear();
			(RimeReader Reader, uint Count) s_ForwardGearSpeeds = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ForwardGearSpeeds.Count; ++i)
			{
				var s_Value = s_ForwardGearSpeeds.Reader.ReadSingle();
				p_Instance.ForwardGearSpeeds.Add(s_Value);
			}
			
			s_ForwardGearSpeeds.Reader.Dispose();
			p_Instance.ReverseGearRatios.Clear();
			(RimeReader Reader, uint Count) s_ReverseGearRatios = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ReverseGearRatios.Count; ++i)
			{
				var s_Value = s_ReverseGearRatios.Reader.ReadSingle();
				p_Instance.ReverseGearRatios.Add(s_Value);
			}
			
			s_ReverseGearRatios.Reader.Dispose();
			p_Instance.ReverseGearSpeeds.Clear();
			(RimeReader Reader, uint Count) s_ReverseGearSpeeds = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ReverseGearSpeeds.Count; ++i)
			{
				var s_Value = s_ReverseGearSpeeds.Reader.ReadSingle();
				p_Instance.ReverseGearSpeeds.Add(s_Value);
			}
			
			s_ReverseGearSpeeds.Reader.Dispose();
			p_Instance.GearboxType = p_Reader.ReadInt32();
			p_Instance.GearboxMode = p_Reader.ReadInt32();
			p_Instance.GearChangeTime = p_Reader.ReadSingle();
			p_Instance.GearDownSpeedFactor = p_Reader.ReadSingle();
			p_Instance.OppositeDirGearChangeMaxSpeed = p_Reader.ReadSingle();
			p_Instance.OppositeDirGearChangeTime = p_Reader.ReadSingle();
			p_Instance.ClutchSpeedFactor = p_Reader.ReadSingle();
			p_Instance.TransmissionEfficiency = p_Reader.ReadSingle();
			p_Instance.BackwardThrottleLimit = p_Reader.ReadSingle();
			p_Instance.UseClassicGearBoxAutoClutch = p_Reader.ReadBool();
			p_Instance.UseNeutralGear = p_Reader.ReadBool();
			p_Instance.LimitBackwardThrottle = p_Reader.ReadBool();
			p_Instance.UseAutoClutch = p_Reader.ReadBool();
		}

	}
}
