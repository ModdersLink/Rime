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
	[ContainerType(16, 144)]
	public class ControllableEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float LowHealthThreshold { get; set; }

		[ContainerField(116)]
		public TeamId DefaultTeam { get; set; } = new();

		[ContainerField(120)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool ResetTeamOnLastPlayerExits { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool FakeImmortal { get; set; }

		[ContainerField(126), LayoutImmutable, Blittable]
		public bool UsePrediction { get; set; }

		[ContainerField(127), LayoutImmutable, Blittable]
		public bool Immortal { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public bool ForceForegroundRendering { get; set; }

	}
}
