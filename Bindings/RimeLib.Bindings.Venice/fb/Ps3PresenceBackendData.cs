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
	public class Ps3PresenceBackendData : 
		PresenceBackendData
	{
		[ContainerField(16), LayoutImmutable]
		public string CommunicationId { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string CommunicationSignature { get; set; } = string.Empty;

		[ContainerField(24)]
		public List<Ps3SkuSettings> SkuSettings { get; set; } = new();

		[ContainerField(28)]
		public List<Ps3ParentalLockAgeSettings> ParentalLockAgeSettings { get; set; } = new();

	}
}
