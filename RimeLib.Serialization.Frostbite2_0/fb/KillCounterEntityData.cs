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
	[ContainerType(16, 144)]
	public partial class KillCounterEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private KillWeight _TeamKillWeight = new();

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private TeamId _TeamId = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private KillWeight _NeutralTeamWeight = new();

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _EnemyWeight;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private uint _MaxKillCount;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private bool _IgnoreAI;

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
