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
	public class ExplosionPackEntityData : 
		MeshProjectileEntityData
	{
		[ContainerField(192), LayoutImmutable, Blittable]
		public float TimeToLiveOnPlayerDeath { get; set; } // 0xC0 (192)
		
		[ContainerField(196)]
		public SoldierDetonationData SoldierDetonationData { get; set; } = new SoldierDetonationData(); // 0xC4 (196)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float VehicleDetonationActivationDelay { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public float VehicleDetonationRadius { get; set; } // 0xDC (220)
		
		[ContainerField(224)]
		public UIHudIcon Icon { get; set; } = new UIHudIcon(); // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public float SpottedTime { get; set; } // 0xE4 (228)
		
		[ContainerField(232), LayoutImmutable, Blittable]
		public float DefuseRadius { get; set; } // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public float Health { get; set; } // 0xEC (236)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public bool HasRemoteDetonator { get; set; } // 0xF0 (240)
		
		[ContainerField(241), LayoutImmutable, Blittable]
		public bool IsDestructible { get; set; } // 0xF1 (241)
		
		[ContainerField(242), LayoutImmutable, Blittable]
		public bool HasVehicleDetonation { get; set; } // 0xF2 (242)
		
		[ContainerField(243), LayoutImmutable, Blittable]
		public bool ReceivesExplosionDamage { get; set; } // 0xF3 (243)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3787573811:
					TimeToLiveOnPlayerDeath = (float) p_Value;
					break;

				case 4178909974:
					SoldierDetonationData = (SoldierDetonationData) p_Value;
					break;

				case 4100261205:
					VehicleDetonationActivationDelay = (float) p_Value;
					break;

				case 1470001196:
					VehicleDetonationRadius = (float) p_Value;
					break;

				case 2088920302:
					Icon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 850456669:
					SpottedTime = (float) p_Value;
					break;

				case 3739807449:
					DefuseRadius = (float) p_Value;
					break;

				case 3054337113:
					Health = (float) p_Value;
					break;

				case 2357284391:
					HasRemoteDetonator = (bool) p_Value;
					break;

				case 121724683:
					IsDestructible = (bool) p_Value;
					break;

				case 2164993390:
					HasVehicleDetonation = (bool) p_Value;
					break;

				case 3643641923:
					ReceivesExplosionDamage = (bool) p_Value;
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
				case 3787573811:
					return TimeToLiveOnPlayerDeath;

				case 4178909974:
					return SoldierDetonationData;

				case 4100261205:
					return VehicleDetonationActivationDelay;

				case 1470001196:
					return VehicleDetonationRadius;

				case 2088920302:
					return Icon;

				case 850456669:
					return SpottedTime;

				case 3739807449:
					return DefuseRadius;

				case 3054337113:
					return Health;

				case 2357284391:
					return HasRemoteDetonator;

				case 121724683:
					return IsDestructible;

				case 2164993390:
					return HasVehicleDetonation;

				case 3643641923:
					return ReceivesExplosionDamage;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3787573811:
					return typeof(ExplosionPackEntityData).GetProperty(nameof(TimeToLiveOnPlayerDeath));

				case 4178909974:
					return typeof(ExplosionPackEntityData).GetProperty(nameof(SoldierDetonationData));

				case 4100261205:
					return typeof(ExplosionPackEntityData).GetProperty(nameof(VehicleDetonationActivationDelay));

				case 1470001196:
					return typeof(ExplosionPackEntityData).GetProperty(nameof(VehicleDetonationRadius));

				case 2088920302:
					return typeof(ExplosionPackEntityData).GetProperty(nameof(Icon));

				case 850456669:
					return typeof(ExplosionPackEntityData).GetProperty(nameof(SpottedTime));

				case 3739807449:
					return typeof(ExplosionPackEntityData).GetProperty(nameof(DefuseRadius));

				case 3054337113:
					return typeof(ExplosionPackEntityData).GetProperty(nameof(Health));

				case 2357284391:
					return typeof(ExplosionPackEntityData).GetProperty(nameof(HasRemoteDetonator));

				case 121724683:
					return typeof(ExplosionPackEntityData).GetProperty(nameof(IsDestructible));

				case 2164993390:
					return typeof(ExplosionPackEntityData).GetProperty(nameof(HasVehicleDetonation));

				case 3643641923:
					return typeof(ExplosionPackEntityData).GetProperty(nameof(ReceivesExplosionDamage));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
