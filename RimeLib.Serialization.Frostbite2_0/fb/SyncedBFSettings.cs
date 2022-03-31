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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 28)]
	public class SyncedBFSettings :
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float GameModeCounterModifier { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool UnlicensedUnlocksUnlocked { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		public bool NoMinimap { get; set; }

		[ContainerField(18), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
		public bool NoHud { get; set; }

		[ContainerField(19), LayoutImmutable, Blittable, JsonProperty(Order = 19)]
		public bool NoMinimapSpotting { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool No3dSpotting { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		public bool NoNameTag { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
		public bool OnlySquadLeaderSpawn { get; set; }

		[ContainerField(23), LayoutImmutable, Blittable, JsonProperty(Order = 23)]
		public bool TeamSwitchingAllowed { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public bool MemoryDefragUI { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		public bool MemoryGarbageCollectHavok { get; set; }

		[ContainerField(26), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
		public bool MemoryDefragGlobal { get; set; }

		[ContainerField(27), LayoutImmutable, Blittable, JsonProperty(Order = 27)]
		public bool AllUnlocksUnlocked { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(GameModeCounterModifier);
			p_Writer.Write(UnlicensedUnlocksUnlocked);
			p_Writer.Write(NoMinimap);
			p_Writer.Write(NoHud);
			p_Writer.Write(NoMinimapSpotting);
			p_Writer.Write(No3dSpotting);
			p_Writer.Write(NoNameTag);
			p_Writer.Write(OnlySquadLeaderSpawn);
			p_Writer.Write(TeamSwitchingAllowed);
			p_Writer.Write(MemoryDefragUI);
			p_Writer.Write(MemoryGarbageCollectHavok);
			p_Writer.Write(MemoryDefragGlobal);
			p_Writer.Write(AllUnlocksUnlocked);
		}
	}
}
