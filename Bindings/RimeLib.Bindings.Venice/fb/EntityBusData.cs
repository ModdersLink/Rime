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
	[ContainerType(4, 32)]
	public class EntityBusData : 
		DataBusData
	{
		[ContainerField(20)]
		public List<EventConnection> EventConnections { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<InterfaceDescriptorData> Descriptor { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool NeedNetworkId { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable]
		public bool InterfaceHasConnections { get; set; }

		[ContainerField(30), LayoutImmutable, Blittable]
		public bool AlwaysCreateEntityBusClient { get; set; }

		[ContainerField(31), LayoutImmutable, Blittable]
		public bool AlwaysCreateEntityBusServer { get; set; }

	}
}
