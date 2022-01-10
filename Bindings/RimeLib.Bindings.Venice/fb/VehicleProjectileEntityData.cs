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
	[ContainerType(16, 192)]
	public class VehicleProjectileEntityData : 
		ProjectileEntityData
	{
		[ContainerField(160)]
		public CtrRef<VehicleBlueprint> Vehicle { get; set; } = new();

		[ContainerField(164), LayoutImmutable, Blittable]
		public float EnterDelay { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float NoVehicleCollisionTime { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public float AlignWithGroundRayLength { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public bool AutoEnter { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable]
		public bool AlignWithGround { get; set; }

		[ContainerField(178), LayoutImmutable, Blittable]
		public bool CheckGroundWhenSpawned { get; set; }

		[ContainerField(179), LayoutImmutable, Blittable]
		public bool DeployInsideNeutralCombatAreaOnly { get; set; }

		public static void Deserialize(VehicleProjectileEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Vehicle.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.EnterDelay = p_Reader.ReadSingle();
			p_Instance.NoVehicleCollisionTime = p_Reader.ReadSingle();
			p_Instance.AlignWithGroundRayLength = p_Reader.ReadSingle();
			p_Instance.AutoEnter = p_Reader.ReadBool();
			p_Instance.AlignWithGround = p_Reader.ReadBool();
			p_Instance.CheckGroundWhenSpawned = p_Reader.ReadBool();
			p_Instance.DeployInsideNeutralCombatAreaOnly = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
