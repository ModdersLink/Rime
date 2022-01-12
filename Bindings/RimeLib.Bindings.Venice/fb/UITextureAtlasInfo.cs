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
	public class UITextureAtlasInfo
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 MinUv { get; set; } = new();
		
		[ContainerField(8), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 MaxUv { get; set; } = new();
		
	}
}
