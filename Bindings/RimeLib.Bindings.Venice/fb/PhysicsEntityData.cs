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
	public class PhysicsEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InertiaModifier { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32)]
		public RefArray<HavokAsset> ScaledAssets { get; set; } = new RefArray<HavokAsset>(); // 0x20 (32)
		
		[ContainerField(36)]
		public RefArray<RigidBodyData> RigidBodies { get; set; } = new RefArray<RigidBodyData>(); // 0x24 (36)
		
		[ContainerField(40)]
		public CtrRef<HavokAsset> Asset { get; set; } = new CtrRef<HavokAsset>(); // 0x28 (40)
		
		[ContainerField(44)]
		public CtrRef<FloatPhysicsData> FloatPhysics { get; set; } = new CtrRef<FloatPhysicsData>(); // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float Mass { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float Restitution { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float Friction { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float LinearVelocityDamping { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float AngularVelocityDamping { get; set; } // 0x40 (64)
		
		[ContainerField(68)]
		public CtrRef<ProximityData> Proximity { get; set; } = new CtrRef<ProximityData>(); // 0x44 (68)
		
		[ContainerField(72)]
		public RefArray<RigidBodyConstraintData> Constraints { get; set; } = new RefArray<RigidBodyConstraintData>(); // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public bool EncapsulatePartsInLists { get; set; } // 0x4C (76)
		
		[ContainerField(77), LayoutImmutable, Blittable]
		public bool MovableParts { get; set; } // 0x4D (77)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3532865534:
					InertiaModifier = (Vec3) p_Value;
					break;

				case 3460372282:
					ScaledAssets = (RefArray<HavokAsset>) p_Value;
					break;

				case 3015855522:
					RigidBodies = (RefArray<RigidBodyData>) p_Value;
					break;

				case 205976053:
					Asset = (CtrRef<HavokAsset>) p_Value;
					break;

				case 2331402366:
					FloatPhysics = (CtrRef<FloatPhysicsData>) p_Value;
					break;

				case 2088779625:
					Mass = (float) p_Value;
					break;

				case 2298929185:
					Restitution = (float) p_Value;
					break;

				case 306207591:
					Friction = (float) p_Value;
					break;

				case 1004384727:
					LinearVelocityDamping = (float) p_Value;
					break;

				case 2367237320:
					AngularVelocityDamping = (float) p_Value;
					break;

				case 258157264:
					Proximity = (CtrRef<ProximityData>) p_Value;
					break;

				case 1187639635:
					Constraints = (RefArray<RigidBodyConstraintData>) p_Value;
					break;

				case 3158648404:
					EncapsulatePartsInLists = (bool) p_Value;
					break;

				case 532177919:
					MovableParts = (bool) p_Value;
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
				case 3532865534:
					return InertiaModifier;

				case 3460372282:
					return ScaledAssets;

				case 3015855522:
					return RigidBodies;

				case 205976053:
					return Asset;

				case 2331402366:
					return FloatPhysics;

				case 2088779625:
					return Mass;

				case 2298929185:
					return Restitution;

				case 306207591:
					return Friction;

				case 1004384727:
					return LinearVelocityDamping;

				case 2367237320:
					return AngularVelocityDamping;

				case 258157264:
					return Proximity;

				case 1187639635:
					return Constraints;

				case 3158648404:
					return EncapsulatePartsInLists;

				case 532177919:
					return MovableParts;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3532865534:
					return typeof(PhysicsEntityData).GetProperty(nameof(InertiaModifier));

				case 3460372282:
					return typeof(PhysicsEntityData).GetProperty(nameof(ScaledAssets));

				case 3015855522:
					return typeof(PhysicsEntityData).GetProperty(nameof(RigidBodies));

				case 205976053:
					return typeof(PhysicsEntityData).GetProperty(nameof(Asset));

				case 2331402366:
					return typeof(PhysicsEntityData).GetProperty(nameof(FloatPhysics));

				case 2088779625:
					return typeof(PhysicsEntityData).GetProperty(nameof(Mass));

				case 2298929185:
					return typeof(PhysicsEntityData).GetProperty(nameof(Restitution));

				case 306207591:
					return typeof(PhysicsEntityData).GetProperty(nameof(Friction));

				case 1004384727:
					return typeof(PhysicsEntityData).GetProperty(nameof(LinearVelocityDamping));

				case 2367237320:
					return typeof(PhysicsEntityData).GetProperty(nameof(AngularVelocityDamping));

				case 258157264:
					return typeof(PhysicsEntityData).GetProperty(nameof(Proximity));

				case 1187639635:
					return typeof(PhysicsEntityData).GetProperty(nameof(Constraints));

				case 3158648404:
					return typeof(PhysicsEntityData).GetProperty(nameof(EncapsulatePartsInLists));

				case 532177919:
					return typeof(PhysicsEntityData).GetProperty(nameof(MovableParts));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
