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
	[ContainerType(4, 32)]
	public class ProfileOptionsAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string FileName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable]
		public string ContentName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint FileSize { get; set; }

		[ContainerField(24)]
		public RefArray<ProfileOptionData> Options { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool AutoSaveOnQuit { get; set; }

	}
}
