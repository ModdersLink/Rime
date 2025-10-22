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
using fb.GameShared;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 56)]
public class FriendlyFireEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<TeamId> Teams { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float EnemyCommitmentAllocation { get; set; } = 2.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float FriendlyCommitmentAllocation { get; set; } = -6.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float MaxCommitment { get; set; } = 10.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float FailureThreshold { get; set; } = -2.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float DecayRate { get; set; } = 0.008f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Teams = p_EbxWriter.GetArrayWriter(Teams.GetType(), Teams.Count);
		p_Writer.Write(s_Teams.ArrayIndex);
		foreach (var s_Entry in Teams)
		{
			s_Teams.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(EnemyCommitmentAllocation);
		p_Writer.Write(FriendlyCommitmentAllocation);
		p_Writer.Write(MaxCommitment);
		p_Writer.Write(FailureThreshold);
		p_Writer.Write(DecayRate);
		p_Writer.WriteNullBytes(4);
	}
}

