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
	public class PlayerScore
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int Rank { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint Kills { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint Deaths { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint ScoreMultiplier { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int Score { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public int GlobalScoreOriginal { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int GlobalScoreUpdated { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float Time { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint GunMasterLevel { get; set; }
		
		public static void Deserialize(PlayerScore p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Rank = p_Reader.ReadInt32();
			p_Instance.Kills = p_Reader.ReadUInt32();
			p_Instance.Deaths = p_Reader.ReadUInt32();
			p_Instance.ScoreMultiplier = p_Reader.ReadUInt32();
			p_Instance.Score = p_Reader.ReadInt32();
			p_Instance.GlobalScoreOriginal = p_Reader.ReadInt32();
			p_Instance.GlobalScoreUpdated = p_Reader.ReadInt32();
			p_Instance.Time = p_Reader.ReadSingle();
			p_Instance.GunMasterLevel = p_Reader.ReadUInt32();
		}
	}
}
