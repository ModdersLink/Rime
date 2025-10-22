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

using fb.Core;

namespace fb.BFAI2Data;

[ContainerType(8, 40)]
public class CoverControlSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<float> FiringTimes { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<float> IdleTimes { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float SuppressionThreshold { get; set; } = 0.250f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool AllowSuppression { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_FiringTimes = p_EbxWriter.GetArrayWriter(FiringTimes.GetType(), FiringTimes.Count);
		p_Writer.Write(s_FiringTimes.ArrayIndex);
		foreach (var s_Entry in FiringTimes)
		{
			s_FiringTimes.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_IdleTimes = p_EbxWriter.GetArrayWriter(IdleTimes.GetType(), IdleTimes.Count);
		p_Writer.Write(s_IdleTimes.ArrayIndex);
		foreach (var s_Entry in IdleTimes)
		{
			s_IdleTimes.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SuppressionThreshold);
		p_Writer.Write(AllowSuppression);
		p_Writer.WriteNullBytes(3);
	}
}

