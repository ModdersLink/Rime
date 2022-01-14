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
	[ContainerType(4, 36)]
	public class RankLevelData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string RankName { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint PointsNeeded { get; set; }

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string ImageName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string IconName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string SoundName { get; set; } = string.Empty;

		[ContainerField(28), JsonProperty(Order = 28)]
		public List<BasicUnlockInfo> UnlockInfos { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public int RankNumber { get; set; }

	}
}
