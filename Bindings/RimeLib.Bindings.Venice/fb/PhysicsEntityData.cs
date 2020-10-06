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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(80), ContainerClass]
	public class PhysicsEntityData : 
		EntityData
	{
		protected Vec3 m_InertiaModifier = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3532865534)]
		public Vec3 InertiaModifier { get { return m_InertiaModifier; } set { if (OnPropertyChanging("PhysicsEntityData." + nameof(InertiaModifier), this, m_InertiaModifier, value)) m_InertiaModifier = value; } } // 0x10 (16)
		
		protected RefArray<HavokAsset> m_ScaledAssets = new RefArray<HavokAsset>();
		[ContainerField(32), MemberInfoFlag(65), ContainerFieldNameHash(3460372282), ContainerRefArray]
		public RefArray<HavokAsset> ScaledAssets { get { return m_ScaledAssets; } set { if (OnPropertyChanging("PhysicsEntityData." + nameof(ScaledAssets), this, m_ScaledAssets, value)) m_ScaledAssets = value; } } // 0x20 (32)
		
		protected RefArray<RigidBodyData> m_RigidBodies = new RefArray<RigidBodyData>();
		[ContainerField(36), MemberInfoFlag(65), ContainerFieldNameHash(3015855522), ContainerRefArray]
		public RefArray<RigidBodyData> RigidBodies { get { return m_RigidBodies; } set { if (OnPropertyChanging("PhysicsEntityData." + nameof(RigidBodies), this, m_RigidBodies, value)) m_RigidBodies = value; } } // 0x24 (36)
		
		protected CtrRef<HavokAsset> m_Asset = new CtrRef<HavokAsset>();
		[ContainerField(40), MemberInfoFlag(53), ContainerFieldNameHash(205976053), ContainerCtrRef]
		public CtrRef<HavokAsset> Asset { get { return m_Asset; } set { if (OnPropertyChanging("PhysicsEntityData." + nameof(Asset), this, m_Asset, value)) m_Asset = value; } } // 0x28 (40)
		
		protected CtrRef<FloatPhysicsData> m_FloatPhysics = new CtrRef<FloatPhysicsData>();
		[ContainerField(44), MemberInfoFlag(53), ContainerFieldNameHash(2331402366), ContainerCtrRef]
		public CtrRef<FloatPhysicsData> FloatPhysics { get { return m_FloatPhysics; } set { if (OnPropertyChanging("PhysicsEntityData." + nameof(FloatPhysics), this, m_FloatPhysics, value)) m_FloatPhysics = value; } } // 0x2C (44)
		
		protected float m_Mass = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2088779625)]
		public float Mass { get { return m_Mass; } set { if (OnPropertyChanging("PhysicsEntityData." + nameof(Mass), this, m_Mass, value)) m_Mass = value; } } // 0x30 (48)
		
		protected float m_Restitution = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2298929185)]
		public float Restitution { get { return m_Restitution; } set { if (OnPropertyChanging("PhysicsEntityData." + nameof(Restitution), this, m_Restitution, value)) m_Restitution = value; } } // 0x34 (52)
		
		protected float m_Friction = new float();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(306207591)]
		public float Friction { get { return m_Friction; } set { if (OnPropertyChanging("PhysicsEntityData." + nameof(Friction), this, m_Friction, value)) m_Friction = value; } } // 0x38 (56)
		
		protected float m_LinearVelocityDamping = new float();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1004384727)]
		public float LinearVelocityDamping { get { return m_LinearVelocityDamping; } set { if (OnPropertyChanging("PhysicsEntityData." + nameof(LinearVelocityDamping), this, m_LinearVelocityDamping, value)) m_LinearVelocityDamping = value; } } // 0x3C (60)
		
		protected float m_AngularVelocityDamping = new float();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2367237320)]
		public float AngularVelocityDamping { get { return m_AngularVelocityDamping; } set { if (OnPropertyChanging("PhysicsEntityData." + nameof(AngularVelocityDamping), this, m_AngularVelocityDamping, value)) m_AngularVelocityDamping = value; } } // 0x40 (64)
		
		protected CtrRef<ProximityData> m_Proximity = new CtrRef<ProximityData>();
		[ContainerField(68), MemberInfoFlag(53), ContainerFieldNameHash(258157264), ContainerCtrRef]
		public CtrRef<ProximityData> Proximity { get { return m_Proximity; } set { if (OnPropertyChanging("PhysicsEntityData." + nameof(Proximity), this, m_Proximity, value)) m_Proximity = value; } } // 0x44 (68)
		
		protected RefArray<RigidBodyConstraintData> m_Constraints = new RefArray<RigidBodyConstraintData>();
		[ContainerField(72), MemberInfoFlag(65), ContainerFieldNameHash(1187639635), ContainerRefArray]
		public RefArray<RigidBodyConstraintData> Constraints { get { return m_Constraints; } set { if (OnPropertyChanging("PhysicsEntityData." + nameof(Constraints), this, m_Constraints, value)) m_Constraints = value; } } // 0x48 (72)
		
		protected bool m_EncapsulatePartsInLists = new bool();
		[ContainerField(76), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3158648404)]
		public bool EncapsulatePartsInLists { get { return m_EncapsulatePartsInLists; } set { if (OnPropertyChanging("PhysicsEntityData." + nameof(EncapsulatePartsInLists), this, m_EncapsulatePartsInLists, value)) m_EncapsulatePartsInLists = value; } } // 0x4C (76)
		
		protected bool m_MovableParts = new bool();
		[ContainerField(77), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(532177919)]
		public bool MovableParts { get { return m_MovableParts; } set { if (OnPropertyChanging("PhysicsEntityData." + nameof(MovableParts), this, m_MovableParts, value)) m_MovableParts = value; } } // 0x4D (77)
		
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
