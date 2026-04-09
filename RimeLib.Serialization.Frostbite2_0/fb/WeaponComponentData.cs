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
	[ContainerType(16, 192)]
	public partial class WeaponComponentData :
		PartComponentData
	{
		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec3 _ProjectileSpawnOffset = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _ImpulseStrength;

		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private CtrRef<MeshAsset> _WeaponMesh = new();

		[ObservableProperty]
		[property: ContainerField(136), JsonProperty(Order = 136)]
		private CtrRef<WeaponFiringData> _WeaponFiring = new();

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, JsonProperty(Order = 140)]
		private string _DamageGiverName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private CtrRef<GameAIWeaponData> _AIData = new();

		[ObservableProperty]
		[property: ContainerField(148), JsonProperty(Order = 148)]
		private CtrRef<WeaponData> _CustomWeaponType = new();

		[ObservableProperty]
		[property: ContainerField(152), JsonProperty(Order = 152)]
		private WeaponClassification _Classification = new();

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _ExplosionDamageMultiplier;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _ReloadTimeMultiplier;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _DamageMultiplier;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private uint _WeaponItemHash;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private float _OverheatDropPerSecondMultiplier;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _LockTimeMultiplier;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private float _LockingAcceptanceAngleMultiplier;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private bool _SequentialFiring;

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
