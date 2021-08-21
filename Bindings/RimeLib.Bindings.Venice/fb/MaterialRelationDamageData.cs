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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class MaterialRelationDamageData : 
		PhysicsPropertyRelationPropertyData
	{
		protected float m_CollisionDamageMultiplier = new float();
		[ContainerField(Name: "CollisionDamageMultiplier", Offset: 8, NameHash: 31287099, Flags: 49469), LayoutImmutable, Blittable]
		public float CollisionDamageMultiplier { get { return m_CollisionDamageMultiplier; } set { if (OnPropertyChanging("MaterialRelationDamageData." + nameof(CollisionDamageMultiplier), this, m_CollisionDamageMultiplier, value)) m_CollisionDamageMultiplier = value; } } // 0x8 (8)
		
		protected float m_CollisionDamageThreshold = new float();
		[ContainerField(Name: "CollisionDamageThreshold", Offset: 12, NameHash: 2223249863, Flags: 49469), LayoutImmutable, Blittable]
		public float CollisionDamageThreshold { get { return m_CollisionDamageThreshold; } set { if (OnPropertyChanging("MaterialRelationDamageData." + nameof(CollisionDamageThreshold), this, m_CollisionDamageThreshold, value)) m_CollisionDamageThreshold = value; } } // 0xC (12)
		
		protected float m_DamageProtectionMultiplier = new float();
		[ContainerField(Name: "DamageProtectionMultiplier", Offset: 16, NameHash: 3194303654, Flags: 49469), LayoutImmutable, Blittable]
		public float DamageProtectionMultiplier { get { return m_DamageProtectionMultiplier; } set { if (OnPropertyChanging("MaterialRelationDamageData." + nameof(DamageProtectionMultiplier), this, m_DamageProtectionMultiplier, value)) m_DamageProtectionMultiplier = value; } } // 0x10 (16)
		
		protected float m_DamagePenetrationMultiplier = new float();
		[ContainerField(Name: "DamagePenetrationMultiplier", Offset: 20, NameHash: 2424339200, Flags: 49469), LayoutImmutable, Blittable]
		public float DamagePenetrationMultiplier { get { return m_DamagePenetrationMultiplier; } set { if (OnPropertyChanging("MaterialRelationDamageData." + nameof(DamagePenetrationMultiplier), this, m_DamagePenetrationMultiplier, value)) m_DamagePenetrationMultiplier = value; } } // 0x14 (20)
		
		protected float m_DamageProtectionThreshold = new float();
		[ContainerField(Name: "DamageProtectionThreshold", Offset: 24, NameHash: 1413485242, Flags: 49469), LayoutImmutable, Blittable]
		public float DamageProtectionThreshold { get { return m_DamageProtectionThreshold; } set { if (OnPropertyChanging("MaterialRelationDamageData." + nameof(DamageProtectionThreshold), this, m_DamageProtectionThreshold, value)) m_DamageProtectionThreshold = value; } } // 0x18 (24)
		
		protected float m_ExplosionCoverDamageModifier = new float();
		[ContainerField(Name: "ExplosionCoverDamageModifier", Offset: 28, NameHash: 3323347809, Flags: 49469), LayoutImmutable, Blittable]
		public float ExplosionCoverDamageModifier { get { return m_ExplosionCoverDamageModifier; } set { if (OnPropertyChanging("MaterialRelationDamageData." + nameof(ExplosionCoverDamageModifier), this, m_ExplosionCoverDamageModifier, value)) m_ExplosionCoverDamageModifier = value; } } // 0x1C (28)
		
		protected bool m_InflictsDemolitionDamage = new bool();
		[ContainerField(Name: "InflictsDemolitionDamage", Offset: 32, NameHash: 3423431988, Flags: 49325), LayoutImmutable, Blittable]
		public bool InflictsDemolitionDamage { get { return m_InflictsDemolitionDamage; } set { if (OnPropertyChanging("MaterialRelationDamageData." + nameof(InflictsDemolitionDamage), this, m_InflictsDemolitionDamage, value)) m_InflictsDemolitionDamage = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 31287099:
					CollisionDamageMultiplier = (float) p_Value;
					break;

				case 2223249863:
					CollisionDamageThreshold = (float) p_Value;
					break;

				case 3194303654:
					DamageProtectionMultiplier = (float) p_Value;
					break;

				case 2424339200:
					DamagePenetrationMultiplier = (float) p_Value;
					break;

				case 1413485242:
					DamageProtectionThreshold = (float) p_Value;
					break;

				case 3323347809:
					ExplosionCoverDamageModifier = (float) p_Value;
					break;

				case 3423431988:
					InflictsDemolitionDamage = (bool) p_Value;
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
				case 31287099:
					return CollisionDamageMultiplier;

				case 2223249863:
					return CollisionDamageThreshold;

				case 3194303654:
					return DamageProtectionMultiplier;

				case 2424339200:
					return DamagePenetrationMultiplier;

				case 1413485242:
					return DamageProtectionThreshold;

				case 3323347809:
					return ExplosionCoverDamageModifier;

				case 3423431988:
					return InflictsDemolitionDamage;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 31287099:
					return typeof(MaterialRelationDamageData).GetProperty(nameof(CollisionDamageMultiplier));

				case 2223249863:
					return typeof(MaterialRelationDamageData).GetProperty(nameof(CollisionDamageThreshold));

				case 3194303654:
					return typeof(MaterialRelationDamageData).GetProperty(nameof(DamageProtectionMultiplier));

				case 2424339200:
					return typeof(MaterialRelationDamageData).GetProperty(nameof(DamagePenetrationMultiplier));

				case 1413485242:
					return typeof(MaterialRelationDamageData).GetProperty(nameof(DamageProtectionThreshold));

				case 3323347809:
					return typeof(MaterialRelationDamageData).GetProperty(nameof(ExplosionCoverDamageModifier));

				case 3423431988:
					return typeof(MaterialRelationDamageData).GetProperty(nameof(InflictsDemolitionDamage));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
