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
	[ContainerType(16, 128)]
	public class TacticalObjectiveEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable]
		public string MissionSid { get; set; } = string.Empty;

		[ContainerField(100), LayoutImmutable]
		public string BriefingSidTeam1 { get; set; } = string.Empty;

		[ContainerField(104), LayoutImmutable]
		public string BriefingSidTeam2 { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable, Blittable]
		public float Team1Timer { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float Team2Timer { get; set; }

	}
}
