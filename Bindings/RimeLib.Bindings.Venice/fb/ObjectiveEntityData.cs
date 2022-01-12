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
	public class ObjectiveEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable]
		public string ObjectiveBriefSid { get; set; } = string.Empty;

		[ContainerField(100), LayoutImmutable]
		public string ObjectiveSid { get; set; } = string.Empty;

		[ContainerField(104)]
		public CtrRef<MissionObjectiveHudData> HudData { get; set; } = new();

		[ContainerField(108)]
		public ObjectiveType ObjectiveType { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public float DisplayTime { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float DelayTime { get; set; }

		[ContainerField(120)]
		public SquadId SquadId { get; set; } = new();

		[ContainerField(124)]
		public TeamId TeamId { get; set; } = new();

		[ContainerField(128), LayoutImmutable]
		public string SuccessSid { get; set; } = string.Empty;

		[ContainerField(132)]
		public MessageReciever Reciever { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable]
		public bool RetriggerSuccessOnShowObjective { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable]
		public bool Tutorial { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable]
		public bool DisplaySuccess { get; set; }

	}
}
