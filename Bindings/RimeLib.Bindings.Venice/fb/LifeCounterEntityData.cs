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

	}
}
