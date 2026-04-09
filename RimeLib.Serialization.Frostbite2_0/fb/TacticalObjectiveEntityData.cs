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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 128)]
	public partial class TacticalObjectiveEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, JsonProperty(Order = 96)]
		private string _MissionSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, JsonProperty(Order = 100)]
		private string _BriefingSidTeam1 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, JsonProperty(Order = 104)]
		private string _BriefingSidTeam2 = string.Empty;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _Team1Timer;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _Team2Timer;

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
