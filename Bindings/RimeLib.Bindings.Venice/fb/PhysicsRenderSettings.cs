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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 52)]
	public class PhysicsRenderSettings : 
		DataContainer
	{
		protected int m_RenderSpecificPart = new int();
		[ContainerField(Name: "RenderSpecificPart", Offset: 8, NameHash: 4286518232, Flags: 49405), LayoutImmutable, Blittable]
		public int RenderSpecificPart { get { return m_RenderSpecificPart; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderSpecificPart), this, m_RenderSpecificPart, value)) m_RenderSpecificPart = value; } } // 0x8 (8)
		
		protected float m_ViewDistance = new float();
		[ContainerField(Name: "ViewDistance", Offset: 12, NameHash: 2201945291, Flags: 49469), LayoutImmutable, Blittable]
		public float ViewDistance { get { return m_ViewDistance; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(ViewDistance), this, m_ViewDistance, value)) m_ViewDistance = value; } } // 0xC (12)
		
		protected bool m_RenderClient = new bool();
		[ContainerField(Name: "RenderClient", Offset: 16, NameHash: 913404726, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderClient { get { return m_RenderClient; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderClient), this, m_RenderClient, value)) m_RenderClient = value; } } // 0x10 (16)
		
		protected bool m_RenderEffectWorld = new bool();
		[ContainerField(Name: "RenderEffectWorld", Offset: 17, NameHash: 1824683034, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderEffectWorld { get { return m_RenderEffectWorld; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderEffectWorld), this, m_RenderEffectWorld, value)) m_RenderEffectWorld = value; } } // 0x11 (17)
		
		protected bool m_RenderDetail = new bool();
		[ContainerField(Name: "RenderDetail", Offset: 18, NameHash: 961029854, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderDetail { get { return m_RenderDetail; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderDetail), this, m_RenderDetail, value)) m_RenderDetail = value; } } // 0x12 (18)
		
		protected bool m_RenderStatic = new bool();
		[ContainerField(Name: "RenderStatic", Offset: 19, NameHash: 1529820951, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderStatic { get { return m_RenderStatic; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderStatic), this, m_RenderStatic, value)) m_RenderStatic = value; } } // 0x13 (19)
		
		protected bool m_RenderUngrouped = new bool();
		[ContainerField(Name: "RenderUngrouped", Offset: 20, NameHash: 347264234, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderUngrouped { get { return m_RenderUngrouped; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderUngrouped), this, m_RenderUngrouped, value)) m_RenderUngrouped = value; } } // 0x14 (20)
		
		protected bool m_RenderRagdoll = new bool();
		[ContainerField(Name: "RenderRagdoll", Offset: 21, NameHash: 3960799760, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderRagdoll { get { return m_RenderRagdoll; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderRagdoll), this, m_RenderRagdoll, value)) m_RenderRagdoll = value; } } // 0x15 (21)
		
		protected bool m_RenderGroup = new bool();
		[ContainerField(Name: "RenderGroup", Offset: 22, NameHash: 2757014864, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderGroup { get { return m_RenderGroup; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderGroup), this, m_RenderGroup, value)) m_RenderGroup = value; } } // 0x16 (22)
		
		protected bool m_RenderPhantoms = new bool();
		[ContainerField(Name: "RenderPhantoms", Offset: 23, NameHash: 2016203773, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderPhantoms { get { return m_RenderPhantoms; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderPhantoms), this, m_RenderPhantoms, value)) m_RenderPhantoms = value; } } // 0x17 (23)
		
		protected bool m_RenderCharacterCollision = new bool();
		[ContainerField(Name: "RenderCharacterCollision", Offset: 24, NameHash: 3110574600, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderCharacterCollision { get { return m_RenderCharacterCollision; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderCharacterCollision), this, m_RenderCharacterCollision, value)) m_RenderCharacterCollision = value; } } // 0x18 (24)
		
		protected bool m_RenderWater = new bool();
		[ContainerField(Name: "RenderWater", Offset: 25, NameHash: 2775439226, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderWater { get { return m_RenderWater; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderWater), this, m_RenderWater, value)) m_RenderWater = value; } } // 0x19 (25)
		
		protected bool m_RenderSolidGeometry = new bool();
		[ContainerField(Name: "RenderSolidGeometry", Offset: 26, NameHash: 2704633192, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderSolidGeometry { get { return m_RenderSolidGeometry; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderSolidGeometry), this, m_RenderSolidGeometry, value)) m_RenderSolidGeometry = value; } } // 0x1A (26)
		
		protected bool m_UseShapeCache = new bool();
		[ContainerField(Name: "UseShapeCache", Offset: 27, NameHash: 2012203077, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseShapeCache { get { return m_UseShapeCache; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(UseShapeCache), this, m_UseShapeCache, value)) m_UseShapeCache = value; } } // 0x1B (27)
		
		protected bool m_RenderConstraints = new bool();
		[ContainerField(Name: "RenderConstraints", Offset: 28, NameHash: 3785323737, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderConstraints { get { return m_RenderConstraints; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderConstraints), this, m_RenderConstraints, value)) m_RenderConstraints = value; } } // 0x1C (28)
		
		protected bool m_RenderOnlyContactConstraints = new bool();
		[ContainerField(Name: "RenderOnlyContactConstraints", Offset: 29, NameHash: 840353645, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderOnlyContactConstraints { get { return m_RenderOnlyContactConstraints; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderOnlyContactConstraints), this, m_RenderOnlyContactConstraints, value)) m_RenderOnlyContactConstraints = value; } } // 0x1D (29)
		
		protected bool m_RenderConstraintCount = new bool();
		[ContainerField(Name: "RenderConstraintCount", Offset: 30, NameHash: 3706029321, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderConstraintCount { get { return m_RenderConstraintCount; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderConstraintCount), this, m_RenderConstraintCount, value)) m_RenderConstraintCount = value; } } // 0x1E (30)
		
		protected bool m_RenderActiveConstraintCount = new bool();
		[ContainerField(Name: "RenderActiveConstraintCount", Offset: 31, NameHash: 3147515589, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderActiveConstraintCount { get { return m_RenderActiveConstraintCount; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderActiveConstraintCount), this, m_RenderActiveConstraintCount, value)) m_RenderActiveConstraintCount = value; } } // 0x1F (31)
		
		protected bool m_RenderSimulationIslands = new bool();
		[ContainerField(Name: "RenderSimulationIslands", Offset: 32, NameHash: 1511950866, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderSimulationIslands { get { return m_RenderSimulationIslands; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderSimulationIslands), this, m_RenderSimulationIslands, value)) m_RenderSimulationIslands = value; } } // 0x20 (32)
		
		protected bool m_RenderBroadphaseHandles = new bool();
		[ContainerField(Name: "RenderBroadphaseHandles", Offset: 33, NameHash: 3537504867, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderBroadphaseHandles { get { return m_RenderBroadphaseHandles; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderBroadphaseHandles), this, m_RenderBroadphaseHandles, value)) m_RenderBroadphaseHandles = value; } } // 0x21 (33)
		
		protected bool m_RenderDestructionConnections = new bool();
		[ContainerField(Name: "RenderDestructionConnections", Offset: 34, NameHash: 2914715028, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderDestructionConnections { get { return m_RenderDestructionConnections; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderDestructionConnections), this, m_RenderDestructionConnections, value)) m_RenderDestructionConnections = value; } } // 0x22 (34)
		
		protected bool m_RenderPartBoundingBoxes = new bool();
		[ContainerField(Name: "RenderPartBoundingBoxes", Offset: 35, NameHash: 2232082089, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderPartBoundingBoxes { get { return m_RenderPartBoundingBoxes; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderPartBoundingBoxes), this, m_RenderPartBoundingBoxes, value)) m_RenderPartBoundingBoxes = value; } } // 0x23 (35)
		
		protected bool m_RenderOnlyBoundingBoxes = new bool();
		[ContainerField(Name: "RenderOnlyBoundingBoxes", Offset: 36, NameHash: 801403754, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderOnlyBoundingBoxes { get { return m_RenderOnlyBoundingBoxes; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderOnlyBoundingBoxes), this, m_RenderOnlyBoundingBoxes, value)) m_RenderOnlyBoundingBoxes = value; } } // 0x24 (36)
		
		protected bool m_RenderInertia = new bool();
		[ContainerField(Name: "RenderInertia", Offset: 37, NameHash: 2020564867, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderInertia { get { return m_RenderInertia; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderInertia), this, m_RenderInertia, value)) m_RenderInertia = value; } } // 0x25 (37)
		
		protected bool m_RenderCenterOfMass = new bool();
		[ContainerField(Name: "RenderCenterOfMass", Offset: 38, NameHash: 1509980545, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderCenterOfMass { get { return m_RenderCenterOfMass; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderCenterOfMass), this, m_RenderCenterOfMass, value)) m_RenderCenterOfMass = value; } } // 0x26 (38)
		
		protected bool m_RenderLinearVelocity = new bool();
		[ContainerField(Name: "RenderLinearVelocity", Offset: 39, NameHash: 2736551685, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderLinearVelocity { get { return m_RenderLinearVelocity; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderLinearVelocity), this, m_RenderLinearVelocity, value)) m_RenderLinearVelocity = value; } } // 0x27 (39)
		
		protected bool m_RenderCollidesWithTerrain = new bool();
		[ContainerField(Name: "RenderCollidesWithTerrain", Offset: 40, NameHash: 1611516749, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderCollidesWithTerrain { get { return m_RenderCollidesWithTerrain; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderCollidesWithTerrain), this, m_RenderCollidesWithTerrain, value)) m_RenderCollidesWithTerrain = value; } } // 0x28 (40)
		
		protected bool m_RenderCollisionSpheres = new bool();
		[ContainerField(Name: "RenderCollisionSpheres", Offset: 41, NameHash: 4255455419, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderCollisionSpheres { get { return m_RenderCollisionSpheres; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderCollisionSpheres), this, m_RenderCollisionSpheres, value)) m_RenderCollisionSpheres = value; } } // 0x29 (41)
		
		protected bool m_RenderEntityStats = new bool();
		[ContainerField(Name: "RenderEntityStats", Offset: 42, NameHash: 650811029, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderEntityStats { get { return m_RenderEntityStats; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderEntityStats), this, m_RenderEntityStats, value)) m_RenderEntityStats = value; } } // 0x2A (42)
		
		protected bool m_RenderWorldStats = new bool();
		[ContainerField(Name: "RenderWorldStats", Offset: 43, NameHash: 1996031596, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderWorldStats { get { return m_RenderWorldStats; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderWorldStats), this, m_RenderWorldStats, value)) m_RenderWorldStats = value; } } // 0x2B (43)
		
		protected bool m_ShowContactsInWorldStats = new bool();
		[ContainerField(Name: "ShowContactsInWorldStats", Offset: 44, NameHash: 3637824817, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShowContactsInWorldStats { get { return m_ShowContactsInWorldStats; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(ShowContactsInWorldStats), this, m_ShowContactsInWorldStats, value)) m_ShowContactsInWorldStats = value; } } // 0x2C (44)
		
		protected bool m_ShowInactiveContactsInWorldStats = new bool();
		[ContainerField(Name: "ShowInactiveContactsInWorldStats", Offset: 45, NameHash: 136806810, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShowInactiveContactsInWorldStats { get { return m_ShowInactiveContactsInWorldStats; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(ShowInactiveContactsInWorldStats), this, m_ShowInactiveContactsInWorldStats, value)) m_ShowInactiveContactsInWorldStats = value; } } // 0x2D (45)
		
		protected bool m_ShowPhantomsInWorldStats = new bool();
		[ContainerField(Name: "ShowPhantomsInWorldStats", Offset: 46, NameHash: 1465325232, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShowPhantomsInWorldStats { get { return m_ShowPhantomsInWorldStats; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(ShowPhantomsInWorldStats), this, m_ShowPhantomsInWorldStats, value)) m_ShowPhantomsInWorldStats = value; } } // 0x2E (46)
		
		protected bool m_ShowFixedObjectsInWorldStats = new bool();
		[ContainerField(Name: "ShowFixedObjectsInWorldStats", Offset: 47, NameHash: 2576062898, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShowFixedObjectsInWorldStats { get { return m_ShowFixedObjectsInWorldStats; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(ShowFixedObjectsInWorldStats), this, m_ShowFixedObjectsInWorldStats, value)) m_ShowFixedObjectsInWorldStats = value; } } // 0x2F (47)
		
		protected bool m_RenderMemoryUsed = new bool();
		[ContainerField(Name: "RenderMemoryUsed", Offset: 48, NameHash: 4211851593, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderMemoryUsed { get { return m_RenderMemoryUsed; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderMemoryUsed), this, m_RenderMemoryUsed, value)) m_RenderMemoryUsed = value; } } // 0x30 (48)
		
		protected bool m_CollisionSpawnDebug = new bool();
		[ContainerField(Name: "CollisionSpawnDebug", Offset: 49, NameHash: 3965865489, Flags: 49325), LayoutImmutable, Blittable]
		public bool CollisionSpawnDebug { get { return m_CollisionSpawnDebug; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(CollisionSpawnDebug), this, m_CollisionSpawnDebug, value)) m_CollisionSpawnDebug = value; } } // 0x31 (49)
		
		protected bool m_RenderServer = new bool();
		[ContainerField(Name: "RenderServer", Offset: 50, NameHash: 1547064682, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderServer { get { return m_RenderServer; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderServer), this, m_RenderServer, value)) m_RenderServer = value; } } // 0x32 (50)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4286518232:
					RenderSpecificPart = (int) p_Value;
					break;

				case 2201945291:
					ViewDistance = (float) p_Value;
					break;

				case 913404726:
					RenderClient = (bool) p_Value;
					break;

				case 1824683034:
					RenderEffectWorld = (bool) p_Value;
					break;

				case 961029854:
					RenderDetail = (bool) p_Value;
					break;

				case 1529820951:
					RenderStatic = (bool) p_Value;
					break;

				case 347264234:
					RenderUngrouped = (bool) p_Value;
					break;

				case 3960799760:
					RenderRagdoll = (bool) p_Value;
					break;

				case 2757014864:
					RenderGroup = (bool) p_Value;
					break;

				case 2016203773:
					RenderPhantoms = (bool) p_Value;
					break;

				case 3110574600:
					RenderCharacterCollision = (bool) p_Value;
					break;

				case 2775439226:
					RenderWater = (bool) p_Value;
					break;

				case 2704633192:
					RenderSolidGeometry = (bool) p_Value;
					break;

				case 2012203077:
					UseShapeCache = (bool) p_Value;
					break;

				case 3785323737:
					RenderConstraints = (bool) p_Value;
					break;

				case 840353645:
					RenderOnlyContactConstraints = (bool) p_Value;
					break;

				case 3706029321:
					RenderConstraintCount = (bool) p_Value;
					break;

				case 3147515589:
					RenderActiveConstraintCount = (bool) p_Value;
					break;

				case 1511950866:
					RenderSimulationIslands = (bool) p_Value;
					break;

				case 3537504867:
					RenderBroadphaseHandles = (bool) p_Value;
					break;

				case 2914715028:
					RenderDestructionConnections = (bool) p_Value;
					break;

				case 2232082089:
					RenderPartBoundingBoxes = (bool) p_Value;
					break;

				case 801403754:
					RenderOnlyBoundingBoxes = (bool) p_Value;
					break;

				case 2020564867:
					RenderInertia = (bool) p_Value;
					break;

				case 1509980545:
					RenderCenterOfMass = (bool) p_Value;
					break;

				case 2736551685:
					RenderLinearVelocity = (bool) p_Value;
					break;

				case 1611516749:
					RenderCollidesWithTerrain = (bool) p_Value;
					break;

				case 4255455419:
					RenderCollisionSpheres = (bool) p_Value;
					break;

				case 650811029:
					RenderEntityStats = (bool) p_Value;
					break;

				case 1996031596:
					RenderWorldStats = (bool) p_Value;
					break;

				case 3637824817:
					ShowContactsInWorldStats = (bool) p_Value;
					break;

				case 136806810:
					ShowInactiveContactsInWorldStats = (bool) p_Value;
					break;

				case 1465325232:
					ShowPhantomsInWorldStats = (bool) p_Value;
					break;

				case 2576062898:
					ShowFixedObjectsInWorldStats = (bool) p_Value;
					break;

				case 4211851593:
					RenderMemoryUsed = (bool) p_Value;
					break;

				case 3965865489:
					CollisionSpawnDebug = (bool) p_Value;
					break;

				case 1547064682:
					RenderServer = (bool) p_Value;
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
				case 4286518232:
					return RenderSpecificPart;

				case 2201945291:
					return ViewDistance;

				case 913404726:
					return RenderClient;

				case 1824683034:
					return RenderEffectWorld;

				case 961029854:
					return RenderDetail;

				case 1529820951:
					return RenderStatic;

				case 347264234:
					return RenderUngrouped;

				case 3960799760:
					return RenderRagdoll;

				case 2757014864:
					return RenderGroup;

				case 2016203773:
					return RenderPhantoms;

				case 3110574600:
					return RenderCharacterCollision;

				case 2775439226:
					return RenderWater;

				case 2704633192:
					return RenderSolidGeometry;

				case 2012203077:
					return UseShapeCache;

				case 3785323737:
					return RenderConstraints;

				case 840353645:
					return RenderOnlyContactConstraints;

				case 3706029321:
					return RenderConstraintCount;

				case 3147515589:
					return RenderActiveConstraintCount;

				case 1511950866:
					return RenderSimulationIslands;

				case 3537504867:
					return RenderBroadphaseHandles;

				case 2914715028:
					return RenderDestructionConnections;

				case 2232082089:
					return RenderPartBoundingBoxes;

				case 801403754:
					return RenderOnlyBoundingBoxes;

				case 2020564867:
					return RenderInertia;

				case 1509980545:
					return RenderCenterOfMass;

				case 2736551685:
					return RenderLinearVelocity;

				case 1611516749:
					return RenderCollidesWithTerrain;

				case 4255455419:
					return RenderCollisionSpheres;

				case 650811029:
					return RenderEntityStats;

				case 1996031596:
					return RenderWorldStats;

				case 3637824817:
					return ShowContactsInWorldStats;

				case 136806810:
					return ShowInactiveContactsInWorldStats;

				case 1465325232:
					return ShowPhantomsInWorldStats;

				case 2576062898:
					return ShowFixedObjectsInWorldStats;

				case 4211851593:
					return RenderMemoryUsed;

				case 3965865489:
					return CollisionSpawnDebug;

				case 1547064682:
					return RenderServer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4286518232:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderSpecificPart));

				case 2201945291:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(ViewDistance));

				case 913404726:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderClient));

				case 1824683034:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderEffectWorld));

				case 961029854:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderDetail));

				case 1529820951:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderStatic));

				case 347264234:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderUngrouped));

				case 3960799760:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderRagdoll));

				case 2757014864:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderGroup));

				case 2016203773:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderPhantoms));

				case 3110574600:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderCharacterCollision));

				case 2775439226:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderWater));

				case 2704633192:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderSolidGeometry));

				case 2012203077:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(UseShapeCache));

				case 3785323737:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderConstraints));

				case 840353645:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderOnlyContactConstraints));

				case 3706029321:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderConstraintCount));

				case 3147515589:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderActiveConstraintCount));

				case 1511950866:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderSimulationIslands));

				case 3537504867:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderBroadphaseHandles));

				case 2914715028:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderDestructionConnections));

				case 2232082089:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderPartBoundingBoxes));

				case 801403754:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderOnlyBoundingBoxes));

				case 2020564867:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderInertia));

				case 1509980545:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderCenterOfMass));

				case 2736551685:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderLinearVelocity));

				case 1611516749:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderCollidesWithTerrain));

				case 4255455419:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderCollisionSpheres));

				case 650811029:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderEntityStats));

				case 1996031596:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderWorldStats));

				case 3637824817:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(ShowContactsInWorldStats));

				case 136806810:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(ShowInactiveContactsInWorldStats));

				case 1465325232:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(ShowPhantomsInWorldStats));

				case 2576062898:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(ShowFixedObjectsInWorldStats));

				case 4211851593:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderMemoryUsed));

				case 3965865489:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(CollisionSpawnDebug));

				case 1547064682:
					return typeof(PhysicsRenderSettings).GetProperty(nameof(RenderServer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
