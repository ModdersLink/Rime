///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 48)]
	public class UIWeaponAccessoryDescription : 
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string Name { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string Description { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string Category { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string TexturePath { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string IconTexturePath { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string UnlockTexturePath { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		public string MiscTexturePath { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool CoreAccessory { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		public bool HiddenInProgression { get; set; }

	}
}
