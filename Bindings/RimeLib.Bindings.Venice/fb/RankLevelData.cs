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
	[ContainerType(4, 36)]
	public class RankLevelData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string RankName { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint PointsNeeded { get; set; }

		[ContainerField(16), LayoutImmutable]
		public string ImageName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string IconName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string SoundName { get; set; } = string.Empty;

		[ContainerField(28)]
		public List<BasicUnlockInfo> UnlockInfos { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public int RankNumber { get; set; }

	}
}
