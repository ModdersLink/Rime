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
	[ContainerType(16, 144)]
	public class KillCounterEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public KillWeight TeamKillWeight { get; set; } = new();

		[ContainerField(108)]
		public TeamId TeamId { get; set; } = new();

		[ContainerField(112)]
		public KillWeight NeutralTeamWeight { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable]
		public float EnemyWeight { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public uint MaxKillCount { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public bool IgnoreAI { get; set; }

		public static void Deserialize(KillCounterEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.KillWeight.Deserialize(p_Instance.TeamKillWeight, p_Reader, p_Parser);
			p_Instance.TeamId = (TeamId) p_Reader.ReadInt32();
			fb.KillWeight.Deserialize(p_Instance.NeutralTeamWeight, p_Reader, p_Parser);
			p_Instance.EnemyWeight = p_Reader.ReadSingle();
			p_Instance.MaxKillCount = p_Reader.ReadUInt32();
			p_Instance.IgnoreAI = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
