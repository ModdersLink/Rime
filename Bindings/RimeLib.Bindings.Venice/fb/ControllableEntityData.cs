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
	[ContainerType(16, 144)]
	public class ControllableEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float LowHealthThreshold { get; set; }

		[ContainerField(116), JsonProperty(Order = 116)]
		public TeamId DefaultTeam { get; set; } = new();

		[ContainerField(120), JsonProperty(Order = 120)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public bool ResetTeamOnLastPlayerExits { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		public bool FakeImmortal { get; set; }

		[ContainerField(126), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
		public bool UsePrediction { get; set; }

		[ContainerField(127), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
		public bool Immortal { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public bool ForceForegroundRendering { get; set; }

	}
}
