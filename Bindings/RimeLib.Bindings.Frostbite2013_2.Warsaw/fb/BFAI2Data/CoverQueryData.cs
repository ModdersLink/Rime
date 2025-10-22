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

[ContainerType(8, 104)]
public class CoverQueryData
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float LineOfFireScore { get; set; } = 0.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float MaxTargetDistanceForRejectedByLineOfFire { get; set; } = 3.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float NavigationScore { get; set; } = 0.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float PathfindingScore { get; set; } = 0.000f;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<float> DistanceToTarget { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<float> PathfindingThresholds { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float DefaultPathfindingThreshold { get; set; } = 1.500f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float PathfindingLowerLimit { get; set; } = 10.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float MaxRejectedTime { get; set; } = 15.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public int MinCountForSecondaryFilter { get; set; } = 5;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<CoverQuerySpatialBase> SpatialFilter { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<CoverQuerySpatialBase> SecondarySpatialFilter { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public RefArray<CoverQueryScoreBase> Scores { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public List<CoverQueryScoreRuntime> RuntimeScores { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LineOfFireScore);
		p_Writer.Write(MaxTargetDistanceForRejectedByLineOfFire);
		p_Writer.Write(NavigationScore);
		p_Writer.Write(PathfindingScore);
		(RimeWriter Writer, uint ArrayIndex) s_DistanceToTarget = p_EbxWriter.GetArrayWriter(DistanceToTarget.GetType(), DistanceToTarget.Count);
		p_Writer.Write(s_DistanceToTarget.ArrayIndex);
		foreach (var s_Entry in DistanceToTarget)
		{
			s_DistanceToTarget.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PathfindingThresholds = p_EbxWriter.GetArrayWriter(PathfindingThresholds.GetType(), PathfindingThresholds.Count);
		p_Writer.Write(s_PathfindingThresholds.ArrayIndex);
		foreach (var s_Entry in PathfindingThresholds)
		{
			s_PathfindingThresholds.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DefaultPathfindingThreshold);
		p_Writer.Write(PathfindingLowerLimit);
		p_Writer.Write(MaxRejectedTime);
		p_Writer.Write(MinCountForSecondaryFilter);
		p_Writer.Write(p_EbxWriter.WriteImport(SpatialFilter));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SecondarySpatialFilter));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Scores = p_EbxWriter.GetArrayWriter(Scores.GetType(), Scores.Count);
		p_Writer.Write(s_Scores.ArrayIndex);
		foreach (var s_Entry in Scores)
		{
			s_Scores.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_RuntimeScores = p_EbxWriter.GetArrayWriter(RuntimeScores.GetType(), RuntimeScores.Count);
		p_Writer.Write(s_RuntimeScores.ArrayIndex);
		foreach (var s_Entry in RuntimeScores)
		{
			s_Entry.Serialize(s_RuntimeScores.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

