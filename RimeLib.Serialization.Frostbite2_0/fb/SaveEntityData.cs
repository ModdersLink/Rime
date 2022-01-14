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
	[ContainerType(4, 32)]
	public class SaveEntityData : 
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<TextureAsset> SaveScreenTexture { get; set; } = new();

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string LevelName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string SaveFileName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string SaveNameSID { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool CheckForHumanPlayer { get; set; }

	}
}
