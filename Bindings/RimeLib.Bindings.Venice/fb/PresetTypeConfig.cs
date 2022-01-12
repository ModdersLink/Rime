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
	public class PresetTypeConfig
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int PresetId { get; set; }
		
		[ContainerField(4), LayoutImmutable]
		public string Key { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable]
		public string NameSid { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable]
		public string DescSid { get; set; } = string.Empty;
		
		[ContainerField(16)]
		public List<LockedSettingConfig> LockedSettings { get; set; } = new();
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool Predefined { get; set; }
		
	}
}
