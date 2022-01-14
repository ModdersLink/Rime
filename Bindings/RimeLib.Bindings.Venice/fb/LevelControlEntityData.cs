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
	[ContainerType(16, 112)]
	public class LevelControlEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, JsonProperty(Order = 96)]
		public string LevelToLoad { get; set; } = string.Empty;

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public bool RollCredits { get; set; }

	}
}
