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
	public class DestroyLevelCommandEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public uint InstanceCountDestroyedPerFrame { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public uint DestroyDelay { get; set; }

	}
}
