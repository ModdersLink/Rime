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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 192)]
	public class WeaponComponentData :
		PartComponentData
	{
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec3 ProjectileSpawnOffset { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float ImpulseStrength { get; set; }

		[ContainerField(132), JsonProperty(Order = 132)]
		public CtrRef<MeshAsset> WeaponMesh { get; set; } = new();

		[ContainerField(136), JsonProperty(Order = 136)]
		public CtrRef<WeaponFiringData> WeaponFiring { get; set; } = new();

		[ContainerField(140), LayoutImmutable, JsonProperty(Order = 140)]
		public string DamageGiverName { get; set; } = string.Empty;

		[ContainerField(144), JsonProperty(Order = 144)]
		public CtrRef<GameAIWeaponData> AIData { get; set; } = new();

		[ContainerField(148), JsonProperty(Order = 148)]
		public CtrRef<WeaponData> CustomWeaponType { get; set; } = new();

		[ContainerField(152), JsonProperty(Order = 152)]
		public WeaponClassification Classification { get; set; } = new();

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float ExplosionDamageMultiplier { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float ReloadTimeMultiplier { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float DamageMultiplier { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public uint WeaponItemHash { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public float OverheatDropPerSecondMultiplier { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float LockTimeMultiplier { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public float LockingAcceptanceAngleMultiplier { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public bool SequentialFiring { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ProjectileSpawnOffset.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ImpulseStrength);
			p_Writer.Write(p_EbxWriter.WriteImport(WeaponMesh));
			p_Writer.Write(p_EbxWriter.WriteImport(WeaponFiring));
			p_Writer.Write(p_EbxWriter.WriteString(DamageGiverName));
			p_Writer.Write(p_EbxWriter.WriteImport(AIData));
			p_Writer.Write(p_EbxWriter.WriteImport(CustomWeaponType));
			p_Writer.Write((int) Classification);
			p_Writer.Write(ExplosionDamageMultiplier);
			p_Writer.Write(ReloadTimeMultiplier);
			p_Writer.Write(DamageMultiplier);
			p_Writer.Write(WeaponItemHash);
			p_Writer.Write(OverheatDropPerSecondMultiplier);
			p_Writer.Write(LockTimeMultiplier);
			p_Writer.Write(LockingAcceptanceAngleMultiplier);
			p_Writer.Write(SequentialFiring);
			p_Writer.WriteNullBytes(7);
		}
	}
}
