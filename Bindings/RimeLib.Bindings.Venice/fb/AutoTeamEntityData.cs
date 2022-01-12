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
	[ContainerType(16, 112)]
	public class AutoTeamEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public uint TeamDifferenceToAutoBalance { get; set; }

		[ContainerField(100)]
		public TeamAssignMode TeamAssignMode { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public uint PlayerCountNeededToAutoBalance { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool ForceIntoSquad { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable]
		public bool RotateTeamOnNewRound { get; set; }

		[ContainerField(110), LayoutImmutable, Blittable]
		public bool AutoBalance { get; set; }

	}
}
