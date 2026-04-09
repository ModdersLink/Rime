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
	[ContainerType(16, 96)]
	public partial class ShotConfigData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private Vec3 _InitialPosition = new();
		
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _InitialDirection = new();
		
		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _InitialSpeed = new();
		
		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _InheritWeaponSpeedAmount;
		
		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private CtrRef<ExplosionEntityData> _MuzzleExplosion = new();
		
		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private CtrRef<ProjectileEntityData> _ProjectileData = new();
		
		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private CtrRef<ProjectileEntityData> _SecondaryProjectileData = new();
		
		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private CtrRef<ProjectileBlueprint> _Projectile = new();
		
		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private CtrRef<ProjectileBlueprint> _SecondaryProjectile = new();
		
		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private List<UnlockableProjectile> _AlternateProjectiles = new();
		
		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _SpawnDelay;
		
		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private uint _NumberOfBulletsPerShell;
		
		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private uint _NumberOfBulletsPerShot;
		
		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private uint _NumberOfBulletsPerBurst;
		
		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private bool _RelativeTargetAiming;
		
		[ObservableProperty]
		[property: ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		private bool _ForceSpawnToCamera;
		
		[ObservableProperty]
		[property: ContainerField(94), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
		private bool _SpawnVisualAtWeaponBone;
		
		[ObservableProperty]
		[property: ContainerField(95), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
		private bool _ActiveForceSpawnToCamera;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			InitialPosition.Serialize(p_Writer, p_EbxWriter);
			InitialDirection.Serialize(p_Writer, p_EbxWriter);
			InitialSpeed.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(InheritWeaponSpeedAmount);
			p_Writer.Write(p_EbxWriter.WriteImport(MuzzleExplosion));
			p_Writer.Write(p_EbxWriter.WriteImport(ProjectileData));
			p_Writer.Write(p_EbxWriter.WriteImport(SecondaryProjectileData));
			p_Writer.Write(p_EbxWriter.WriteImport(Projectile));
			p_Writer.Write(p_EbxWriter.WriteImport(SecondaryProjectile));
			(RimeWriter Writer, uint ArrayIndex) s_AlternateProjectiles = p_EbxWriter.GetArrayWriter(AlternateProjectiles.GetType(), AlternateProjectiles.Count);
			p_Writer.Write(s_AlternateProjectiles.ArrayIndex);
			foreach (var s_Entry in AlternateProjectiles)
			{
				s_Entry.Serialize(s_AlternateProjectiles.Writer, p_EbxWriter);
			}
			p_Writer.Write(SpawnDelay);
			p_Writer.Write(NumberOfBulletsPerShell);
			p_Writer.Write(NumberOfBulletsPerShot);
			p_Writer.Write(NumberOfBulletsPerBurst);
			p_Writer.Write(RelativeTargetAiming);
			p_Writer.Write(ForceSpawnToCamera);
			p_Writer.Write(SpawnVisualAtWeaponBone);
			p_Writer.Write(ActiveForceSpawnToCamera);
		}
	}
}
