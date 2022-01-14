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
	public class CustomizeCharacterData : 
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<CustomizeVisual> VisualGroups { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float OverrideCriticalHealthThreshold { get; set; }

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<UnlockAssetBase> Unlocks { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float OverrideMaxHealth { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool ClearVisualState { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		public bool RestoreToOriginalVisualState { get; set; }

	}
}
