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
	[ContainerType(4, 36)]
	public class EntitlementQuery : 
		Asset
	{
		[ContainerField(12)]
		public List<EntitlementData> EntitlementsData { get; set; } = new();

		[ContainerField(16)]
		public List<string> GroupNames { get; set; } = new();

		[ContainerField(20)]
		public GamePlatform Platform { get; set; } = new();

		[ContainerField(24), LayoutImmutable]
		public string EntitlementTag { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string ProductId { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable]
		public string ProjectId { get; set; } = string.Empty;

	}
}
