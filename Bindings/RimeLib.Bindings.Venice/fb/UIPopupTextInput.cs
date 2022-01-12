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
	public class UIPopupTextInput
	{
		[ContainerField(0), LayoutImmutable]
		public string Id { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string Label { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable]
		public string DefaultValue { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool IsPassword { get; set; }
		
	}
}
