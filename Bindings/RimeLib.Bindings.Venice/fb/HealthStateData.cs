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
	public class HealthStateData : 
		DataContainer
	{
		[ContainerField(8)]
		public RefArray<GameObjectData> Objects { get; set; } = new RefArray<GameObjectData>(); // 0x8 (8)
		
		[ContainerField(12)]
		public RefArray<NetworkableLoosePartPhysicsData> LoosePartPhysics { get; set; } = new RefArray<NetworkableLoosePartPhysicsData>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<ObjectBlueprint> SpawnedBangerBlueprint { get; set; } = new CtrRef<ObjectBlueprint>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<BangerSpawnImpulseParams> SpawnedBangerImpulseParams { get; set; } = new CtrRef<BangerSpawnImpulseParams>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Health { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint PartIndex { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool PhysicsEnabled { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool CopyDamageToBanger { get; set; } // 0x21 (33)
		
		[ContainerField(34), LayoutImmutable, Blittable]
		public bool CanSupportOtherParts { get; set; } // 0x22 (34)
		
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
