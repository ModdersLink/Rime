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
	[ContainerType(16, 112)]
	public partial class AutoTeamEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private uint _TeamDifferenceToAutoBalance;

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private TeamAssignMode _TeamAssignMode = new();

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private uint _PlayerCountNeededToAutoBalance;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private bool _ForceIntoSquad;

		[ObservableProperty]
		[property: ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		private bool _RotateTeamOnNewRound;

		[ObservableProperty]
		[property: ContainerField(110), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
		private bool _AutoBalance;

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
