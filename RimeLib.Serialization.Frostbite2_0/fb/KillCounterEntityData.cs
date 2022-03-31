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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 144)]
	public class KillCounterEntityData :
		GameEntityData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public KillWeight TeamKillWeight { get; set; } = new();

		[ContainerField(108), JsonProperty(Order = 108)]
		public TeamId TeamId { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public KillWeight NeutralTeamWeight { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float EnemyWeight { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public uint MaxKillCount { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public bool IgnoreAI { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			TeamKillWeight.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) TeamId);
			NeutralTeamWeight.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(EnemyWeight);
			p_Writer.Write(MaxKillCount);
			p_Writer.Write(IgnoreAI);
			p_Writer.WriteNullBytes(11);
		}
	}
}
