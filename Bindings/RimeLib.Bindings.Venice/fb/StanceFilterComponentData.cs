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
	public class StanceFilterComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public List<int> ValidStances { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float StanceChangeTime { get; set; }

		[ContainerField(104)]
		public List<ActionSuppressor> ActionsToFilter { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool FilterSpecificActions { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable]
		public bool UndoParentStanceFilter { get; set; }

	}
}
