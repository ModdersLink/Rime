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
	[ContainerType(4, 24)]
	public class PS3StoreImageSD : 
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable]
		public string Identifier { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string ImagePath { get; set; } = string.Empty;

	}
}
