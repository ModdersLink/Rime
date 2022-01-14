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
	[ContainerType(16, 96)]
	public class EngineConfigData :
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 Position { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public List<float> RpmCurvePoints { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public List<float> TorqueCurvePoints { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float RpmMin { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float RpmMax { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float RpmCut { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float EnginePowerMultiplier { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float InternalAccelerationFactor { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float InternalDeaccelerationFactor { get; set; }

		[ContainerField(64), JsonProperty(Order = 64)]
		public Boost Boost { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
