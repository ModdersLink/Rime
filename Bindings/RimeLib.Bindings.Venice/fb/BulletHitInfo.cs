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
	[ContainerType(16, 48)]
	public class BulletHitInfo
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Direction { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SpawnPosition { get; set; } = new();
		
		[ContainerField(32)]
		public CtrRef<SoldierWeaponUnlockAsset> WeaponUnlockAsset { get; set; } = new();
		
		[ContainerField(36)]
		public AntHitReactionWeaponType WeaponType { get; set; } = new();
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public int BoneType { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public int ShooterPlayerId { get; set; }
		
		public static void Deserialize(BulletHitInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.Direction, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.SpawnPosition, p_Reader, p_Parser);
			p_Instance.WeaponUnlockAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.WeaponType = (AntHitReactionWeaponType) p_Reader.ReadInt32();
			p_Instance.BoneType = p_Reader.ReadInt32();
			p_Instance.ShooterPlayerId = p_Reader.ReadInt32();
		}
	}
}
