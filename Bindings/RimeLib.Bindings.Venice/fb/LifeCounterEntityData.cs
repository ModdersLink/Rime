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

namespace fb
{
	[ContainerType(16, 160)]
	public class LifeCounterEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public int StartingLifeCount { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float DisplayTime { get; set; }

		[ContainerField(104), JsonProperty(Order = 104)]
		public TeamId TeamId { get; set; } = new();

		[ContainerField(108), JsonProperty(Order = 108)]
		public List<int> LifeTresholdValues { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public int UiShowCountLowerThreshold { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public int UiShowCountUpperThreshold { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public int BaseCount { get; set; }

		[ContainerField(124), JsonProperty(Order = 124)]
		public List<float> ReinforceTable { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public int ReinforceThreshold { get; set; }

		[ContainerField(132), LayoutImmutable, JsonProperty(Order = 132)]
		public string ReinforceMessageSid { get; set; } = string.Empty;

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float FightHarderTreshold { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float DefensiveKillRadius { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float FallbackTime { get; set; }

		[ContainerField(148), LayoutImmutable, JsonProperty(Order = 148)]
		public string FightHarderMessageSid { get; set; } = string.Empty;

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public bool Attacker { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		public bool SetBestSquadSpawner { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		public bool SimpleReinforce { get; set; }

	}
}
