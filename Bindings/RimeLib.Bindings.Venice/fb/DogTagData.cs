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
	[ContainerType(4, 68)]
	public class DogTagData : 
		UnlockAssetBase
	{
		[ContainerField(40), LayoutImmutable]
		public string NameSID { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable]
		public string DescriptionSID { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable]
		public string ImageName { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable]
		public string SmallImageName { get; set; } = string.Empty;

		[ContainerField(56)]
		public DogTagCategory Category { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool InvertText { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable]
		public bool IsAlwaysAvailable { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable]
		public bool ExcludedOnXenon { get; set; }

		[ContainerField(63), LayoutImmutable, Blittable]
		public bool ExcludedOnPs3 { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public bool ExcludedOnWin32 { get; set; }

	}
}
