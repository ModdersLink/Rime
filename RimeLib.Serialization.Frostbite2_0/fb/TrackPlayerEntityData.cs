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
	[ContainerType(16, 112)]
	public partial class TrackPlayerEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _SnapHeightOffsetY;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private bool _RandomizeTracker;

		[ObservableProperty]
		[property: ContainerField(101), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
		private bool _SnapHeightOnKilledDestroyed;

		[ObservableProperty]
		[property: ContainerField(102), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
		private bool _CheckPlayerAlive;

		[ObservableProperty]
		[property: ContainerField(103), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
		private bool _EnforceSharedCombatArea;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private bool _UpdateFlagComponent;

		[ObservableProperty]
		[property: ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		private bool _TrackMultiplePlayers;

		[ObservableProperty]
		[property: ContainerField(106), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
		private bool _Reseted;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SnapHeightOffsetY);
			p_Writer.Write(RandomizeTracker);
			p_Writer.Write(SnapHeightOnKilledDestroyed);
			p_Writer.Write(CheckPlayerAlive);
			p_Writer.Write(EnforceSharedCombatArea);
			p_Writer.Write(UpdateFlagComponent);
			p_Writer.Write(TrackMultiplePlayers);
			p_Writer.Write(Reseted);
			p_Writer.WriteNullBytes(5);
		}
	}
}
