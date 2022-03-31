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
	[ContainerType(16, 160)]
	public class ArtilleryStrikeEntityData :
		GameEntityData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public CtrRef<MissileEntityData> MissileData { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float MissileSpawnRadius { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float DurationOfArtilleryStrike { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float MaxDelayBetweenProjectiles { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float MinDelayBetweenProjectiles { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float MaxDelayBetweenStrikes { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float MinDelayBetweenStrikes { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float MinRadiusToSoldier { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float RadiusWhenFollowingSoldier { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float HeightOffsetWhenFollowingSoldier { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public uint NumberOfStrikes { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public uint MaxProjectilesPerStrike { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public uint MinProjectilesPerStrike { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public bool FollowSoldier { get; set; }

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
