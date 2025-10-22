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

[ContainerType(8, 48)]
public class WeaponHitProbability
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<float> DistanceToTarget { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<float> DistanceProbability { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<float> TargetVisibility { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<float> VisibleProbability { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_DistanceToTarget = p_EbxWriter.GetArrayWriter(DistanceToTarget.GetType(), DistanceToTarget.Count);
		p_Writer.Write(s_DistanceToTarget.ArrayIndex);
		foreach (var s_Entry in DistanceToTarget)
		{
			s_DistanceToTarget.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_DistanceProbability = p_EbxWriter.GetArrayWriter(DistanceProbability.GetType(), DistanceProbability.Count);
		p_Writer.Write(s_DistanceProbability.ArrayIndex);
		foreach (var s_Entry in DistanceProbability)
		{
			s_DistanceProbability.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_TargetVisibility = p_EbxWriter.GetArrayWriter(TargetVisibility.GetType(), TargetVisibility.Count);
		p_Writer.Write(s_TargetVisibility.ArrayIndex);
		foreach (var s_Entry in TargetVisibility)
		{
			s_TargetVisibility.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_VisibleProbability = p_EbxWriter.GetArrayWriter(VisibleProbability.GetType(), VisibleProbability.Count);
		p_Writer.Write(s_VisibleProbability.ArrayIndex);
		foreach (var s_Entry in VisibleProbability)
		{
			s_VisibleProbability.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
	}
}

