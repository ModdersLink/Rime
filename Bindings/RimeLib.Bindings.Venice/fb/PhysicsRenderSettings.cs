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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(52), ContainerClass]
	public class PhysicsRenderSettings : 
		DataContainer
	{
		protected int m_RenderSpecificPart = new int();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4286518232)]
		public int RenderSpecificPart { get { return m_RenderSpecificPart; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderSpecificPart), this, m_RenderSpecificPart, value)) m_RenderSpecificPart = value; } } // 0x8 (8)
		
		protected float m_ViewDistance = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2201945291)]
		public float ViewDistance { get { return m_ViewDistance; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(ViewDistance), this, m_ViewDistance, value)) m_ViewDistance = value; } } // 0xC (12)
		
		protected bool m_RenderClient = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(913404726)]
		public bool RenderClient { get { return m_RenderClient; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderClient), this, m_RenderClient, value)) m_RenderClient = value; } } // 0x10 (16)
		
		protected bool m_RenderEffectWorld = new bool();
		[ContainerField(17), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1824683034)]
		public bool RenderEffectWorld { get { return m_RenderEffectWorld; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderEffectWorld), this, m_RenderEffectWorld, value)) m_RenderEffectWorld = value; } } // 0x11 (17)
		
		protected bool m_RenderDetail = new bool();
		[ContainerField(18), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(961029854)]
		public bool RenderDetail { get { return m_RenderDetail; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderDetail), this, m_RenderDetail, value)) m_RenderDetail = value; } } // 0x12 (18)
		
		protected bool m_RenderStatic = new bool();
		[ContainerField(19), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1529820951)]
		public bool RenderStatic { get { return m_RenderStatic; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderStatic), this, m_RenderStatic, value)) m_RenderStatic = value; } } // 0x13 (19)
		
		protected bool m_RenderUngrouped = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(347264234)]
		public bool RenderUngrouped { get { return m_RenderUngrouped; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderUngrouped), this, m_RenderUngrouped, value)) m_RenderUngrouped = value; } } // 0x14 (20)
		
		protected bool m_RenderRagdoll = new bool();
		[ContainerField(21), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3960799760)]
		public bool RenderRagdoll { get { return m_RenderRagdoll; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderRagdoll), this, m_RenderRagdoll, value)) m_RenderRagdoll = value; } } // 0x15 (21)
		
		protected bool m_RenderGroup = new bool();
		[ContainerField(22), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2757014864)]
		public bool RenderGroup { get { return m_RenderGroup; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderGroup), this, m_RenderGroup, value)) m_RenderGroup = value; } } // 0x16 (22)
		
		protected bool m_RenderPhantoms = new bool();
		[ContainerField(23), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2016203773)]
		public bool RenderPhantoms { get { return m_RenderPhantoms; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderPhantoms), this, m_RenderPhantoms, value)) m_RenderPhantoms = value; } } // 0x17 (23)
		
		protected bool m_RenderCharacterCollision = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3110574600)]
		public bool RenderCharacterCollision { get { return m_RenderCharacterCollision; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderCharacterCollision), this, m_RenderCharacterCollision, value)) m_RenderCharacterCollision = value; } } // 0x18 (24)
		
		protected bool m_RenderWater = new bool();
		[ContainerField(25), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2775439226)]
		public bool RenderWater { get { return m_RenderWater; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderWater), this, m_RenderWater, value)) m_RenderWater = value; } } // 0x19 (25)
		
		protected bool m_RenderSolidGeometry = new bool();
		[ContainerField(26), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2704633192)]
		public bool RenderSolidGeometry { get { return m_RenderSolidGeometry; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderSolidGeometry), this, m_RenderSolidGeometry, value)) m_RenderSolidGeometry = value; } } // 0x1A (26)
		
		protected bool m_UseShapeCache = new bool();
		[ContainerField(27), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2012203077)]
		public bool UseShapeCache { get { return m_UseShapeCache; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(UseShapeCache), this, m_UseShapeCache, value)) m_UseShapeCache = value; } } // 0x1B (27)
		
		protected bool m_RenderConstraints = new bool();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3785323737)]
		public bool RenderConstraints { get { return m_RenderConstraints; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderConstraints), this, m_RenderConstraints, value)) m_RenderConstraints = value; } } // 0x1C (28)
		
		protected bool m_RenderOnlyContactConstraints = new bool();
		[ContainerField(29), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(840353645)]
		public bool RenderOnlyContactConstraints { get { return m_RenderOnlyContactConstraints; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderOnlyContactConstraints), this, m_RenderOnlyContactConstraints, value)) m_RenderOnlyContactConstraints = value; } } // 0x1D (29)
		
		protected bool m_RenderConstraintCount = new bool();
		[ContainerField(30), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3706029321)]
		public bool RenderConstraintCount { get { return m_RenderConstraintCount; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderConstraintCount), this, m_RenderConstraintCount, value)) m_RenderConstraintCount = value; } } // 0x1E (30)
		
		protected bool m_RenderActiveConstraintCount = new bool();
		[ContainerField(31), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3147515589)]
		public bool RenderActiveConstraintCount { get { return m_RenderActiveConstraintCount; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderActiveConstraintCount), this, m_RenderActiveConstraintCount, value)) m_RenderActiveConstraintCount = value; } } // 0x1F (31)
		
		protected bool m_RenderSimulationIslands = new bool();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1511950866)]
		public bool RenderSimulationIslands { get { return m_RenderSimulationIslands; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderSimulationIslands), this, m_RenderSimulationIslands, value)) m_RenderSimulationIslands = value; } } // 0x20 (32)
		
		protected bool m_RenderBroadphaseHandles = new bool();
		[ContainerField(33), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3537504867)]
		public bool RenderBroadphaseHandles { get { return m_RenderBroadphaseHandles; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderBroadphaseHandles), this, m_RenderBroadphaseHandles, value)) m_RenderBroadphaseHandles = value; } } // 0x21 (33)
		
		protected bool m_RenderDestructionConnections = new bool();
		[ContainerField(34), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2914715028)]
		public bool RenderDestructionConnections { get { return m_RenderDestructionConnections; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderDestructionConnections), this, m_RenderDestructionConnections, value)) m_RenderDestructionConnections = value; } } // 0x22 (34)
		
		protected bool m_RenderPartBoundingBoxes = new bool();
		[ContainerField(35), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2232082089)]
		public bool RenderPartBoundingBoxes { get { return m_RenderPartBoundingBoxes; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderPartBoundingBoxes), this, m_RenderPartBoundingBoxes, value)) m_RenderPartBoundingBoxes = value; } } // 0x23 (35)
		
		protected bool m_RenderOnlyBoundingBoxes = new bool();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(801403754)]
		public bool RenderOnlyBoundingBoxes { get { return m_RenderOnlyBoundingBoxes; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderOnlyBoundingBoxes), this, m_RenderOnlyBoundingBoxes, value)) m_RenderOnlyBoundingBoxes = value; } } // 0x24 (36)
		
		protected bool m_RenderInertia = new bool();
		[ContainerField(37), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2020564867)]
		public bool RenderInertia { get { return m_RenderInertia; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderInertia), this, m_RenderInertia, value)) m_RenderInertia = value; } } // 0x25 (37)
		
		protected bool m_RenderCenterOfMass = new bool();
		[ContainerField(38), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1509980545)]
		public bool RenderCenterOfMass { get { return m_RenderCenterOfMass; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderCenterOfMass), this, m_RenderCenterOfMass, value)) m_RenderCenterOfMass = value; } } // 0x26 (38)
		
		protected bool m_RenderLinearVelocity = new bool();
		[ContainerField(39), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2736551685)]
		public bool RenderLinearVelocity { get { return m_RenderLinearVelocity; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderLinearVelocity), this, m_RenderLinearVelocity, value)) m_RenderLinearVelocity = value; } } // 0x27 (39)
		
		protected bool m_RenderCollidesWithTerrain = new bool();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1611516749)]
		public bool RenderCollidesWithTerrain { get { return m_RenderCollidesWithTerrain; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderCollidesWithTerrain), this, m_RenderCollidesWithTerrain, value)) m_RenderCollidesWithTerrain = value; } } // 0x28 (40)
		
		protected bool m_RenderCollisionSpheres = new bool();
		[ContainerField(41), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4255455419)]
		public bool RenderCollisionSpheres { get { return m_RenderCollisionSpheres; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderCollisionSpheres), this, m_RenderCollisionSpheres, value)) m_RenderCollisionSpheres = value; } } // 0x29 (41)
		
		protected bool m_RenderEntityStats = new bool();
		[ContainerField(42), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(650811029)]
		public bool RenderEntityStats { get { return m_RenderEntityStats; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderEntityStats), this, m_RenderEntityStats, value)) m_RenderEntityStats = value; } } // 0x2A (42)
		
		protected bool m_RenderWorldStats = new bool();
		[ContainerField(43), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1996031596)]
		public bool RenderWorldStats { get { return m_RenderWorldStats; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderWorldStats), this, m_RenderWorldStats, value)) m_RenderWorldStats = value; } } // 0x2B (43)
		
		protected bool m_ShowContactsInWorldStats = new bool();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3637824817)]
		public bool ShowContactsInWorldStats { get { return m_ShowContactsInWorldStats; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(ShowContactsInWorldStats), this, m_ShowContactsInWorldStats, value)) m_ShowContactsInWorldStats = value; } } // 0x2C (44)
		
		protected bool m_ShowInactiveContactsInWorldStats = new bool();
		[ContainerField(45), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(136806810)]
		public bool ShowInactiveContactsInWorldStats { get { return m_ShowInactiveContactsInWorldStats; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(ShowInactiveContactsInWorldStats), this, m_ShowInactiveContactsInWorldStats, value)) m_ShowInactiveContactsInWorldStats = value; } } // 0x2D (45)
		
		protected bool m_ShowPhantomsInWorldStats = new bool();
		[ContainerField(46), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1465325232)]
		public bool ShowPhantomsInWorldStats { get { return m_ShowPhantomsInWorldStats; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(ShowPhantomsInWorldStats), this, m_ShowPhantomsInWorldStats, value)) m_ShowPhantomsInWorldStats = value; } } // 0x2E (46)
		
		protected bool m_ShowFixedObjectsInWorldStats = new bool();
		[ContainerField(47), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2576062898)]
		public bool ShowFixedObjectsInWorldStats { get { return m_ShowFixedObjectsInWorldStats; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(ShowFixedObjectsInWorldStats), this, m_ShowFixedObjectsInWorldStats, value)) m_ShowFixedObjectsInWorldStats = value; } } // 0x2F (47)
		
		protected bool m_RenderMemoryUsed = new bool();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4211851593)]
		public bool RenderMemoryUsed { get { return m_RenderMemoryUsed; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(RenderMemoryUsed), this, m_RenderMemoryUsed, value)) m_RenderMemoryUsed = value; } } // 0x30 (48)
		
		protected bool m_CollisionSpawnDebug = new bool();
		[ContainerField(49), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3965865489)]
		public bool CollisionSpawnDebug { get { return m_CollisionSpawnDebug; } set { if (OnPropertyChanging("PhysicsRenderSettings." + nameof(CollisionSpawnDebug), this, m_CollisionSpawnDebug, value)) m_CollisionSpawnDebug = value; } } // 0x31 (49)
		
		protected bool m_RenderServer = new bool();
		[ContainerField(50), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1547064682)]
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
