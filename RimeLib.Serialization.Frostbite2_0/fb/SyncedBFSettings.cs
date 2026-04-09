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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 28)]
	public partial class SyncedBFSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _GameModeCounterModifier;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private bool _UnlicensedUnlocksUnlocked;

		[ObservableProperty]
		[property: ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		private bool _NoMinimap;

		[ObservableProperty]
		[property: ContainerField(18), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
		private bool _NoHud;

		[ObservableProperty]
		[property: ContainerField(19), LayoutImmutable, Blittable, JsonProperty(Order = 19)]
		private bool _NoMinimapSpotting;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private bool _No3dSpotting;

		[ObservableProperty]
		[property: ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		private bool _NoNameTag;

		[ObservableProperty]
		[property: ContainerField(22), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
		private bool _OnlySquadLeaderSpawn;

		[ObservableProperty]
		[property: ContainerField(23), LayoutImmutable, Blittable, JsonProperty(Order = 23)]
		private bool _TeamSwitchingAllowed;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _MemoryDefragUI;

		[ObservableProperty]
		[property: ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		private bool _MemoryGarbageCollectHavok;

		[ObservableProperty]
		[property: ContainerField(26), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
		private bool _MemoryDefragGlobal;

		[ObservableProperty]
		[property: ContainerField(27), LayoutImmutable, Blittable, JsonProperty(Order = 27)]
		private bool _AllUnlocksUnlocked;

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
