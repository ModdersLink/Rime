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
	[ContainerType(4, 28)]
	public class SettingConfig
	{
		[ContainerField(0), LayoutImmutable]
		public string Key { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string NameSid { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable]
		public string DescSid { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint Max { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint Default { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint Min { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool Ranked { get; set; }
		
	}
}
