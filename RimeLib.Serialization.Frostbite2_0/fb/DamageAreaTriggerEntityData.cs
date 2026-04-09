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
	public partial class DamageAreaTriggerEntityData :
		TriggerEntityData
	{
		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _DamagePerSecond;

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private TeamId _TeamOfImmortalCharacters = new();

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _DamageTime;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private bool _DamageVehicles;

		[ObservableProperty]
		[property: ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		private bool _DamageBangers;

		[ObservableProperty]
		[property: ContainerField(126), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
		private bool _ExcludeImmortalCharactersInTeam;

		[ObservableProperty]
		[property: ContainerField(127), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
		private bool _DamageCharacters;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private bool _ExcludeShieldedSoldiers;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DamagePerSecond);
			p_Writer.Write((int) TeamOfImmortalCharacters);
			p_Writer.Write(DamageTime);
			p_Writer.Write(DamageVehicles);
			p_Writer.Write(DamageBangers);
			p_Writer.Write(ExcludeImmortalCharactersInTeam);
			p_Writer.Write(DamageCharacters);
			p_Writer.Write(ExcludeShieldedSoldiers);
			p_Writer.WriteNullBytes(15);
		}
	}
}
