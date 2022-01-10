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
	[ContainerType(16, 96)]
	public class ShotConfigData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialPosition { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialDirection { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialSpeed { get; set; } = new();
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float InheritWeaponSpeedAmount { get; set; }
		
		[ContainerField(52)]
		public CtrRef<ExplosionEntityData> MuzzleExplosion { get; set; } = new();
		
		[ContainerField(56)]
		public CtrRef<ProjectileEntityData> ProjectileData { get; set; } = new();
		
		[ContainerField(60)]
		public CtrRef<ProjectileEntityData> SecondaryProjectileData { get; set; } = new();
		
		[ContainerField(64)]
		public CtrRef<ProjectileBlueprint> Projectile { get; set; } = new();
		
		[ContainerField(68)]
		public CtrRef<ProjectileBlueprint> SecondaryProjectile { get; set; } = new();
		
		[ContainerField(72)]
		public List<UnlockableProjectile> AlternateProjectiles { get; set; } = new();
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float SpawnDelay { get; set; }
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public uint NumberOfBulletsPerShell { get; set; }
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public uint NumberOfBulletsPerShot { get; set; }
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public uint NumberOfBulletsPerBurst { get; set; }
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public bool RelativeTargetAiming { get; set; }
		
		[ContainerField(93), LayoutImmutable, Blittable]
		public bool ForceSpawnToCamera { get; set; }
		
		[ContainerField(94), LayoutImmutable, Blittable]
		public bool SpawnVisualAtWeaponBone { get; set; }
		
		[ContainerField(95), LayoutImmutable, Blittable]
		public bool ActiveForceSpawnToCamera { get; set; }
		
		public static void Deserialize(ShotConfigData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.InitialPosition, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.InitialDirection, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.InitialSpeed, p_Reader, p_Parser);
			p_Instance.InheritWeaponSpeedAmount = p_Reader.ReadSingle();
			p_Instance.MuzzleExplosion.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ProjectileData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SecondaryProjectileData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Projectile.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SecondaryProjectile.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AlternateProjectiles.Clear();
			(RimeReader Reader, uint Count) s_AlternateProjectiles = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AlternateProjectiles.Count; ++i)
			{
				var s_Value = new UnlockableProjectile();
				fb.UnlockableProjectile.Deserialize(s_Value, s_AlternateProjectiles.Reader, p_Parser);
				p_Instance.AlternateProjectiles.Add(s_Value);
			}
			
			s_AlternateProjectiles.Reader.Dispose();
			p_Instance.SpawnDelay = p_Reader.ReadSingle();
			p_Instance.NumberOfBulletsPerShell = p_Reader.ReadUInt32();
			p_Instance.NumberOfBulletsPerShot = p_Reader.ReadUInt32();
			p_Instance.NumberOfBulletsPerBurst = p_Reader.ReadUInt32();
			p_Instance.RelativeTargetAiming = p_Reader.ReadBool();
			p_Instance.ForceSpawnToCamera = p_Reader.ReadBool();
			p_Instance.SpawnVisualAtWeaponBone = p_Reader.ReadBool();
			p_Instance.ActiveForceSpawnToCamera = p_Reader.ReadBool();
		}
	}
}
