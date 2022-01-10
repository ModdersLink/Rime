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
	[ContainerType(16, 128)]
	public class TacticalObjectiveEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable]
		public string MissionSid { get; set; } = string.Empty;

		[ContainerField(100), LayoutImmutable]
		public string BriefingSidTeam1 { get; set; } = string.Empty;

		[ContainerField(104), LayoutImmutable]
		public string BriefingSidTeam2 { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable, Blittable]
		public float Team1Timer { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float Team2Timer { get; set; }

		public static void Deserialize(TacticalObjectiveEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MissionSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.BriefingSidTeam1 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.BriefingSidTeam2 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Team1Timer = p_Reader.ReadSingle();
			p_Instance.Team2Timer = p_Reader.ReadSingle();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
