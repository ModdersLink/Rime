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
	[ContainerType(4, 36)]
	public class FriendlyFireEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public List<TeamId> Teams { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float EnemyCommitmentAllocation { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float FriendlyCommitmentAllocation { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxCommitment { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float FailureThreshold { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float DecayRate { get; set; }

		public static void Deserialize(FriendlyFireEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Teams.Clear();
			(RimeReader Reader, uint Count) s_Teams = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Teams.Count; ++i)
			{
				var s_Value = (TeamId) s_Teams.Reader.ReadInt32();
				p_Instance.Teams.Add(s_Value);
			}
			
			s_Teams.Reader.Dispose();
			p_Instance.EnemyCommitmentAllocation = p_Reader.ReadSingle();
			p_Instance.FriendlyCommitmentAllocation = p_Reader.ReadSingle();
			p_Instance.MaxCommitment = p_Reader.ReadSingle();
			p_Instance.FailureThreshold = p_Reader.ReadSingle();
			p_Instance.DecayRate = p_Reader.ReadSingle();
		}

	}
}
