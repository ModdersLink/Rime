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
	public class UIBundleAssetState
	{
		[ContainerField(0), LayoutImmutable]
		public string StateName { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public UIState UIState { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable]
		public string ResourceBundleName { get; set; } = string.Empty;
		
	}
}
