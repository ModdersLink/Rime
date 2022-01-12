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
	[ContainerType(4, 8)]
	public class UIFontMapping
	{
		[ContainerField(0)]
		public List<string> ScaleformFontName { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable]
		public string FontLongName { get; set; } = string.Empty;
		
	}
}
