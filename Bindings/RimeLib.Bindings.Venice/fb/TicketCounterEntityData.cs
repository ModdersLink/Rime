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
	public class TicketCounterEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public List<TicketCountPercentage> TicketPercentages { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public int TicketLossPerMin { get; set; }

		[ContainerField(104)]
		public TicketDecreaseType DecreaseTickets { get; set; } = new();

		[ContainerField(108)]
		public TeamId TeamId { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public int TicketLossWhenLostAll { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public int TicketLossWhenLostAllControlsPoint { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public int InitialTicketCount { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public int TicketLossStart { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public bool SetBestSquadSpawner { get; set; }

		[ContainerField(129), LayoutImmutable, Blittable]
		public bool HaltTicketLossOnEqualPointCount { get; set; }

		[ContainerField(130), LayoutImmutable, Blittable]
		public bool ResetCapturePointsOnReset { get; set; }

		[ContainerField(131), LayoutImmutable, Blittable]
		public bool SpawnAlwaysAllowed { get; set; }

	}
}
