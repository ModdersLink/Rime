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
	[ContainerType(4, 36)]
	public class FriendlyFireEntityData :
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<TeamId> Teams { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float EnemyCommitmentAllocation { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float FriendlyCommitmentAllocation { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float MaxCommitment { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float FailureThreshold { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float DecayRate { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Teams = p_EbxWriter.GetArrayWriter(Teams.GetType(), Teams.Count);
			p_Writer.Write(s_Teams.ArrayIndex);
			foreach (var s_Entry in Teams)
			{
				s_Teams.Writer.Write((int) s_Entry);
			}
			p_Writer.Write(EnemyCommitmentAllocation);
			p_Writer.Write(FriendlyCommitmentAllocation);
			p_Writer.Write(MaxCommitment);
			p_Writer.Write(FailureThreshold);
			p_Writer.Write(DecayRate);
		}
	}
}
