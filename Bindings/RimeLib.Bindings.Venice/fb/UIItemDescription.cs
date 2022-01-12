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
	[ContainerType(4, 16)]
	public class UIItemDescription : 
		DataContainer
	{
		[ContainerField(8)]
		public List<uint> ItemIds { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public bool IgnoreBuild { get; set; }

	}
}
