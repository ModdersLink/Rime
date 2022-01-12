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
	public class UIMinimapVolumeEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<Asset> Asset { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public bool IsDefault { get; set; }

	}
}
