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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 256)]
	public class ExplosionPackEntityData : 
		MeshProjectileEntityData
	{
		protected float m_TimeToLiveOnPlayerDeath = new float();
		[ContainerField(Name: "TimeToLiveOnPlayerDeath", Offset: 192, NameHash: 3787573811, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeToLiveOnPlayerDeath { get { return m_TimeToLiveOnPlayerDeath; } set { if (OnPropertyChanging("ExplosionPackEntityData." + nameof(TimeToLiveOnPlayerDeath), this, m_TimeToLiveOnPlayerDeath, value)) m_TimeToLiveOnPlayerDeath = value; } } // 0xC0 (192)
		
		protected SoldierDetonationData m_SoldierDetonationData = new SoldierDetonationData();
		[ContainerField(Name: "SoldierDetonationData", Offset: 196, NameHash: 4178909974, Flags: 41)]
		public SoldierDetonationData SoldierDetonationData { get { return m_SoldierDetonationData; } set { if (OnPropertyChanging("ExplosionPackEntityData." + nameof(SoldierDetonationData), this, m_SoldierDetonationData, value)) m_SoldierDetonationData = value; } } // 0xC4 (196)
		
		protected float m_VehicleDetonationActivationDelay = new float();
		[ContainerField(Name: "VehicleDetonationActivationDelay", Offset: 216, NameHash: 4100261205, Flags: 49469), LayoutImmutable, Blittable]
		public float VehicleDetonationActivationDelay { get { return m_VehicleDetonationActivationDelay; } set { if (OnPropertyChanging("ExplosionPackEntityData." + nameof(VehicleDetonationActivationDelay), this, m_VehicleDetonationActivationDelay, value)) m_VehicleDetonationActivationDelay = value; } } // 0xD8 (216)
		
		protected float m_VehicleDetonationRadius = new float();
		[ContainerField(Name: "VehicleDetonationRadius", Offset: 220, NameHash: 1470001196, Flags: 49469), LayoutImmutable, Blittable]
		public float VehicleDetonationRadius { get { return m_VehicleDetonationRadius; } set { if (OnPropertyChanging("ExplosionPackEntityData." + nameof(VehicleDetonationRadius), this, m_VehicleDetonationRadius, value)) m_VehicleDetonationRadius = value; } } // 0xDC (220)
		
		protected UIHudIcon m_Icon = new UIHudIcon();
		[ContainerField(Name: "Icon", Offset: 224, NameHash: 2088920302, Flags: 137)]
		public UIHudIcon Icon { get { return m_Icon; } set { if (OnPropertyChanging("ExplosionPackEntityData." + nameof(Icon), this, m_Icon, value)) m_Icon = value; } } // 0xE0 (224)
		
		protected float m_SpottedTime = new float();
		[ContainerField(Name: "SpottedTime", Offset: 228, NameHash: 850456669, Flags: 49469), LayoutImmutable, Blittable]
		public float SpottedTime { get { return m_SpottedTime; } set { if (OnPropertyChanging("ExplosionPackEntityData." + nameof(SpottedTime), this, m_SpottedTime, value)) m_SpottedTime = value; } } // 0xE4 (228)
		
		protected float m_DefuseRadius = new float();
		[ContainerField(Name: "DefuseRadius", Offset: 232, NameHash: 3739807449, Flags: 49469), LayoutImmutable, Blittable]
		public float DefuseRadius { get { return m_DefuseRadius; } set { if (OnPropertyChanging("ExplosionPackEntityData." + nameof(DefuseRadius), this, m_DefuseRadius, value)) m_DefuseRadius = value; } } // 0xE8 (232)
		
		protected float m_Health = new float();
		[ContainerField(Name: "Health", Offset: 236, NameHash: 3054337113, Flags: 49469), LayoutImmutable, Blittable]
		public float Health { get { return m_Health; } set { if (OnPropertyChanging("ExplosionPackEntityData." + nameof(Health), this, m_Health, value)) m_Health = value; } } // 0xEC (236)
		
		protected bool m_HasRemoteDetonator = new bool();
		[ContainerField(Name: "HasRemoteDetonator", Offset: 240, NameHash: 2357284391, Flags: 49325), LayoutImmutable, Blittable]
		public bool HasRemoteDetonator { get { return m_HasRemoteDetonator; } set { if (OnPropertyChanging("ExplosionPackEntityData." + nameof(HasRemoteDetonator), this, m_HasRemoteDetonator, value)) m_HasRemoteDetonator = value; } } // 0xF0 (240)
		
		protected bool m_IsDestructible = new bool();
		[ContainerField(Name: "IsDestructible", Offset: 241, NameHash: 121724683, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsDestructible { get { return m_IsDestructible; } set { if (OnPropertyChanging("ExplosionPackEntityData." + nameof(IsDestructible), this, m_IsDestructible, value)) m_IsDestructible = value; } } // 0xF1 (241)
		
		protected bool m_HasVehicleDetonation = new bool();
		[ContainerField(Name: "HasVehicleDetonation", Offset: 242, NameHash: 2164993390, Flags: 49325), LayoutImmutable, Blittable]
		public bool HasVehicleDetonation { get { return m_HasVehicleDetonation; } set { if (OnPropertyChanging("ExplosionPackEntityData." + nameof(HasVehicleDetonation), this, m_HasVehicleDetonation, value)) m_HasVehicleDetonation = value; } } // 0xF2 (242)
		
		protected bool m_ReceivesExplosionDamage = new bool();
		[ContainerField(Name: "ReceivesExplosionDamage", Offset: 243, NameHash: 3643641923, Flags: 49325), LayoutImmutable, Blittable]
		public bool ReceivesExplosionDamage { get { return m_ReceivesExplosionDamage; } set { if (OnPropertyChanging("ExplosionPackEntityData." + nameof(ReceivesExplosionDamage), this, m_ReceivesExplosionDamage, value)) m_ReceivesExplosionDamage = value; } } // 0xF3 (243)
		
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
