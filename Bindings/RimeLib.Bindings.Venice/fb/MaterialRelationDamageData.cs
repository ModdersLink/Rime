///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MaterialRelationDamageData : 
		PhysicsPropertyRelationPropertyData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float CollisionDamageMultiplier { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float CollisionDamageThreshold { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float DamageProtectionMultiplier { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float DamagePenetrationMultiplier { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float DamageProtectionThreshold { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ExplosionCoverDamageModifier { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool InflictsDemolitionDamage { get; set; } // 0x20 (32)
		
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
