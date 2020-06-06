///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class VehicleProjectileEntityData : 
		ProjectileEntityData
	{
		[ContainerField(160)]
		public CtrRef<VehicleBlueprint> Vehicle { get; set; } = new CtrRef<VehicleBlueprint>(); // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float EnterDelay { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float NoVehicleCollisionTime { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public float AlignWithGroundRayLength { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public bool AutoEnter { get; set; } // 0xB0 (176)
		
		[ContainerField(177), LayoutImmutable, Blittable]
		public bool AlignWithGround { get; set; } // 0xB1 (177)
		
		[ContainerField(178), LayoutImmutable, Blittable]
		public bool CheckGroundWhenSpawned { get; set; } // 0xB2 (178)
		
		[ContainerField(179), LayoutImmutable, Blittable]
		public bool DeployInsideNeutralCombatAreaOnly { get; set; } // 0xB3 (179)
		
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
