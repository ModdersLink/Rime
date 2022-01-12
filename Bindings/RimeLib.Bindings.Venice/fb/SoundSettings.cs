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
	[ContainerType(4, 44)]
	public class SoundSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable]
		public string VOEnglish { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable]
		public string AudioSystemUri { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string VOCommon { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string VOItalian { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string VOSpanish { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable]
		public string VOFrench { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable]
		public string VOGerman { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

	}
}
