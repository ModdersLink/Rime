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
using fb.Entity;

namespace fb.PathfindingShared;

[ContainerType(16, 144)]
public class PathFollowingComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float UpdatePathAtDistancePercent { get; set; } = 25.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public uint PreferredPathfindingIndex { get; set; } = 0;
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public List<uint> AlternatePathfindingIndices { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float MovementCorridorRadius { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(UpdatePathAtDistancePercent);
		p_Writer.Write(PreferredPathfindingIndex);
		(RimeWriter Writer, uint ArrayIndex) s_AlternatePathfindingIndices = p_EbxWriter.GetArrayWriter(AlternatePathfindingIndices.GetType(), AlternatePathfindingIndices.Count);
		p_Writer.Write(s_AlternatePathfindingIndices.ArrayIndex);
		foreach (var s_Entry in AlternatePathfindingIndices)
		{
			s_AlternatePathfindingIndices.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MovementCorridorRadius);
		p_Writer.WriteNullBytes(12);
	}
}

