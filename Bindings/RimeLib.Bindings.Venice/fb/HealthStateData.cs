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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class HealthStateData : 
		DataContainer
	{
		protected RefArray<GameObjectData> m_Objects = new RefArray<GameObjectData>();
		[ContainerField(Name: "Objects", Offset: 8, NameHash: 105488131, Flags: 65)]
		public RefArray<GameObjectData> Objects { get { return m_Objects; } set { if (OnPropertyChanging("HealthStateData." + nameof(Objects), this, m_Objects, value)) m_Objects = value; } } // 0x8 (8)
		
		protected RefArray<NetworkableLoosePartPhysicsData> m_LoosePartPhysics = new RefArray<NetworkableLoosePartPhysicsData>();
		[ContainerField(Name: "LoosePartPhysics", Offset: 12, NameHash: 4017113603, Flags: 65)]
		public RefArray<NetworkableLoosePartPhysicsData> LoosePartPhysics { get { return m_LoosePartPhysics; } set { if (OnPropertyChanging("HealthStateData." + nameof(LoosePartPhysics), this, m_LoosePartPhysics, value)) m_LoosePartPhysics = value; } } // 0xC (12)
		
		protected CtrRef<ObjectBlueprint> m_SpawnedBangerBlueprint = new CtrRef<ObjectBlueprint>();
		[ContainerField(Name: "SpawnedBangerBlueprint", Offset: 16, NameHash: 1648406157, Flags: 53)]
		public CtrRef<ObjectBlueprint> SpawnedBangerBlueprint { get { return m_SpawnedBangerBlueprint; } set { if (OnPropertyChanging("HealthStateData." + nameof(SpawnedBangerBlueprint), this, m_SpawnedBangerBlueprint, value)) m_SpawnedBangerBlueprint = value; } } // 0x10 (16)
		
		protected CtrRef<BangerSpawnImpulseParams> m_SpawnedBangerImpulseParams = new CtrRef<BangerSpawnImpulseParams>();
		[ContainerField(Name: "SpawnedBangerImpulseParams", Offset: 20, NameHash: 4146360197, Flags: 53)]
		public CtrRef<BangerSpawnImpulseParams> SpawnedBangerImpulseParams { get { return m_SpawnedBangerImpulseParams; } set { if (OnPropertyChanging("HealthStateData." + nameof(SpawnedBangerImpulseParams), this, m_SpawnedBangerImpulseParams, value)) m_SpawnedBangerImpulseParams = value; } } // 0x14 (20)
		
		protected float m_Health = new float();
		[ContainerField(Name: "Health", Offset: 24, NameHash: 3054337113, Flags: 49469), LayoutImmutable, Blittable]
		public float Health { get { return m_Health; } set { if (OnPropertyChanging("HealthStateData." + nameof(Health), this, m_Health, value)) m_Health = value; } } // 0x18 (24)
		
		protected uint m_PartIndex = new uint();
		[ContainerField(Name: "PartIndex", Offset: 28, NameHash: 3213901068, Flags: 49421), LayoutImmutable, Blittable]
		public uint PartIndex { get { return m_PartIndex; } set { if (OnPropertyChanging("HealthStateData." + nameof(PartIndex), this, m_PartIndex, value)) m_PartIndex = value; } } // 0x1C (28)
		
		protected bool m_PhysicsEnabled = new bool();
		[ContainerField(Name: "PhysicsEnabled", Offset: 32, NameHash: 752388619, Flags: 49325), LayoutImmutable, Blittable]
		public bool PhysicsEnabled { get { return m_PhysicsEnabled; } set { if (OnPropertyChanging("HealthStateData." + nameof(PhysicsEnabled), this, m_PhysicsEnabled, value)) m_PhysicsEnabled = value; } } // 0x20 (32)
		
		protected bool m_CopyDamageToBanger = new bool();
		[ContainerField(Name: "CopyDamageToBanger", Offset: 33, NameHash: 3099666957, Flags: 49325), LayoutImmutable, Blittable]
		public bool CopyDamageToBanger { get { return m_CopyDamageToBanger; } set { if (OnPropertyChanging("HealthStateData." + nameof(CopyDamageToBanger), this, m_CopyDamageToBanger, value)) m_CopyDamageToBanger = value; } } // 0x21 (33)
		
		protected bool m_CanSupportOtherParts = new bool();
		[ContainerField(Name: "CanSupportOtherParts", Offset: 34, NameHash: 3085116102, Flags: 49325), LayoutImmutable, Blittable]
		public bool CanSupportOtherParts { get { return m_CanSupportOtherParts; } set { if (OnPropertyChanging("HealthStateData." + nameof(CanSupportOtherParts), this, m_CanSupportOtherParts, value)) m_CanSupportOtherParts = value; } } // 0x22 (34)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 105488131:
					Objects = (RefArray<GameObjectData>) p_Value;
					break;

				case 4017113603:
					LoosePartPhysics = (RefArray<NetworkableLoosePartPhysicsData>) p_Value;
					break;

				case 1648406157:
					SpawnedBangerBlueprint = (CtrRef<ObjectBlueprint>) p_Value;
					break;

				case 4146360197:
					SpawnedBangerImpulseParams = (CtrRef<BangerSpawnImpulseParams>) p_Value;
					break;

				case 3054337113:
					Health = (float) p_Value;
					break;

				case 3213901068:
					PartIndex = (uint) p_Value;
					break;

				case 752388619:
					PhysicsEnabled = (bool) p_Value;
					break;

				case 3099666957:
					CopyDamageToBanger = (bool) p_Value;
					break;

				case 3085116102:
					CanSupportOtherParts = (bool) p_Value;
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
				case 105488131:
					return Objects;

				case 4017113603:
					return LoosePartPhysics;

				case 1648406157:
					return SpawnedBangerBlueprint;

				case 4146360197:
					return SpawnedBangerImpulseParams;

				case 3054337113:
					return Health;

				case 3213901068:
					return PartIndex;

				case 752388619:
					return PhysicsEnabled;

				case 3099666957:
					return CopyDamageToBanger;

				case 3085116102:
					return CanSupportOtherParts;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 105488131:
					return typeof(HealthStateData).GetProperty(nameof(Objects));

				case 4017113603:
					return typeof(HealthStateData).GetProperty(nameof(LoosePartPhysics));

				case 1648406157:
					return typeof(HealthStateData).GetProperty(nameof(SpawnedBangerBlueprint));

				case 4146360197:
					return typeof(HealthStateData).GetProperty(nameof(SpawnedBangerImpulseParams));

				case 3054337113:
					return typeof(HealthStateData).GetProperty(nameof(Health));

				case 3213901068:
					return typeof(HealthStateData).GetProperty(nameof(PartIndex));

				case 752388619:
					return typeof(HealthStateData).GetProperty(nameof(PhysicsEnabled));

				case 3099666957:
					return typeof(HealthStateData).GetProperty(nameof(CopyDamageToBanger));

				case 3085116102:
					return typeof(HealthStateData).GetProperty(nameof(CanSupportOtherParts));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
