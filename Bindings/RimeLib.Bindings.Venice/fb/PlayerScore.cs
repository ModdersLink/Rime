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
	public class PlayerScore
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public int Rank { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public uint Kills { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint Deaths { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint ScoreMultiplier { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public int Score { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public int GlobalScoreOriginal { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int GlobalScoreUpdated { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float Time { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public uint GunMasterLevel { get; set; }
		
	}
}
