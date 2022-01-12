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
	public class ClearAreaTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112)]
		public TeamId TeamOfImmortalSoldiers { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public bool RemoveBangers { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable]
		public bool RemoveVehicles { get; set; }

		[ContainerField(118), LayoutImmutable, Blittable]
		public bool RemoveEffects { get; set; }

		[ContainerField(119), LayoutImmutable, Blittable]
		public bool RemoveStaticModels { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public bool RemoveDebrisClusters { get; set; }

		[ContainerField(121), LayoutImmutable, Blittable]
		public bool ExcludeImmortalSoldiersInTeam { get; set; }

		[ContainerField(122), LayoutImmutable, Blittable]
		public bool RemoveMeshProxies { get; set; }

		[ContainerField(123), LayoutImmutable, Blittable]
		public bool RemoveSoldiers { get; set; }

	}
}
