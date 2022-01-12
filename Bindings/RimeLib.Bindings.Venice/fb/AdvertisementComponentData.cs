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
	[ContainerType(16, 128)]
	public class AdvertisementComponentData : 
		PartComponentData
	{
		[ContainerField(112), LayoutImmutable]
		public string Identifier { get; set; } = string.Empty;

		[ContainerField(116), LayoutImmutable]
		public string AdTexture { get; set; } = string.Empty;

	}
}
