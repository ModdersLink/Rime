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
	[ContainerType(16, 160)]
	public class LifeCounterEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public int StartingLifeCount { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float DisplayTime { get; set; }

		[ContainerField(104)]
		public TeamId TeamId { get; set; } = new();

		[ContainerField(108)]
		public List<int> LifeTresholdValues { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public int UiShowCountLowerThreshold { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public int UiShowCountUpperThreshold { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public int BaseCount { get; set; }

		[ContainerField(124)]
		public List<float> ReinforceTable { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public int ReinforceThreshold { get; set; }

		[ContainerField(132), LayoutImmutable]
		public string ReinforceMessageSid { get; set; } = string.Empty;

		[ContainerField(136), LayoutImmutable, Blittable]
		public float FightHarderTreshold { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float DefensiveKillRadius { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float FallbackTime { get; set; }

		[ContainerField(148), LayoutImmutable]
		public string FightHarderMessageSid { get; set; } = string.Empty;

		[ContainerField(152), LayoutImmutable, Blittable]
		public bool Attacker { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable]
		public bool SetBestSquadSpawner { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable]
		public bool SimpleReinforce { get; set; }

		public static void Deserialize(LifeCounterEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.StartingLifeCount = p_Reader.ReadInt32();
			p_Instance.DisplayTime = p_Reader.ReadSingle();
			p_Instance.TeamId = (TeamId) p_Reader.ReadInt32();
			p_Instance.LifeTresholdValues.Clear();
			(RimeReader Reader, uint Count) s_LifeTresholdValues = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LifeTresholdValues.Count; ++i)
			{
				var s_Value = s_LifeTresholdValues.Reader.ReadInt32();
				p_Instance.LifeTresholdValues.Add(s_Value);
			}
			
			s_LifeTresholdValues.Reader.Dispose();
			p_Instance.UiShowCountLowerThreshold = p_Reader.ReadInt32();
			p_Instance.UiShowCountUpperThreshold = p_Reader.ReadInt32();
			p_Instance.BaseCount = p_Reader.ReadInt32();
			p_Instance.ReinforceTable.Clear();
			(RimeReader Reader, uint Count) s_ReinforceTable = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ReinforceTable.Count; ++i)
			{
				var s_Value = s_ReinforceTable.Reader.ReadSingle();
				p_Instance.ReinforceTable.Add(s_Value);
			}
			
			s_ReinforceTable.Reader.Dispose();
			p_Instance.ReinforceThreshold = p_Reader.ReadInt32();
			p_Instance.ReinforceMessageSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.FightHarderTreshold = p_Reader.ReadSingle();
			p_Instance.DefensiveKillRadius = p_Reader.ReadSingle();
			p_Instance.FallbackTime = p_Reader.ReadSingle();
			p_Instance.FightHarderMessageSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Attacker = p_Reader.ReadBool();
			p_Instance.SetBestSquadSpawner = p_Reader.ReadBool();
			p_Instance.SimpleReinforce = p_Reader.ReadBool();
			p_Reader.Seek(5, SeekOrigin.Current);
		}

	}
}
