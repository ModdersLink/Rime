///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 52)]
	public class PhysicsRenderSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public int RenderSpecificPart { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float ViewDistance { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool RenderClient { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		public bool RenderEffectWorld { get; set; }

		[ContainerField(18), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
		public bool RenderDetail { get; set; }

		[ContainerField(19), LayoutImmutable, Blittable, JsonProperty(Order = 19)]
		public bool RenderStatic { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool RenderUngrouped { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		public bool RenderRagdoll { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
		public bool RenderGroup { get; set; }

		[ContainerField(23), LayoutImmutable, Blittable, JsonProperty(Order = 23)]
		public bool RenderPhantoms { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public bool RenderCharacterCollision { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		public bool RenderWater { get; set; }

		[ContainerField(26), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
		public bool RenderSolidGeometry { get; set; }

		[ContainerField(27), LayoutImmutable, Blittable, JsonProperty(Order = 27)]
		public bool UseShapeCache { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool RenderConstraints { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		public bool RenderOnlyContactConstraints { get; set; }

		[ContainerField(30), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
		public bool RenderConstraintCount { get; set; }

		[ContainerField(31), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
		public bool RenderActiveConstraintCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool RenderSimulationIslands { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool RenderBroadphaseHandles { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		public bool RenderDestructionConnections { get; set; }

		[ContainerField(35), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
		public bool RenderPartBoundingBoxes { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool RenderOnlyBoundingBoxes { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		public bool RenderInertia { get; set; }

		[ContainerField(38), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
		public bool RenderCenterOfMass { get; set; }

		[ContainerField(39), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
		public bool RenderLinearVelocity { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool RenderCollidesWithTerrain { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		public bool RenderCollisionSpheres { get; set; }

		[ContainerField(42), LayoutImmutable, Blittable, JsonProperty(Order = 42)]
		public bool RenderEntityStats { get; set; }

		[ContainerField(43), LayoutImmutable, Blittable, JsonProperty(Order = 43)]
		public bool RenderWorldStats { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool ShowContactsInWorldStats { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		public bool ShowInactiveContactsInWorldStats { get; set; }

		[ContainerField(46), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
		public bool ShowPhantomsInWorldStats { get; set; }

		[ContainerField(47), LayoutImmutable, Blittable, JsonProperty(Order = 47)]
		public bool ShowFixedObjectsInWorldStats { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public bool RenderMemoryUsed { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
		public bool CollisionSpawnDebug { get; set; }

		[ContainerField(50), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
		public bool RenderServer { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(RenderSpecificPart);
			p_Writer.Write(ViewDistance);
			p_Writer.Write(RenderClient);
			p_Writer.Write(RenderEffectWorld);
			p_Writer.Write(RenderDetail);
			p_Writer.Write(RenderStatic);
			p_Writer.Write(RenderUngrouped);
			p_Writer.Write(RenderRagdoll);
			p_Writer.Write(RenderGroup);
			p_Writer.Write(RenderPhantoms);
			p_Writer.Write(RenderCharacterCollision);
			p_Writer.Write(RenderWater);
			p_Writer.Write(RenderSolidGeometry);
			p_Writer.Write(UseShapeCache);
			p_Writer.Write(RenderConstraints);
			p_Writer.Write(RenderOnlyContactConstraints);
			p_Writer.Write(RenderConstraintCount);
			p_Writer.Write(RenderActiveConstraintCount);
			p_Writer.Write(RenderSimulationIslands);
			p_Writer.Write(RenderBroadphaseHandles);
			p_Writer.Write(RenderDestructionConnections);
			p_Writer.Write(RenderPartBoundingBoxes);
			p_Writer.Write(RenderOnlyBoundingBoxes);
			p_Writer.Write(RenderInertia);
			p_Writer.Write(RenderCenterOfMass);
			p_Writer.Write(RenderLinearVelocity);
			p_Writer.Write(RenderCollidesWithTerrain);
			p_Writer.Write(RenderCollisionSpheres);
			p_Writer.Write(RenderEntityStats);
			p_Writer.Write(RenderWorldStats);
			p_Writer.Write(ShowContactsInWorldStats);
			p_Writer.Write(ShowInactiveContactsInWorldStats);
			p_Writer.Write(ShowPhantomsInWorldStats);
			p_Writer.Write(ShowFixedObjectsInWorldStats);
			p_Writer.Write(RenderMemoryUsed);
			p_Writer.Write(CollisionSpawnDebug);
			p_Writer.Write(RenderServer);
			p_Writer.WriteNullBytes(1);
		}
	}
}
