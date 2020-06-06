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
	public class PhysicsRenderSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int RenderSpecificPart { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float ViewDistance { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool RenderClient { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool RenderEffectWorld { get; set; } // 0x11 (17)
		
		[ContainerField(18), LayoutImmutable, Blittable]
		public bool RenderDetail { get; set; } // 0x12 (18)
		
		[ContainerField(19), LayoutImmutable, Blittable]
		public bool RenderStatic { get; set; } // 0x13 (19)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool RenderUngrouped { get; set; } // 0x14 (20)
		
		[ContainerField(21), LayoutImmutable, Blittable]
		public bool RenderRagdoll { get; set; } // 0x15 (21)
		
		[ContainerField(22), LayoutImmutable, Blittable]
		public bool RenderGroup { get; set; } // 0x16 (22)
		
		[ContainerField(23), LayoutImmutable, Blittable]
		public bool RenderPhantoms { get; set; } // 0x17 (23)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool RenderCharacterCollision { get; set; } // 0x18 (24)
		
		[ContainerField(25), LayoutImmutable, Blittable]
		public bool RenderWater { get; set; } // 0x19 (25)
		
		[ContainerField(26), LayoutImmutable, Blittable]
		public bool RenderSolidGeometry { get; set; } // 0x1A (26)
		
		[ContainerField(27), LayoutImmutable, Blittable]
		public bool UseShapeCache { get; set; } // 0x1B (27)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool RenderConstraints { get; set; } // 0x1C (28)
		
		[ContainerField(29), LayoutImmutable, Blittable]
		public bool RenderOnlyContactConstraints { get; set; } // 0x1D (29)
		
		[ContainerField(30), LayoutImmutable, Blittable]
		public bool RenderConstraintCount { get; set; } // 0x1E (30)
		
		[ContainerField(31), LayoutImmutable, Blittable]
		public bool RenderActiveConstraintCount { get; set; } // 0x1F (31)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool RenderSimulationIslands { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool RenderBroadphaseHandles { get; set; } // 0x21 (33)
		
		[ContainerField(34), LayoutImmutable, Blittable]
		public bool RenderDestructionConnections { get; set; } // 0x22 (34)
		
		[ContainerField(35), LayoutImmutable, Blittable]
		public bool RenderPartBoundingBoxes { get; set; } // 0x23 (35)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool RenderOnlyBoundingBoxes { get; set; } // 0x24 (36)
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool RenderInertia { get; set; } // 0x25 (37)
		
		[ContainerField(38), LayoutImmutable, Blittable]
		public bool RenderCenterOfMass { get; set; } // 0x26 (38)
		
		[ContainerField(39), LayoutImmutable, Blittable]
		public bool RenderLinearVelocity { get; set; } // 0x27 (39)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool RenderCollidesWithTerrain { get; set; } // 0x28 (40)
		
		[ContainerField(41), LayoutImmutable, Blittable]
		public bool RenderCollisionSpheres { get; set; } // 0x29 (41)
		
		[ContainerField(42), LayoutImmutable, Blittable]
		public bool RenderEntityStats { get; set; } // 0x2A (42)
		
		[ContainerField(43), LayoutImmutable, Blittable]
		public bool RenderWorldStats { get; set; } // 0x2B (43)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool ShowContactsInWorldStats { get; set; } // 0x2C (44)
		
		[ContainerField(45), LayoutImmutable, Blittable]
		public bool ShowInactiveContactsInWorldStats { get; set; } // 0x2D (45)
		
		[ContainerField(46), LayoutImmutable, Blittable]
		public bool ShowPhantomsInWorldStats { get; set; } // 0x2E (46)
		
		[ContainerField(47), LayoutImmutable, Blittable]
		public bool ShowFixedObjectsInWorldStats { get; set; } // 0x2F (47)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public bool RenderMemoryUsed { get; set; } // 0x30 (48)
		
		[ContainerField(49), LayoutImmutable, Blittable]
		public bool CollisionSpawnDebug { get; set; } // 0x31 (49)
		
		[ContainerField(50), LayoutImmutable, Blittable]
		public bool RenderServer { get; set; } // 0x32 (50)
		
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
