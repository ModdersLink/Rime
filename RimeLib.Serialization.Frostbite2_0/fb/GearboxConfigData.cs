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
	[ContainerType(4, 64)]
	public class GearboxConfigData :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<float> ForwardGearRatios { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public List<float> ForwardGearSpeeds { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<float> ReverseGearRatios { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public List<float> ReverseGearSpeeds { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int GearboxType { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public int GearboxMode { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float GearChangeTime { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float GearDownSpeedFactor { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float OppositeDirGearChangeMaxSpeed { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float OppositeDirGearChangeTime { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float ClutchSpeedFactor { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float TransmissionEfficiency { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float BackwardThrottleLimit { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public bool UseClassicGearBoxAutoClutch { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		public bool UseNeutralGear { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		public bool LimitBackwardThrottle { get; set; }

		[ContainerField(63), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
		public bool UseAutoClutch { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_ForwardGearRatios = p_EbxWriter.GetArrayWriter(ForwardGearRatios.GetType(), ForwardGearRatios.Count);
			p_Writer.Write(s_ForwardGearRatios.ArrayIndex);
			foreach (var s_Entry in ForwardGearRatios)
			{
				s_ForwardGearRatios.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ForwardGearSpeeds = p_EbxWriter.GetArrayWriter(ForwardGearSpeeds.GetType(), ForwardGearSpeeds.Count);
			p_Writer.Write(s_ForwardGearSpeeds.ArrayIndex);
			foreach (var s_Entry in ForwardGearSpeeds)
			{
				s_ForwardGearSpeeds.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ReverseGearRatios = p_EbxWriter.GetArrayWriter(ReverseGearRatios.GetType(), ReverseGearRatios.Count);
			p_Writer.Write(s_ReverseGearRatios.ArrayIndex);
			foreach (var s_Entry in ReverseGearRatios)
			{
				s_ReverseGearRatios.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ReverseGearSpeeds = p_EbxWriter.GetArrayWriter(ReverseGearSpeeds.GetType(), ReverseGearSpeeds.Count);
			p_Writer.Write(s_ReverseGearSpeeds.ArrayIndex);
			foreach (var s_Entry in ReverseGearSpeeds)
			{
				s_ReverseGearSpeeds.Writer.Write(s_Entry);
			}
			p_Writer.Write(GearboxType);
			p_Writer.Write(GearboxMode);
			p_Writer.Write(GearChangeTime);
			p_Writer.Write(GearDownSpeedFactor);
			p_Writer.Write(OppositeDirGearChangeMaxSpeed);
			p_Writer.Write(OppositeDirGearChangeTime);
			p_Writer.Write(ClutchSpeedFactor);
			p_Writer.Write(TransmissionEfficiency);
			p_Writer.Write(BackwardThrottleLimit);
			p_Writer.Write(UseClassicGearBoxAutoClutch);
			p_Writer.Write(UseNeutralGear);
			p_Writer.Write(LimitBackwardThrottle);
			p_Writer.Write(UseAutoClutch);
		}
	}
}
