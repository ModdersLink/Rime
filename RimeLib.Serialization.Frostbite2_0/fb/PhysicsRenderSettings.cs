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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 52)]
	public partial class PhysicsRenderSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private int _RenderSpecificPart;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _ViewDistance;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private bool _RenderClient;

		[ObservableProperty]
		[property: ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		private bool _RenderEffectWorld;

		[ObservableProperty]
		[property: ContainerField(18), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
		private bool _RenderDetail;

		[ObservableProperty]
		[property: ContainerField(19), LayoutImmutable, Blittable, JsonProperty(Order = 19)]
		private bool _RenderStatic;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private bool _RenderUngrouped;

		[ObservableProperty]
		[property: ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		private bool _RenderRagdoll;

		[ObservableProperty]
		[property: ContainerField(22), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
		private bool _RenderGroup;

		[ObservableProperty]
		[property: ContainerField(23), LayoutImmutable, Blittable, JsonProperty(Order = 23)]
		private bool _RenderPhantoms;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _RenderCharacterCollision;

		[ObservableProperty]
		[property: ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		private bool _RenderWater;

		[ObservableProperty]
		[property: ContainerField(26), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
		private bool _RenderSolidGeometry;

		[ObservableProperty]
		[property: ContainerField(27), LayoutImmutable, Blittable, JsonProperty(Order = 27)]
		private bool _UseShapeCache;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private bool _RenderConstraints;

		[ObservableProperty]
		[property: ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		private bool _RenderOnlyContactConstraints;

		[ObservableProperty]
		[property: ContainerField(30), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
		private bool _RenderConstraintCount;

		[ObservableProperty]
		[property: ContainerField(31), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
		private bool _RenderActiveConstraintCount;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private bool _RenderSimulationIslands;

		[ObservableProperty]
		[property: ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		private bool _RenderBroadphaseHandles;

		[ObservableProperty]
		[property: ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		private bool _RenderDestructionConnections;

		[ObservableProperty]
		[property: ContainerField(35), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
		private bool _RenderPartBoundingBoxes;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private bool _RenderOnlyBoundingBoxes;

		[ObservableProperty]
		[property: ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		private bool _RenderInertia;

		[ObservableProperty]
		[property: ContainerField(38), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
		private bool _RenderCenterOfMass;

		[ObservableProperty]
		[property: ContainerField(39), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
		private bool _RenderLinearVelocity;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private bool _RenderCollidesWithTerrain;

		[ObservableProperty]
		[property: ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		private bool _RenderCollisionSpheres;

		[ObservableProperty]
		[property: ContainerField(42), LayoutImmutable, Blittable, JsonProperty(Order = 42)]
		private bool _RenderEntityStats;

		[ObservableProperty]
		[property: ContainerField(43), LayoutImmutable, Blittable, JsonProperty(Order = 43)]
		private bool _RenderWorldStats;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private bool _ShowContactsInWorldStats;

		[ObservableProperty]
		[property: ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		private bool _ShowInactiveContactsInWorldStats;

		[ObservableProperty]
		[property: ContainerField(46), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
		private bool _ShowPhantomsInWorldStats;

		[ObservableProperty]
		[property: ContainerField(47), LayoutImmutable, Blittable, JsonProperty(Order = 47)]
		private bool _ShowFixedObjectsInWorldStats;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private bool _RenderMemoryUsed;

		[ObservableProperty]
		[property: ContainerField(49), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
		private bool _CollisionSpawnDebug;

		[ObservableProperty]
		[property: ContainerField(50), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
		private bool _RenderServer;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
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
