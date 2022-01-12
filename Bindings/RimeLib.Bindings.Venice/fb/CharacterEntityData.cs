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
	public class CharacterEntityData : 
		ControllableEntityData
	{
		[ContainerField(144)]
		public PersonViewMode DefaultViewMode { get; set; } = new();

		[ContainerField(148)]
		public PlayerSpawnType PlayerSpawnType { get; set; } = new();

		[ContainerField(152), LayoutImmutable, Blittable]
		public bool CharacterLightingEnable { get; set; }

	}
}
