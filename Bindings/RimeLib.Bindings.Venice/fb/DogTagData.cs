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
	[ContainerType(4, 68)]
	public class DogTagData : 
		UnlockAssetBase
	{
		[ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		public string NameSID { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		public string DescriptionSID { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		public string ImageName { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable, JsonProperty(Order = 52)]
		public string SmallImageName { get; set; } = string.Empty;

		[ContainerField(56), JsonProperty(Order = 56)]
		public DogTagCategory Category { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public bool InvertText { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		public bool IsAlwaysAvailable { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		public bool ExcludedOnXenon { get; set; }

		[ContainerField(63), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
		public bool ExcludedOnPs3 { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public bool ExcludedOnWin32 { get; set; }

	}
}
