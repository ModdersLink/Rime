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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16)]
	public class ProjectileEntityData : 
		GamePhysicsEntityData
	{
		protected float m_VisualConvergeDistance = new float();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(4030464179)]
		public float VisualConvergeDistance { get { return m_VisualConvergeDistance; } set { if (OnPropertyChanging("ProjectileEntityData." + nameof(VisualConvergeDistance), this, m_VisualConvergeDistance, value)) m_VisualConvergeDistance = value; } } // 0x70 (112)
		
		protected float m_InitialSpeed = new float();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(3681055580)]
		public float InitialSpeed { get { return m_InitialSpeed; } set { if (OnPropertyChanging("ProjectileEntityData." + nameof(InitialSpeed), this, m_InitialSpeed, value)) m_InitialSpeed = value; } } // 0x74 (116)
		
		protected float m_TimeToLive = new float();
		[ContainerField(120), LayoutImmutable, Blittable, ContainerFieldNameHash(1571456733)]
		public float TimeToLive { get { return m_TimeToLive; } set { if (OnPropertyChanging("ProjectileEntityData." + nameof(TimeToLive), this, m_TimeToLive, value)) m_TimeToLive = value; } } // 0x78 (120)
		
		protected uint m_MaxCount = new uint();
		[ContainerField(124), LayoutImmutable, Blittable, ContainerFieldNameHash(415061138)]
		public uint MaxCount { get { return m_MaxCount; } set { if (OnPropertyChanging("ProjectileEntityData." + nameof(MaxCount), this, m_MaxCount, value)) m_MaxCount = value; } } // 0x7C (124)
		
		protected float m_InitMeshHideTime = new float();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(4189709497)]
		public float InitMeshHideTime { get { return m_InitMeshHideTime; } set { if (OnPropertyChanging("ProjectileEntityData." + nameof(InitMeshHideTime), this, m_InitMeshHideTime, value)) m_InitMeshHideTime = value; } } // 0x80 (128)
		
		protected CtrRef<MaterialContainerPair> m_MaterialPair = new CtrRef<MaterialContainerPair>();
		[ContainerField(132), ContainerFieldNameHash(161392100)]
		public CtrRef<MaterialContainerPair> MaterialPair { get { return m_MaterialPair; } set { if (OnPropertyChanging("ProjectileEntityData." + nameof(MaterialPair), this, m_MaterialPair, value)) m_MaterialPair = value; } } // 0x84 (132)
		
		protected AntHitReactionWeaponType m_HitReactionWeaponType = new AntHitReactionWeaponType();
		[ContainerField(136), ContainerFieldNameHash(2133337731)]
		public AntHitReactionWeaponType HitReactionWeaponType { get { return m_HitReactionWeaponType; } set { if (OnPropertyChanging("ProjectileEntityData." + nameof(HitReactionWeaponType), this, m_HitReactionWeaponType, value)) m_HitReactionWeaponType = value; } } // 0x88 (136)
		
		protected CtrRef<ExplosionEntityData> m_Explosion = new CtrRef<ExplosionEntityData>();
		[ContainerField(140), ContainerFieldNameHash(2222171184)]
		public CtrRef<ExplosionEntityData> Explosion { get { return m_Explosion; } set { if (OnPropertyChanging("ProjectileEntityData." + nameof(Explosion), this, m_Explosion, value)) m_Explosion = value; } } // 0x8C (140)
		
		protected CtrRef<WeaponSuppressionData> m_SuppressionData = new CtrRef<WeaponSuppressionData>();
		[ContainerField(144), ContainerFieldNameHash(1230905484)]
		public CtrRef<WeaponSuppressionData> SuppressionData { get { return m_SuppressionData; } set { if (OnPropertyChanging("ProjectileEntityData." + nameof(SuppressionData), this, m_SuppressionData, value)) m_SuppressionData = value; } } // 0x90 (144)
		
		protected string m_AmmunitionType = string.Empty;
		[ContainerField(148), LayoutImmutable, ContainerFieldNameHash(1231027442)]
		public string AmmunitionType { get { return m_AmmunitionType; } set { if (OnPropertyChanging("ProjectileEntityData." + nameof(AmmunitionType), this, m_AmmunitionType, value)) m_AmmunitionType = value; } } // 0x94 (148)
		
		protected bool m_ServerProjectileDisabled = new bool();
		[ContainerField(152), LayoutImmutable, Blittable, ContainerFieldNameHash(3578279269)]
		public bool ServerProjectileDisabled { get { return m_ServerProjectileDisabled; } set { if (OnPropertyChanging("ProjectileEntityData." + nameof(ServerProjectileDisabled), this, m_ServerProjectileDisabled, value)) m_ServerProjectileDisabled = value; } } // 0x98 (152)
		
		protected bool m_DetonateOnTimeout = new bool();
		[ContainerField(153), LayoutImmutable, Blittable, ContainerFieldNameHash(3547425179)]
		public bool DetonateOnTimeout { get { return m_DetonateOnTimeout; } set { if (OnPropertyChanging("ProjectileEntityData." + nameof(DetonateOnTimeout), this, m_DetonateOnTimeout, value)) m_DetonateOnTimeout = value; } } // 0x99 (153)
		
		protected bool m_SuppressOwnerVehicleDamage = new bool();
		[ContainerField(154), LayoutImmutable, Blittable, ContainerFieldNameHash(4245130982)]
		public bool SuppressOwnerVehicleDamage { get { return m_SuppressOwnerVehicleDamage; } set { if (OnPropertyChanging("ProjectileEntityData." + nameof(SuppressOwnerVehicleDamage), this, m_SuppressOwnerVehicleDamage, value)) m_SuppressOwnerVehicleDamage = value; } } // 0x9A (154)
		
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
