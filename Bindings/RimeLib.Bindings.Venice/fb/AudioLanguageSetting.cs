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
	public class AudioLanguageSetting : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint NameHash { get; set; }

		[ContainerField(16), LayoutImmutable]
		public string DisplayName { get; set; } = string.Empty;

		[ContainerField(20)]
		public List<AudioLanguageMapping> Mappings { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool IsDefault { get; set; }

	}
}
