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
using fb.Render;
using fb.Physics;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 104)]
public class StaticModelGroupMemberData
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public List<LinearTransform> InstanceTransforms { get; set; } = new();
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public List<uint> InstanceObjectVariation { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<bool> InstanceCastSunShadow { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<bool> InstanceCastReflection { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<RadiosityTypeOverride> InstanceRadiosityTypeOverride { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<bool> InstanceTerrainShaderNodesEnable { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<GamePhysicsEntityData> MemberType { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<MeshAsset> MeshAsset { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public uint InstanceCount { get; set; } = 0;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public uint HealthStateEntityManagerId { get; set; } = 0;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public IndexRange PhysicsPartRange { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public uint PhysicsPartCountPerInstance { get; set; } = 0;
	
	[ContainerField(0x54), JsonProperty(Order = 84)]
	public IndexRange NetworkIdRange { get; set; } = new();
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public uint NetworkIdCountPerInstance { get; set; } = 0;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public uint PartComponentCount { get; set; } = 0;
	
}

