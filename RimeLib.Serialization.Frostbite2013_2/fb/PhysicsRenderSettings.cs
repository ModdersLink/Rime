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

using fb.Core;

namespace fb.Physics;

[ContainerType(8, 72)]
public class PhysicsRenderSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float ViewDistance { get; set; } = 20.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public int RenderSpecificPart { get; set; } = -1;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public bool RenderServer { get; set; } = false;
	
	[ContainerField(0x19), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
	public bool RenderClient { get; set; } = false;
	
	[ContainerField(0x1a), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
	public bool RenderEffectWorld { get; set; } = false;
	
	[ContainerField(0x1b), LayoutImmutable, Blittable, JsonProperty(Order = 27)]
	public bool RenderStatic { get; set; } = false;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public bool RenderDetail { get; set; } = false;
	
	[ContainerField(0x1d), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
	public bool RenderGroup { get; set; } = false;
	
	[ContainerField(0x1e), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
	public bool RenderUngrouped { get; set; } = true;
	
	[ContainerField(0x1f), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
	public bool RenderRagdoll { get; set; } = false;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool RenderWater { get; set; } = false;
	
	[ContainerField(0x21), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
	public bool RenderPhantoms { get; set; } = false;
	
	[ContainerField(0x22), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
	public bool RenderCharacterCollision { get; set; } = false;
	
	[ContainerField(0x23), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
	public bool RenderSolidGeometry { get; set; } = false;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool UseShapeCache { get; set; } = true;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool RenderConstraints { get; set; } = false;
	
	[ContainerField(0x26), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
	public bool RenderOnlyContactConstraints { get; set; } = false;
	
	[ContainerField(0x27), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
	public bool RenderConstraintCount { get; set; } = false;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool RenderActiveConstraintCount { get; set; } = false;
	
	[ContainerField(0x29), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
	public bool RenderSimulationIslands { get; set; } = false;
	
	[ContainerField(0x2a), LayoutImmutable, Blittable, JsonProperty(Order = 42)]
	public bool RenderBroadphaseHandles { get; set; } = false;
	
	[ContainerField(0x2b), LayoutImmutable, Blittable, JsonProperty(Order = 43)]
	public bool RenderInteractingShapeCount { get; set; } = false;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public bool RenderMidphaseCheckCount { get; set; } = false;
	
	[ContainerField(0x2d), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
	public bool RenderDestructionConnections { get; set; } = false;
	
	[ContainerField(0x2e), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
	public bool RenderActions { get; set; } = false;
	
	[ContainerField(0x2f), LayoutImmutable, Blittable, JsonProperty(Order = 47)]
	public bool RenderSleepStatus { get; set; } = false;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool RenderQualityType { get; set; } = false;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool RenderPartBoundingBoxes { get; set; } = false;
	
	[ContainerField(0x32), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
	public bool RenderOnlyBoundingBoxes { get; set; } = false;
	
	[ContainerField(0x33), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
	public bool RenderRigidBodyTransform { get; set; } = false;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool RenderInertia { get; set; } = false;
	
	[ContainerField(0x35), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
	public bool RenderCenterOfMass { get; set; } = false;
	
	[ContainerField(0x36), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
	public bool RenderLinearVelocity { get; set; } = false;
	
	[ContainerField(0x37), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
	public bool RenderCollidesWithTerrain { get; set; } = false;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool RenderCollisionSpheres { get; set; } = false;
	
	[ContainerField(0x39), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
	public bool RenderEntityStats { get; set; } = true;
	
	[ContainerField(0x3a), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
	public bool RenderWorldStats { get; set; } = false;
	
	[ContainerField(0x3b), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
	public bool ShowContactsInWorldStats { get; set; } = false;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public bool ShowInactiveContactsInWorldStats { get; set; } = false;
	
	[ContainerField(0x3d), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
	public bool ShowPhantomsInWorldStats { get; set; } = false;
	
	[ContainerField(0x3e), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
	public bool ShowFixedObjectsInWorldStats { get; set; } = false;
	
	[ContainerField(0x3f), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
	public bool RenderMemoryUsed { get; set; } = false;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool CollisionSpawnDebug { get; set; } = false;
	
	[ContainerField(0x41), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
	public bool RenderHeatMap { get; set; } = false;
	
	[ContainerField(0x42), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
	public bool RenderHeatMapFromToi { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ViewDistance);
		p_Writer.Write(RenderSpecificPart);
		p_Writer.Write(RenderServer);
		p_Writer.Write(RenderClient);
		p_Writer.Write(RenderEffectWorld);
		p_Writer.Write(RenderStatic);
		p_Writer.Write(RenderDetail);
		p_Writer.Write(RenderGroup);
		p_Writer.Write(RenderUngrouped);
		p_Writer.Write(RenderRagdoll);
		p_Writer.Write(RenderWater);
		p_Writer.Write(RenderPhantoms);
		p_Writer.Write(RenderCharacterCollision);
		p_Writer.Write(RenderSolidGeometry);
		p_Writer.Write(UseShapeCache);
		p_Writer.Write(RenderConstraints);
		p_Writer.Write(RenderOnlyContactConstraints);
		p_Writer.Write(RenderConstraintCount);
		p_Writer.Write(RenderActiveConstraintCount);
		p_Writer.Write(RenderSimulationIslands);
		p_Writer.Write(RenderBroadphaseHandles);
		p_Writer.Write(RenderInteractingShapeCount);
		p_Writer.Write(RenderMidphaseCheckCount);
		p_Writer.Write(RenderDestructionConnections);
		p_Writer.Write(RenderActions);
		p_Writer.Write(RenderSleepStatus);
		p_Writer.Write(RenderQualityType);
		p_Writer.Write(RenderPartBoundingBoxes);
		p_Writer.Write(RenderOnlyBoundingBoxes);
		p_Writer.Write(RenderRigidBodyTransform);
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
		p_Writer.Write(RenderHeatMap);
		p_Writer.Write(RenderHeatMapFromToi);
		p_Writer.WriteNullBytes(5);
	}
}

