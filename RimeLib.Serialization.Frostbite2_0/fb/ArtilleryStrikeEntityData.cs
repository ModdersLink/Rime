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
	[ContainerType(16, 160)]
	public partial class ArtilleryStrikeEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private CtrRef<MissileEntityData> _MissileData = new();

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _MissileSpawnRadius;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _DurationOfArtilleryStrike;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _MaxDelayBetweenProjectiles;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _MinDelayBetweenProjectiles;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _MaxDelayBetweenStrikes;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _MinDelayBetweenStrikes;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _MinRadiusToSoldier;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _RadiusWhenFollowingSoldier;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _HeightOffsetWhenFollowingSoldier;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private uint _NumberOfStrikes;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private uint _MaxProjectilesPerStrike;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private uint _MinProjectilesPerStrike;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private bool _FollowSoldier;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(MissileData));
			p_Writer.Write(MissileSpawnRadius);
			p_Writer.Write(DurationOfArtilleryStrike);
			p_Writer.Write(MaxDelayBetweenProjectiles);
			p_Writer.Write(MinDelayBetweenProjectiles);
			p_Writer.Write(MaxDelayBetweenStrikes);
			p_Writer.Write(MinDelayBetweenStrikes);
			p_Writer.Write(MinRadiusToSoldier);
			p_Writer.Write(RadiusWhenFollowingSoldier);
			p_Writer.Write(HeightOffsetWhenFollowingSoldier);
			p_Writer.Write(NumberOfStrikes);
			p_Writer.Write(MaxProjectilesPerStrike);
			p_Writer.Write(MinProjectilesPerStrike);
			p_Writer.Write(FollowSoldier);
			p_Writer.WriteNullBytes(11);
		}
	}
}
