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
	[ContainerType(4, 44)]
	public class SubWorldData : 
		SpatialPrefabBlueprint
	{
		[ContainerField(36)]
		public CtrRef<RegistryContainer> RegistryContainer { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool IsWin32SubLevel { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable]
		public bool IsXenonSubLevel { get; set; }

		[ContainerField(42), LayoutImmutable, Blittable]
		public bool IsPs3SubLevel { get; set; }

		[ContainerField(43), LayoutImmutable, Blittable]
		public bool RememberStateOnStreamOut { get; set; }

	}
}
