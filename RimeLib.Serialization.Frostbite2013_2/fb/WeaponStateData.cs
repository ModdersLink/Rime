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
using fb.Ant;
using fb.Render;
using fb.Entity;
using fb.GameShared;

namespace fb.SoldierShared;

[ContainerType(8, 136)]
public class WeaponStateData
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public List<uint> ReferencedAssetHashes { get; set; } = new();
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public RefArray<BoneFakePhysicsData> BoneFakePhysics { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<ObjectBlueprint> WeaponMesh3p { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<SkinnedMeshAsset> Mesh3p { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AntRef Weapon { get; set; } = new();
	
	[ContainerField(0x34), JsonProperty(Order = 52)]
	public AntRef Weapon3p { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float ZoomMeshTransitionFactor { get; set; } = 1.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float ZoomScaleFactor { get; set; } = 1.000f;
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public List<float> ZoomInOutMeshTransitionFactors { get; set; } = new();
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float KeepAimingTime { get; set; } = 3.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public AnimatedFireEnum AnimatedFireType { get; set; } = AnimatedFireEnum.AnimatedFireAutomatic;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public AnimatedAimingEnum AnimatedAimingType { get; set; } = AnimatedAimingEnum.AnimatedAimingTwoHanded;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float HideProjectileAfterFireTime { get; set; } = 0.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public string ProjectileBoneName { get; set; } = string.Empty;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float UnDeploySpeed { get; set; } = 1.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float DeploySpeed { get; set; } = 1.000f;
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public List<LinearTransform> Mesh3pTransforms { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public bool AlwaysAimHead { get; set; } = true;
	
	[ContainerField(0x81), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
	public bool IsOneHanded { get; set; } = false;
	
	[ContainerField(0x82), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
	public bool PlayDeployAfterFire { get; set; } = false;
	
	[ContainerField(0x83), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
	public bool SkipDeployAnimation { get; set; } = false;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public bool SkipReloadAnimation { get; set; } = false;
	
	[ContainerField(0x85), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
	public bool SkipFireAnimation { get; set; } = false;
	
	[ContainerField(0x86), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
	public bool SendFireWhenPrefiring { get; set; } = false;
	
}

