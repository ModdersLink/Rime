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
	[ContainerType(16, 112)]
	public class AutoTeamEntityData :
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public uint TeamDifferenceToAutoBalance { get; set; }

		[ContainerField(100), JsonProperty(Order = 100)]
		public TeamAssignMode TeamAssignMode { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public uint PlayerCountNeededToAutoBalance { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public bool ForceIntoSquad { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		public bool RotateTeamOnNewRound { get; set; }

		[ContainerField(110), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
		public bool AutoBalance { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TeamDifferenceToAutoBalance);
			p_Writer.Write((int) TeamAssignMode);
			p_Writer.Write(PlayerCountNeededToAutoBalance);
			p_Writer.Write(ForceIntoSquad);
			p_Writer.Write(RotateTeamOnNewRound);
			p_Writer.Write(AutoBalance);
			p_Writer.WriteNullBytes(1);
		}
	}
}
