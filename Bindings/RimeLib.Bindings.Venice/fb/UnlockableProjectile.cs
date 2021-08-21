///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 41, Size: 32)]
	public class UnlockableProjectile : FrostbiteContainer
	{
		[ContainerField(Name: "InitialSpeed", Offset: 0, NameHash: 3681055580, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialSpeed { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "ProjectileData", Offset: 16, NameHash: 2690942720, Flags: 53)]
		public CtrRef<ProjectileEntityData> ProjectileData { get; set; } = new CtrRef<ProjectileEntityData>(); // 0x10 (16)
		
		[ContainerField(Name: "Projectile", Offset: 20, NameHash: 3883939888, Flags: 53)]
		public CtrRef<ProjectileBlueprint> Projectile { get; set; } = new CtrRef<ProjectileBlueprint>(); // 0x14 (20)
		
		[ContainerField(Name: "Unlock", Offset: 24, NameHash: 2968292597, Flags: 53)]
		public CtrRef<UnlockAssetBase> Unlock { get; set; } = new CtrRef<UnlockAssetBase>(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3681055580:
					InitialSpeed = (Vec3) p_Value;
					break;

				case 2690942720:
					ProjectileData = (CtrRef<ProjectileEntityData>) p_Value;
					break;

				case 3883939888:
					Projectile = (CtrRef<ProjectileBlueprint>) p_Value;
					break;

				case 2968292597:
					Unlock = (CtrRef<UnlockAssetBase>) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3681055580:
					return InitialSpeed;

				case 2690942720:
					return ProjectileData;

				case 3883939888:
					return Projectile;

				case 2968292597:
					return Unlock;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3681055580:
					return typeof(UnlockableProjectile).GetProperty(nameof(InitialSpeed));

				case 2690942720:
					return typeof(UnlockableProjectile).GetProperty(nameof(ProjectileData));

				case 3883939888:
					return typeof(UnlockableProjectile).GetProperty(nameof(Projectile));

				case 2968292597:
					return typeof(UnlockableProjectile).GetProperty(nameof(Unlock));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
