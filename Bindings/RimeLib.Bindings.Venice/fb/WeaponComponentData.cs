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
	public class WeaponComponentData : 
		PartComponentData
	{
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ProjectileSpawnOffset { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public float ImpulseStrength { get; set; }

		[ContainerField(132)]
		public CtrRef<MeshAsset> WeaponMesh { get; set; } = new();

		[ContainerField(136)]
		public CtrRef<WeaponFiringData> WeaponFiring { get; set; } = new();

		[ContainerField(140), LayoutImmutable]
		public string DamageGiverName { get; set; } = string.Empty;

		[ContainerField(144)]
		public CtrRef<GameAIWeaponData> AIData { get; set; } = new();

		[ContainerField(148)]
		public CtrRef<WeaponData> CustomWeaponType { get; set; } = new();

		[ContainerField(152)]
		public WeaponClassification Classification { get; set; } = new();

		[ContainerField(156), LayoutImmutable, Blittable]
		public float ExplosionDamageMultiplier { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float ReloadTimeMultiplier { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float DamageMultiplier { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public uint WeaponItemHash { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public float OverheatDropPerSecondMultiplier { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float LockTimeMultiplier { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public float LockingAcceptanceAngleMultiplier { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public bool SequentialFiring { get; set; }

		public static void Deserialize(WeaponComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.ProjectileSpawnOffset, p_Reader, p_Parser);
			p_Instance.ImpulseStrength = p_Reader.ReadSingle();
			p_Instance.WeaponMesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.WeaponFiring.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DamageGiverName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.AIData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CustomWeaponType.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Classification = (WeaponClassification) p_Reader.ReadInt32();
			p_Instance.ExplosionDamageMultiplier = p_Reader.ReadSingle();
			p_Instance.ReloadTimeMultiplier = p_Reader.ReadSingle();
			p_Instance.DamageMultiplier = p_Reader.ReadSingle();
			p_Instance.WeaponItemHash = p_Reader.ReadUInt32();
			p_Instance.OverheatDropPerSecondMultiplier = p_Reader.ReadSingle();
			p_Instance.LockTimeMultiplier = p_Reader.ReadSingle();
			p_Instance.LockingAcceptanceAngleMultiplier = p_Reader.ReadSingle();
			p_Instance.SequentialFiring = p_Reader.ReadBool();
			p_Reader.Seek(7, SeekOrigin.Current);
		}

	}
}
