///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class ProjectileEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float VisualConvergeDistance { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float InitialSpeed { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float TimeToLive { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public uint MaxCount { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float InitMeshHideTime { get; set; } // 0x80 (128)
		
		[ContainerField(132)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new CtrRef<MaterialContainerPair>(); // 0x84 (132)
		
		[ContainerField(136)]
		public AntHitReactionWeaponType HitReactionWeaponType { get; set; } = new AntHitReactionWeaponType(); // 0x88 (136)
		
		[ContainerField(140)]
		public CtrRef<ExplosionEntityData> Explosion { get; set; } = new CtrRef<ExplosionEntityData>(); // 0x8C (140)
		
		[ContainerField(144)]
		public CtrRef<WeaponSuppressionData> SuppressionData { get; set; } = new CtrRef<WeaponSuppressionData>(); // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable]
		public string AmmunitionType { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public bool ServerProjectileDisabled { get; set; } // 0x98 (152)
		
		[ContainerField(153), LayoutImmutable, Blittable]
		public bool DetonateOnTimeout { get; set; } // 0x99 (153)
		
		[ContainerField(154), LayoutImmutable, Blittable]
		public bool SuppressOwnerVehicleDamage { get; set; } // 0x9A (154)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4030464179:
					VisualConvergeDistance = (float) p_Value;
					break;

				case 3681055580:
					InitialSpeed = (float) p_Value;
					break;

				case 1571456733:
					TimeToLive = (float) p_Value;
					break;

				case 415061138:
					MaxCount = (uint) p_Value;
					break;

				case 4189709497:
					InitMeshHideTime = (float) p_Value;
					break;

				case 161392100:
					MaterialPair = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 2133337731:
					HitReactionWeaponType = (AntHitReactionWeaponType) Enum.ToObject(typeof(AntHitReactionWeaponType), p_Value);
					break;

				case 2222171184:
					Explosion = (CtrRef<ExplosionEntityData>) p_Value;
					break;

				case 1230905484:
					SuppressionData = (CtrRef<WeaponSuppressionData>) p_Value;
					break;

				case 1231027442:
					AmmunitionType = (string) p_Value;
					break;

				case 3578279269:
					ServerProjectileDisabled = (bool) p_Value;
					break;

				case 3547425179:
					DetonateOnTimeout = (bool) p_Value;
					break;

				case 4245130982:
					SuppressOwnerVehicleDamage = (bool) p_Value;
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
				case 4030464179:
					return VisualConvergeDistance;

				case 3681055580:
					return InitialSpeed;

				case 1571456733:
					return TimeToLive;

				case 415061138:
					return MaxCount;

				case 4189709497:
					return InitMeshHideTime;

				case 161392100:
					return MaterialPair;

				case 2133337731:
					return HitReactionWeaponType;

				case 2222171184:
					return Explosion;

				case 1230905484:
					return SuppressionData;

				case 1231027442:
					return AmmunitionType;

				case 3578279269:
					return ServerProjectileDisabled;

				case 3547425179:
					return DetonateOnTimeout;

				case 4245130982:
					return SuppressOwnerVehicleDamage;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4030464179:
					return typeof(ProjectileEntityData).GetProperty(nameof(VisualConvergeDistance));

				case 3681055580:
					return typeof(ProjectileEntityData).GetProperty(nameof(InitialSpeed));

				case 1571456733:
					return typeof(ProjectileEntityData).GetProperty(nameof(TimeToLive));

				case 415061138:
					return typeof(ProjectileEntityData).GetProperty(nameof(MaxCount));

				case 4189709497:
					return typeof(ProjectileEntityData).GetProperty(nameof(InitMeshHideTime));

				case 161392100:
					return typeof(ProjectileEntityData).GetProperty(nameof(MaterialPair));

				case 2133337731:
					return typeof(ProjectileEntityData).GetProperty(nameof(HitReactionWeaponType));

				case 2222171184:
					return typeof(ProjectileEntityData).GetProperty(nameof(Explosion));

				case 1230905484:
					return typeof(ProjectileEntityData).GetProperty(nameof(SuppressionData));

				case 1231027442:
					return typeof(ProjectileEntityData).GetProperty(nameof(AmmunitionType));

				case 3578279269:
					return typeof(ProjectileEntityData).GetProperty(nameof(ServerProjectileDisabled));

				case 3547425179:
					return typeof(ProjectileEntityData).GetProperty(nameof(DetonateOnTimeout));

				case 4245130982:
					return typeof(ProjectileEntityData).GetProperty(nameof(SuppressOwnerVehicleDamage));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
