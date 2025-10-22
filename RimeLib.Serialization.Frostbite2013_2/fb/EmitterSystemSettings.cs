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

namespace fb.Emitter;

[ContainerType(8, 168)]
public class EmitterSystemSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint SkipUpdateMaxCount { get; set; } = 0;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public int ForceJobCount { get; set; } = -1;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float TimeScale { get; set; } = 1.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float GlobalResetStartTimeInterval { get; set; } = 0.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint CollisionRayCastMaxCount { get; set; } = 50;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint ProximityPhysicsEntitiesMaxCount { get; set; } = 50;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public QualityLevel EmitterQualityLevel { get; set; } = QualityLevel.QualityLevel_Low;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float TemplateTimeoutTime { get; set; } = 10.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float ScreenAreaCullingStart { get; set; } = 0.500f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float ScreenAreaCullingEnd { get; set; } = 2.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float ScreenAreaCullingMinTotalArea { get; set; } = 50.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float ScreenAreaCullingMaxTotalArea { get; set; } = 90.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float ScreenAreaCullingMaxMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float ProcessJobYieldTime { get; set; } = 0.500f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float VisibleJobYieldTime { get; set; } = 0.500f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public uint DrawStats { get; set; } = 0;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public uint DrawBoundingBoxes { get; set; } = 0;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float MinScreenArea { get; set; } = 0.015f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public uint DrawDebugAtlasMiplevel { get; set; } = 0;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public int DrawDebugAtlasTextureIndex { get; set; } = -1;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public int QuadTechnique { get; set; } = -1;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float QuadNearFadeDistance { get; set; } = 0.800f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public uint QuadMaxCount { get; set; } = 6000;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float MeshCullingDistance { get; set; } = 150.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public uint MeshDrawCountLimit { get; set; } = 1000;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float MeshStreamingPriorityMultiplier { get; set; } = 4.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public uint MeshMaxCount { get; set; } = 2000;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x7d), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
	public bool UpdateJobEnable { get; set; } = true;
	
	[ContainerField(0x7e), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
	public bool EnableFixedTimeStep { get; set; } = false;
	
	[ContainerField(0x7f), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
	public bool EnableFixedDelta { get; set; } = false;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public bool EnableJobs { get; set; } = true;
	
	[ContainerField(0x81), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
	public bool CollisionRayCastEnable { get; set; } = true;
	
	[ContainerField(0x82), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
	public bool DrawDebugRayCastCollision { get; set; } = false;
	
	[ContainerField(0x83), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
	public bool EnableRendering { get; set; } = false;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public bool ZBufferCullEnable { get; set; } = true;
	
	[ContainerField(0x85), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
	public bool DrawProjectedBoxes { get; set; } = false;
	
	[ContainerField(0x86), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
	public bool DrawTransforms { get; set; } = false;
	
	[ContainerField(0x87), LayoutImmutable, Blittable, JsonProperty(Order = 135)]
	public bool DrawDebugBaseAtlas { get; set; } = false;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public bool DrawDebugNormalAtlas { get; set; } = false;
	
	[ContainerField(0x89), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
	public bool QuadClipScaleEnable { get; set; } = true;
	
	[ContainerField(0x8a), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
	public bool QuadEnableRendering { get; set; } = true;
	
	[ContainerField(0x8b), LayoutImmutable, Blittable, JsonProperty(Order = 139)]
	public bool QuadNiceRenderingEnable { get; set; } = true;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public bool QuadSimpleRenderingEnable { get; set; } = true;
	
	[ContainerField(0x8d), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
	public bool QuadEnableOpaque { get; set; } = true;
	
	[ContainerField(0x8e), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
	public bool QuadEnableCustomShader { get; set; } = true;
	
	[ContainerField(0x8f), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
	public bool QuadColorShaderCostsEnable { get; set; } = false;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public bool QuadEnableSorting { get; set; } = true;
	
	[ContainerField(0x91), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
	public bool QuadEnableWireframe { get; set; } = false;
	
	[ContainerField(0x92), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
	public bool QuadHalfResEnable { get; set; } = true;
	
	[ContainerField(0x93), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
	public bool QuadGroupsJoinAll { get; set; } = false;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public bool QuadGroupsJoinNone { get; set; } = false;
	
	[ContainerField(0x95), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
	public bool QuadGroupsJoinNiceAndSimple { get; set; } = false;
	
	[ContainerField(0x96), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
	public bool QuadVertexShadowsEnable { get; set; } = true;
	
	[ContainerField(0x97), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
	public bool QuadCloudVertexShadowsEnable { get; set; } = true;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public bool QuadPlanarReflectionEnable { get; set; } = true;
	
	[ContainerField(0x99), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
	public bool QuadPointLightsEnable { get; set; } = true;
	
	[ContainerField(0x9a), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
	public bool QuadSpotLightsEnable { get; set; } = true;
	
	[ContainerField(0x9b), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
	public bool QuadResourceSyncJobEnable { get; set; } = true;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public bool MeshRenderingEnable { get; set; } = true;
	
	[ContainerField(0x9d), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
	public bool MeshDrawTransforms { get; set; } = false;
	
	[ContainerField(0x9e), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
	public bool MeshDrawBoundingBoxes { get; set; } = false;
	
	[ContainerField(0x9f), LayoutImmutable, Blittable, JsonProperty(Order = 159)]
	public bool MeshShadowEnable { get; set; } = true;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public bool MeshPlanarReflectionEnable { get; set; } = true;
	
	[ContainerField(0xa1), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
	public bool MeshDrawCullStats { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SkipUpdateMaxCount);
		p_Writer.Write(ForceJobCount);
		p_Writer.Write(TimeScale);
		p_Writer.Write(GlobalResetStartTimeInterval);
		p_Writer.Write(CollisionRayCastMaxCount);
		p_Writer.Write(ProximityPhysicsEntitiesMaxCount);
		p_Writer.Write((int) EmitterQualityLevel);
		p_Writer.Write(TemplateTimeoutTime);
		p_Writer.Write(ScreenAreaCullingStart);
		p_Writer.Write(ScreenAreaCullingEnd);
		p_Writer.Write(ScreenAreaCullingMinTotalArea);
		p_Writer.Write(ScreenAreaCullingMaxTotalArea);
		p_Writer.Write(ScreenAreaCullingMaxMultiplier);
		p_Writer.Write(ProcessJobYieldTime);
		p_Writer.Write(VisibleJobYieldTime);
		p_Writer.Write(DrawStats);
		p_Writer.Write(DrawBoundingBoxes);
		p_Writer.Write(MinScreenArea);
		p_Writer.Write(DrawDebugAtlasMiplevel);
		p_Writer.Write(DrawDebugAtlasTextureIndex);
		p_Writer.Write(QuadTechnique);
		p_Writer.Write(QuadNearFadeDistance);
		p_Writer.Write(QuadMaxCount);
		p_Writer.Write(MeshCullingDistance);
		p_Writer.Write(MeshDrawCountLimit);
		p_Writer.Write(MeshStreamingPriorityMultiplier);
		p_Writer.Write(MeshMaxCount);
		p_Writer.Write(Enable);
		p_Writer.Write(UpdateJobEnable);
		p_Writer.Write(EnableFixedTimeStep);
		p_Writer.Write(EnableFixedDelta);
		p_Writer.Write(EnableJobs);
		p_Writer.Write(CollisionRayCastEnable);
		p_Writer.Write(DrawDebugRayCastCollision);
		p_Writer.Write(EnableRendering);
		p_Writer.Write(ZBufferCullEnable);
		p_Writer.Write(DrawProjectedBoxes);
		p_Writer.Write(DrawTransforms);
		p_Writer.Write(DrawDebugBaseAtlas);
		p_Writer.Write(DrawDebugNormalAtlas);
		p_Writer.Write(QuadClipScaleEnable);
		p_Writer.Write(QuadEnableRendering);
		p_Writer.Write(QuadNiceRenderingEnable);
		p_Writer.Write(QuadSimpleRenderingEnable);
		p_Writer.Write(QuadEnableOpaque);
		p_Writer.Write(QuadEnableCustomShader);
		p_Writer.Write(QuadColorShaderCostsEnable);
		p_Writer.Write(QuadEnableSorting);
		p_Writer.Write(QuadEnableWireframe);
		p_Writer.Write(QuadHalfResEnable);
		p_Writer.Write(QuadGroupsJoinAll);
		p_Writer.Write(QuadGroupsJoinNone);
		p_Writer.Write(QuadGroupsJoinNiceAndSimple);
		p_Writer.Write(QuadVertexShadowsEnable);
		p_Writer.Write(QuadCloudVertexShadowsEnable);
		p_Writer.Write(QuadPlanarReflectionEnable);
		p_Writer.Write(QuadPointLightsEnable);
		p_Writer.Write(QuadSpotLightsEnable);
		p_Writer.Write(QuadResourceSyncJobEnable);
		p_Writer.Write(MeshRenderingEnable);
		p_Writer.Write(MeshDrawTransforms);
		p_Writer.Write(MeshDrawBoundingBoxes);
		p_Writer.Write(MeshShadowEnable);
		p_Writer.Write(MeshPlanarReflectionEnable);
		p_Writer.Write(MeshDrawCullStats);
		p_Writer.WriteNullBytes(6);
	}
}

