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
	[ContainerType(4, 12)]
	public class EntryComponentHudData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int Index { get; set; }
		
		[ContainerField(4)]
		public EntrySeatType SeatType { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool Frustum { get; set; }
		
		[ContainerField(9), LayoutImmutable, Blittable]
		public bool Visible { get; set; }
		
		[ContainerField(10), LayoutImmutable, Blittable]
		public bool MaximizeMiniMapOnEntry { get; set; }
		
	}
}
