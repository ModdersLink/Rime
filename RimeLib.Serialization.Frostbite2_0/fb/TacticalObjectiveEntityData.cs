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
	[ContainerType(16, 128)]
	public class TacticalObjectiveEntityData :
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, JsonProperty(Order = 96)]
		public string MissionSid { get; set; } = string.Empty;

		[ContainerField(100), LayoutImmutable, JsonProperty(Order = 100)]
		public string BriefingSidTeam1 { get; set; } = string.Empty;

		[ContainerField(104), LayoutImmutable, JsonProperty(Order = 104)]
		public string BriefingSidTeam2 { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float Team1Timer { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float Team2Timer { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(MissionSid));
			p_Writer.Write(p_EbxWriter.WriteString(BriefingSidTeam1));
			p_Writer.Write(p_EbxWriter.WriteString(BriefingSidTeam2));
			p_Writer.Write(Team1Timer);
			p_Writer.Write(Team2Timer);
			p_Writer.WriteNullBytes(12);
		}
	}
}
