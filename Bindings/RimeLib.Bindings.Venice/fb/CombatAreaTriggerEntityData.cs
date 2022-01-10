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
	[ContainerType(16, 128)]
	public class CombatAreaTriggerEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float MaxRandomSpawnHeight { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float SpawnHeight { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public uint TimeToReturn { get; set; }

		[ContainerField(108)]
		public CtrRef<BulletEntityData> DeserterProjectile { get; set; } = new();

		[ContainerField(112)]
		public TeamId Team { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public float StrikeRadius { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float InitalSpeed { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool IsAiAllowedOutside { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool IsTeamSpecific { get; set; }

		public static void Deserialize(CombatAreaTriggerEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaxRandomSpawnHeight = p_Reader.ReadSingle();
			p_Instance.SpawnHeight = p_Reader.ReadSingle();
			p_Instance.TimeToReturn = p_Reader.ReadUInt32();
			p_Instance.DeserterProjectile.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Team = (TeamId) p_Reader.ReadInt32();
			p_Instance.StrikeRadius = p_Reader.ReadSingle();
			p_Instance.InitalSpeed = p_Reader.ReadSingle();
			p_Instance.IsAiAllowedOutside = p_Reader.ReadBool();
			p_Instance.IsTeamSpecific = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
