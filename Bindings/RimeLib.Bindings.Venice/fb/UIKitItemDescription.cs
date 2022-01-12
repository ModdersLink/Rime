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
	[ContainerType(4, 52)]
	public class UIKitItemDescription : 
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string UnlockName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string Description { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string Category { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable]
		public string TexturePath { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable]
		public string IconTexturePath { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable]
		public string UnlockTexturePath { get; set; } = string.Empty;

		[ContainerField(44)]
		public UIHudIcon HudIcon { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool NotExplicitelySelectable { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable]
		public bool HiddenInProgression { get; set; }

	}
}
