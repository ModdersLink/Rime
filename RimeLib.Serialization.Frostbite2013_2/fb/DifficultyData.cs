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

namespace fb.GameShared;

[ContainerType(16, 176)]
public class DifficultyData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public Difficulty Difficulty { get; set; } = fb.GameShared.Difficulty.Difficulty_Easy;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public PersistenceGameType GameType { get; set; } = PersistenceGameType.PersistenceGameType_Singleplayer;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 StickyBoxModifier { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 SnapBoxModifier { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string ReadableName { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float HumanHealthModifier { get; set; } = 1.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float FriendsHealthModifier { get; set; } = 1.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float EnemiesHealthModifier { get; set; } = 1.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float FriendlyDamageModifier { get; set; } = 0.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float VehicleDamageModifier { get; set; } = 1.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float HumanInCriticalHealth { get; set; } = 0.250f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float HumanInCriticalHealthDamageModifier { get; set; } = 0.200f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float HumanRegenerationRateModifier { get; set; } = 1.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float CriticalFakeImmortalModifier { get; set; } = 1.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float InteractiveManDownDamageModifier { get; set; } = 1.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float InteractiveManDownTimeMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float InteractiveManDownReviveTime { get; set; } = 5.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public int AdrenalineKillLimit { get; set; } = -1;
	
	[ContainerField(0x7c), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public Vec2 AttractDistanceFallOffModifier { get; set; } = new()
	{
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float AttractSoftZoneModifier { get; set; } = 1.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float AttractUserInputMultiplierModifier { get; set; } = 1.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float SnapZoomPostTimeNoInputModifier { get; set; } = 1.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float SnapZoomPostTimeModifier { get; set; } = 1.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float SuckZoomModifier { get; set; } = 1.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float AiBulletDamageHumanCooldown { get; set; } = 0.400f;
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<GameAIDifficultyData> AIData { get; set; } = new();
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public bool UsePitchZoomSnap { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Difficulty);
		p_Writer.Write((int) GameType);
		p_Writer.WriteNullBytes(8);
		StickyBoxModifier.Serialize(p_Writer, p_EbxWriter);
		SnapBoxModifier.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ReadableName));
		p_Writer.Write(HumanHealthModifier);
		p_Writer.Write(FriendsHealthModifier);
		p_Writer.Write(EnemiesHealthModifier);
		p_Writer.Write(FriendlyDamageModifier);
		p_Writer.Write(VehicleDamageModifier);
		p_Writer.Write(HumanInCriticalHealth);
		p_Writer.Write(HumanInCriticalHealthDamageModifier);
		p_Writer.Write(HumanRegenerationRateModifier);
		p_Writer.Write(CriticalFakeImmortalModifier);
		p_Writer.Write(InteractiveManDownDamageModifier);
		p_Writer.Write(InteractiveManDownTimeMultiplier);
		p_Writer.Write(InteractiveManDownReviveTime);
		p_Writer.Write(AdrenalineKillLimit);
		AttractDistanceFallOffModifier.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AttractSoftZoneModifier);
		p_Writer.Write(AttractUserInputMultiplierModifier);
		p_Writer.Write(SnapZoomPostTimeNoInputModifier);
		p_Writer.Write(SnapZoomPostTimeModifier);
		p_Writer.Write(SuckZoomModifier);
		p_Writer.Write(AiBulletDamageHumanCooldown);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AIData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(UsePitchZoomSnap);
		p_Writer.WriteNullBytes(7);
	}
}

