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
	[ContainerType(16, 160)]
	public class ArtilleryStrikeEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<MissileEntityData> MissileData { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float MissileSpawnRadius { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float DurationOfArtilleryStrike { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float MaxDelayBetweenProjectiles { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float MinDelayBetweenProjectiles { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float MaxDelayBetweenStrikes { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float MinDelayBetweenStrikes { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float MinRadiusToSoldier { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float RadiusWhenFollowingSoldier { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float HeightOffsetWhenFollowingSoldier { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public uint NumberOfStrikes { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public uint MaxProjectilesPerStrike { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public uint MinProjectilesPerStrike { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public bool FollowSoldier { get; set; }

		public static void Deserialize(ArtilleryStrikeEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MissileData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MissileSpawnRadius = p_Reader.ReadSingle();
			p_Instance.DurationOfArtilleryStrike = p_Reader.ReadSingle();
			p_Instance.MaxDelayBetweenProjectiles = p_Reader.ReadSingle();
			p_Instance.MinDelayBetweenProjectiles = p_Reader.ReadSingle();
			p_Instance.MaxDelayBetweenStrikes = p_Reader.ReadSingle();
			p_Instance.MinDelayBetweenStrikes = p_Reader.ReadSingle();
			p_Instance.MinRadiusToSoldier = p_Reader.ReadSingle();
			p_Instance.RadiusWhenFollowingSoldier = p_Reader.ReadSingle();
			p_Instance.HeightOffsetWhenFollowingSoldier = p_Reader.ReadSingle();
			p_Instance.NumberOfStrikes = p_Reader.ReadUInt32();
			p_Instance.MaxProjectilesPerStrike = p_Reader.ReadUInt32();
			p_Instance.MinProjectilesPerStrike = p_Reader.ReadUInt32();
			p_Instance.FollowSoldier = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
