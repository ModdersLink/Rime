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
	public class VehicleProjectileEntityData : 
		ProjectileEntityData
	{
		protected CtrRef<VehicleBlueprint> m_Vehicle = new CtrRef<VehicleBlueprint>();
		[ContainerField(160), ContainerFieldNameHash(772552445)]
		public CtrRef<VehicleBlueprint> Vehicle { get { return m_Vehicle; } set { if (OnPropertyChanging("VehicleProjectileEntityData." + nameof(Vehicle), this, m_Vehicle, value)) m_Vehicle = value; } } // 0xA0 (160)
		
		protected float m_EnterDelay = new float();
		[ContainerField(164), LayoutImmutable, Blittable, ContainerFieldNameHash(4239333112)]
		public float EnterDelay { get { return m_EnterDelay; } set { if (OnPropertyChanging("VehicleProjectileEntityData." + nameof(EnterDelay), this, m_EnterDelay, value)) m_EnterDelay = value; } } // 0xA4 (164)
		
		protected float m_NoVehicleCollisionTime = new float();
		[ContainerField(168), LayoutImmutable, Blittable, ContainerFieldNameHash(2160489879)]
		public float NoVehicleCollisionTime { get { return m_NoVehicleCollisionTime; } set { if (OnPropertyChanging("VehicleProjectileEntityData." + nameof(NoVehicleCollisionTime), this, m_NoVehicleCollisionTime, value)) m_NoVehicleCollisionTime = value; } } // 0xA8 (168)
		
		protected float m_AlignWithGroundRayLength = new float();
		[ContainerField(172), LayoutImmutable, Blittable, ContainerFieldNameHash(3491351705)]
		public float AlignWithGroundRayLength { get { return m_AlignWithGroundRayLength; } set { if (OnPropertyChanging("VehicleProjectileEntityData." + nameof(AlignWithGroundRayLength), this, m_AlignWithGroundRayLength, value)) m_AlignWithGroundRayLength = value; } } // 0xAC (172)
		
		protected bool m_AutoEnter = new bool();
		[ContainerField(176), LayoutImmutable, Blittable, ContainerFieldNameHash(776240098)]
		public bool AutoEnter { get { return m_AutoEnter; } set { if (OnPropertyChanging("VehicleProjectileEntityData." + nameof(AutoEnter), this, m_AutoEnter, value)) m_AutoEnter = value; } } // 0xB0 (176)
		
		protected bool m_AlignWithGround = new bool();
		[ContainerField(177), LayoutImmutable, Blittable, ContainerFieldNameHash(2955522671)]
		public bool AlignWithGround { get { return m_AlignWithGround; } set { if (OnPropertyChanging("VehicleProjectileEntityData." + nameof(AlignWithGround), this, m_AlignWithGround, value)) m_AlignWithGround = value; } } // 0xB1 (177)
		
		protected bool m_CheckGroundWhenSpawned = new bool();
		[ContainerField(178), LayoutImmutable, Blittable, ContainerFieldNameHash(3321363400)]
		public bool CheckGroundWhenSpawned { get { return m_CheckGroundWhenSpawned; } set { if (OnPropertyChanging("VehicleProjectileEntityData." + nameof(CheckGroundWhenSpawned), this, m_CheckGroundWhenSpawned, value)) m_CheckGroundWhenSpawned = value; } } // 0xB2 (178)
		
		protected bool m_DeployInsideNeutralCombatAreaOnly = new bool();
		[ContainerField(179), LayoutImmutable, Blittable, ContainerFieldNameHash(1945021714)]
		public bool DeployInsideNeutralCombatAreaOnly { get { return m_DeployInsideNeutralCombatAreaOnly; } set { if (OnPropertyChanging("VehicleProjectileEntityData." + nameof(DeployInsideNeutralCombatAreaOnly), this, m_DeployInsideNeutralCombatAreaOnly, value)) m_DeployInsideNeutralCombatAreaOnly = value; } } // 0xB3 (179)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 772552445:
					Vehicle = (CtrRef<VehicleBlueprint>) p_Value;
					break;

				case 4239333112:
					EnterDelay = (float) p_Value;
					break;

				case 2160489879:
					NoVehicleCollisionTime = (float) p_Value;
					break;

				case 3491351705:
					AlignWithGroundRayLength = (float) p_Value;
					break;

				case 776240098:
					AutoEnter = (bool) p_Value;
					break;

				case 2955522671:
					AlignWithGround = (bool) p_Value;
					break;

				case 3321363400:
					CheckGroundWhenSpawned = (bool) p_Value;
					break;

				case 1945021714:
					DeployInsideNeutralCombatAreaOnly = (bool) p_Value;
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
				case 772552445:
					return Vehicle;

				case 4239333112:
					return EnterDelay;

				case 2160489879:
					return NoVehicleCollisionTime;

				case 3491351705:
					return AlignWithGroundRayLength;

				case 776240098:
					return AutoEnter;

				case 2955522671:
					return AlignWithGround;

				case 3321363400:
					return CheckGroundWhenSpawned;

				case 1945021714:
					return DeployInsideNeutralCombatAreaOnly;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 772552445:
					return typeof(VehicleProjectileEntityData).GetProperty(nameof(Vehicle));

				case 4239333112:
					return typeof(VehicleProjectileEntityData).GetProperty(nameof(EnterDelay));

				case 2160489879:
					return typeof(VehicleProjectileEntityData).GetProperty(nameof(NoVehicleCollisionTime));

				case 3491351705:
					return typeof(VehicleProjectileEntityData).GetProperty(nameof(AlignWithGroundRayLength));

				case 776240098:
					return typeof(VehicleProjectileEntityData).GetProperty(nameof(AutoEnter));

				case 2955522671:
					return typeof(VehicleProjectileEntityData).GetProperty(nameof(AlignWithGround));

				case 3321363400:
					return typeof(VehicleProjectileEntityData).GetProperty(nameof(CheckGroundWhenSpawned));

				case 1945021714:
					return typeof(VehicleProjectileEntityData).GetProperty(nameof(DeployInsideNeutralCombatAreaOnly));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
