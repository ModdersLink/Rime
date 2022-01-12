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
	public class SoundGraphPluginInfo
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public uint Id { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint EnableAttributeReadMask { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public sbyte ConnectionIndex { get; set; }
		
		[ContainerField(9), LayoutImmutable, Blittable]
		public sbyte OutputChannelCount { get; set; }
		
		[ContainerField(10), LayoutImmutable, Blittable]
		public sbyte ConstructParamsIndex { get; set; }
		
		[ContainerField(11), LayoutImmutable, Blittable]
		public sbyte ConstructParamCount { get; set; }
		
	}
}
