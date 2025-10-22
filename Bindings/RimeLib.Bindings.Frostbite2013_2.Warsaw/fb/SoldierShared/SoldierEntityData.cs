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

using fb.GameShared;
using fb.Core;
using fb.Physics;
using fb.Entity;
using fb.Audio;

namespace fb.SoldierShared;

[ContainerType(16, 384)]
public class SoldierEntityData
	: fb.GameShared.CharacterEntityData
{
	[ContainerField(0xe0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public Vec3 FLIRKeyColor { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public MaterialDecl FootMaterialPair { get; set; } = new();
	
	[ContainerField(0xf4), JsonProperty(Order = 244)]
	public MaterialDecl HeadMaterialPair { get; set; } = new();
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public RefArray<BoneFakePhysicsData> BoneFakePhysics { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public CtrRef<SoldierAutoAimData> AutoAim { get; set; } = new();
	
	[ContainerField(0x108), JsonProperty(Order = 264)]
	public CtrRef<SoldierAimingConstraintsData> AimingConstraints { get; set; } = new();
	
	[ContainerField(0x110), JsonProperty(Order = 272)]
	public CtrRef<SoldierHeadCollisionData> HeadCollision { get; set; } = new();
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public CtrRef<CharacterPhysicsData> CharacterPhysics { get; set; } = new();
	
	[ContainerField(0x120), JsonProperty(Order = 288)]
	public CtrRef<SoldierSprintSettingsData> SprintSettings { get; set; } = new();
	
	[ContainerField(0x128), JsonProperty(Order = 296)]
	public List<HidableSoldierMeshWeaponPart> HidableMeshParts { get; set; } = new();
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float ImpulseReactionTime { get; set; } = 0.000f;
	
	[ContainerField(0x138), JsonProperty(Order = 312)]
	public CtrRef<SoldierHealthModuleData> HealthModule { get; set; } = new();
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public List<int> AbortSpawnInvisibilityInputs { get; set; } = new();
	
	[ContainerField(0x148), JsonProperty(Order = 328)]
	public RefArray<BreathControlData> BreathControl { get; set; } = new();
	
	[ContainerField(0x150), JsonProperty(Order = 336)]
	public CtrRef<CollisionData> CollisionInfo { get; set; } = new();
	
	[ContainerField(0x158), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
	public float FLIRValue { get; set; } = 1.000f;
	
	[ContainerField(0x15c), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
	public float ExplosionDamageModifier { get; set; } = 1.000f;
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public float RegenerationDelayModifier { get; set; } = 1.000f;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public float FallDamageThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public bool UseSpineXRotation { get; set; } = false;
	
	[ContainerField(0x169), LayoutImmutable, Blittable, JsonProperty(Order = 361)]
	public bool ShowWeaponWhenDead { get; set; } = false;
	
	[ContainerField(0x16a), LayoutImmutable, Blittable, JsonProperty(Order = 362)]
	public bool EnableGroundmapLighting { get; set; } = false;
	
	[ContainerField(0x16b), LayoutImmutable, Blittable, JsonProperty(Order = 363)]
	public bool LowerGunOnOwnTeam { get; set; } = true;
	
	[ContainerField(0x16c), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
	public bool ProximityCheck { get; set; } = false;
	
	[ContainerField(0x16d), LayoutImmutable, Blittable, JsonProperty(Order = 365)]
	public bool FreeSpaceCheck { get; set; } = false;
	
	[ContainerField(0x16e), LayoutImmutable, Blittable, JsonProperty(Order = 366)]
	public bool CollisionEnabled { get; set; } = true;
	
	[ContainerField(0x16f), LayoutImmutable, Blittable, JsonProperty(Order = 367)]
	public bool PhysicsControlled { get; set; } = true;
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public bool IsPushable { get; set; } = true;
	
	[ContainerField(0x171), LayoutImmutable, Blittable, JsonProperty(Order = 369)]
	public bool HumanPlayerControlled { get; set; } = true;
	
	[ContainerField(0x172), LayoutImmutable, Blittable, JsonProperty(Order = 370)]
	public bool InteractiveManDownAllowed { get; set; } = true;
	
	[ContainerField(0x173), LayoutImmutable, Blittable, JsonProperty(Order = 371)]
	public bool ShowNametag { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		FLIRKeyColor.Serialize(p_Writer, p_EbxWriter);
		FootMaterialPair.Serialize(p_Writer, p_EbxWriter);
		HeadMaterialPair.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_BoneFakePhysics = p_EbxWriter.GetArrayWriter(BoneFakePhysics.GetType(), BoneFakePhysics.Count);
		p_Writer.Write(s_BoneFakePhysics.ArrayIndex);
		foreach (var s_Entry in BoneFakePhysics)
		{
			s_BoneFakePhysics.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AutoAim));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AimingConstraints));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HeadCollision));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CharacterPhysics));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SprintSettings));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_HidableMeshParts = p_EbxWriter.GetArrayWriter(HidableMeshParts.GetType(), HidableMeshParts.Count);
		p_Writer.Write(s_HidableMeshParts.ArrayIndex);
		foreach (var s_Entry in HidableMeshParts)
		{
			s_Entry.Serialize(s_HidableMeshParts.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ImpulseReactionTime);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HealthModule));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_AbortSpawnInvisibilityInputs = p_EbxWriter.GetArrayWriter(AbortSpawnInvisibilityInputs.GetType(), AbortSpawnInvisibilityInputs.Count);
		p_Writer.Write(s_AbortSpawnInvisibilityInputs.ArrayIndex);
		foreach (var s_Entry in AbortSpawnInvisibilityInputs)
		{
			s_AbortSpawnInvisibilityInputs.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_BreathControl = p_EbxWriter.GetArrayWriter(BreathControl.GetType(), BreathControl.Count);
		p_Writer.Write(s_BreathControl.ArrayIndex);
		foreach (var s_Entry in BreathControl)
		{
			s_BreathControl.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CollisionInfo));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(FLIRValue);
		p_Writer.Write(ExplosionDamageModifier);
		p_Writer.Write(RegenerationDelayModifier);
		p_Writer.Write(FallDamageThreshold);
		p_Writer.Write(UseSpineXRotation);
		p_Writer.Write(ShowWeaponWhenDead);
		p_Writer.Write(EnableGroundmapLighting);
		p_Writer.Write(LowerGunOnOwnTeam);
		p_Writer.Write(ProximityCheck);
		p_Writer.Write(FreeSpaceCheck);
		p_Writer.Write(CollisionEnabled);
		p_Writer.Write(PhysicsControlled);
		p_Writer.Write(IsPushable);
		p_Writer.Write(HumanPlayerControlled);
		p_Writer.Write(InteractiveManDownAllowed);
		p_Writer.Write(ShowNametag);
		p_Writer.WriteNullBytes(12);
	}
}

