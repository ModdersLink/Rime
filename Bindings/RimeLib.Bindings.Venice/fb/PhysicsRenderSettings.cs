///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 52)]
	public class PhysicsRenderSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int RenderSpecificPart { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float ViewDistance { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public bool RenderClient { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable]
		public bool RenderEffectWorld { get; set; }

		[ContainerField(18), LayoutImmutable, Blittable]
		public bool RenderDetail { get; set; }

		[ContainerField(19), LayoutImmutable, Blittable]
		public bool RenderStatic { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool RenderUngrouped { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public bool RenderRagdoll { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable]
		public bool RenderGroup { get; set; }

		[ContainerField(23), LayoutImmutable, Blittable]
		public bool RenderPhantoms { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool RenderCharacterCollision { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool RenderWater { get; set; }

		[ContainerField(26), LayoutImmutable, Blittable]
		public bool RenderSolidGeometry { get; set; }

		[ContainerField(27), LayoutImmutable, Blittable]
		public bool UseShapeCache { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool RenderConstraints { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable]
		public bool RenderOnlyContactConstraints { get; set; }

		[ContainerField(30), LayoutImmutable, Blittable]
		public bool RenderConstraintCount { get; set; }

		[ContainerField(31), LayoutImmutable, Blittable]
		public bool RenderActiveConstraintCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool RenderSimulationIslands { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool RenderBroadphaseHandles { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable]
		public bool RenderDestructionConnections { get; set; }

		[ContainerField(35), LayoutImmutable, Blittable]
		public bool RenderPartBoundingBoxes { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool RenderOnlyBoundingBoxes { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable]
		public bool RenderInertia { get; set; }

		[ContainerField(38), LayoutImmutable, Blittable]
		public bool RenderCenterOfMass { get; set; }

		[ContainerField(39), LayoutImmutable, Blittable]
		public bool RenderLinearVelocity { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool RenderCollidesWithTerrain { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable]
		public bool RenderCollisionSpheres { get; set; }

		[ContainerField(42), LayoutImmutable, Blittable]
		public bool RenderEntityStats { get; set; }

		[ContainerField(43), LayoutImmutable, Blittable]
		public bool RenderWorldStats { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool ShowContactsInWorldStats { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable]
		public bool ShowInactiveContactsInWorldStats { get; set; }

		[ContainerField(46), LayoutImmutable, Blittable]
		public bool ShowPhantomsInWorldStats { get; set; }

		[ContainerField(47), LayoutImmutable, Blittable]
		public bool ShowFixedObjectsInWorldStats { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool RenderMemoryUsed { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable]
		public bool CollisionSpawnDebug { get; set; }

		[ContainerField(50), LayoutImmutable, Blittable]
		public bool RenderServer { get; set; }

		public static void Deserialize(PhysicsRenderSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RenderSpecificPart = p_Reader.ReadInt32();
			p_Instance.ViewDistance = p_Reader.ReadSingle();
			p_Instance.RenderClient = p_Reader.ReadBool();
			p_Instance.RenderEffectWorld = p_Reader.ReadBool();
			p_Instance.RenderDetail = p_Reader.ReadBool();
			p_Instance.RenderStatic = p_Reader.ReadBool();
			p_Instance.RenderUngrouped = p_Reader.ReadBool();
			p_Instance.RenderRagdoll = p_Reader.ReadBool();
			p_Instance.RenderGroup = p_Reader.ReadBool();
			p_Instance.RenderPhantoms = p_Reader.ReadBool();
			p_Instance.RenderCharacterCollision = p_Reader.ReadBool();
			p_Instance.RenderWater = p_Reader.ReadBool();
			p_Instance.RenderSolidGeometry = p_Reader.ReadBool();
			p_Instance.UseShapeCache = p_Reader.ReadBool();
			p_Instance.RenderConstraints = p_Reader.ReadBool();
			p_Instance.RenderOnlyContactConstraints = p_Reader.ReadBool();
			p_Instance.RenderConstraintCount = p_Reader.ReadBool();
			p_Instance.RenderActiveConstraintCount = p_Reader.ReadBool();
			p_Instance.RenderSimulationIslands = p_Reader.ReadBool();
			p_Instance.RenderBroadphaseHandles = p_Reader.ReadBool();
			p_Instance.RenderDestructionConnections = p_Reader.ReadBool();
			p_Instance.RenderPartBoundingBoxes = p_Reader.ReadBool();
			p_Instance.RenderOnlyBoundingBoxes = p_Reader.ReadBool();
			p_Instance.RenderInertia = p_Reader.ReadBool();
			p_Instance.RenderCenterOfMass = p_Reader.ReadBool();
			p_Instance.RenderLinearVelocity = p_Reader.ReadBool();
			p_Instance.RenderCollidesWithTerrain = p_Reader.ReadBool();
			p_Instance.RenderCollisionSpheres = p_Reader.ReadBool();
			p_Instance.RenderEntityStats = p_Reader.ReadBool();
			p_Instance.RenderWorldStats = p_Reader.ReadBool();
			p_Instance.ShowContactsInWorldStats = p_Reader.ReadBool();
			p_Instance.ShowInactiveContactsInWorldStats = p_Reader.ReadBool();
			p_Instance.ShowPhantomsInWorldStats = p_Reader.ReadBool();
			p_Instance.ShowFixedObjectsInWorldStats = p_Reader.ReadBool();
			p_Instance.RenderMemoryUsed = p_Reader.ReadBool();
			p_Instance.CollisionSpawnDebug = p_Reader.ReadBool();
			p_Instance.RenderServer = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
