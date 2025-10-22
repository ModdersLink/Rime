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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 368)]
public class SpawnReferenceObjectData
	: fb.Entity.ReferenceObjectData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public LinearTransform ControllableTransform { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0xc0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public LinearTransform ControllableInput { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public RefArray<ExtraSpawnData> ExtraSpawnData { get; set; } = new();
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public string LocationNameSid { get; set; } = string.Empty;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public string LocationTextSid { get; set; } = string.Empty;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public TeamId Team { get; set; } = TeamId.Team2;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public float InitialSpawnDelay { get; set; } = 0.000f;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float SpawnDelay { get; set; } = 0.000f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public int MaxCount { get; set; } = 1;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public int MaxCountSimultaneously { get; set; } = 0;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public int TotalCountSimultaneouslyOfType { get; set; } = 0;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float SpawnAreaRadius { get; set; } = 0.000f;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public float SpawnProtectionRadius { get; set; } = 0.000f;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public uint SpawnProtectionFriendlyKilledCount { get; set; } = 0;
	
	[ContainerField(0x13c), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
	public float SpawnProtectionFriendlyKilledTime { get; set; } = 30.000f;
	
	[ContainerField(0x140), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public int TakeControlEntryIndex { get; set; } = 0;
	
	[ContainerField(0x144), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
	public float RotationYaw { get; set; } = 0.000f;
	
	[ContainerField(0x148), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
	public float RotationPitch { get; set; } = 0.000f;
	
	[ContainerField(0x14c), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
	public float RotationRoll { get; set; } = 0.000f;
	
	[ContainerField(0x150), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public float Throttle { get; set; } = 0.000f;
	
	[ContainerField(0x154), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
	public bool Enabled { get; set; } = true;
	
	[ContainerField(0x155), LayoutImmutable, Blittable, JsonProperty(Order = 341)]
	public bool LockedTeam { get; set; } = false;
	
	[ContainerField(0x156), LayoutImmutable, Blittable, JsonProperty(Order = 342)]
	public bool InitialAutoSpawn { get; set; } = false;
	
	[ContainerField(0x157), LayoutImmutable, Blittable, JsonProperty(Order = 343)]
	public bool AutoSpawn { get; set; } = false;
	
	[ContainerField(0x158), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
	public bool QueueSpawnEvent { get; set; } = true;
	
	[ContainerField(0x159), LayoutImmutable, Blittable, JsonProperty(Order = 345)]
	public bool UseAsSpawnPoint { get; set; } = true;
	
	[ContainerField(0x15a), LayoutImmutable, Blittable, JsonProperty(Order = 346)]
	public bool SpawnProtectionCheckAllTeams { get; set; } = true;
	
	[ContainerField(0x15b), LayoutImmutable, Blittable, JsonProperty(Order = 347)]
	public bool ClearBangersOnSpawn { get; set; } = true;
	
	[ContainerField(0x15c), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
	public bool OnlySendEventForHumanPlayers { get; set; } = true;
	
	[ContainerField(0x15d), LayoutImmutable, Blittable, JsonProperty(Order = 349)]
	public bool SendWeaponEvents { get; set; } = false;
	
	[ContainerField(0x15e), LayoutImmutable, Blittable, JsonProperty(Order = 350)]
	public bool TryToSpawnOutOfSight { get; set; } = false;
	
	[ContainerField(0x15f), LayoutImmutable, Blittable, JsonProperty(Order = 351)]
	public bool TakeControlOnTransformChange { get; set; } = true;
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public bool ReturnControlOnIdle { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		ControllableTransform.Serialize(p_Writer, p_EbxWriter);
		ControllableInput.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ExtraSpawnData = p_EbxWriter.GetArrayWriter(ExtraSpawnData.GetType(), ExtraSpawnData.Count);
		p_Writer.Write(s_ExtraSpawnData.ArrayIndex);
		foreach (var s_Entry in ExtraSpawnData)
		{
			s_ExtraSpawnData.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(LocationNameSid));
		p_Writer.Write(p_EbxWriter.WriteString(LocationTextSid));
		p_Writer.Write((int) Team);
		p_Writer.Write(InitialSpawnDelay);
		p_Writer.Write(SpawnDelay);
		p_Writer.Write(MaxCount);
		p_Writer.Write(MaxCountSimultaneously);
		p_Writer.Write(TotalCountSimultaneouslyOfType);
		p_Writer.Write(SpawnAreaRadius);
		p_Writer.Write(SpawnProtectionRadius);
		p_Writer.Write(SpawnProtectionFriendlyKilledCount);
		p_Writer.Write(SpawnProtectionFriendlyKilledTime);
		p_Writer.Write(TakeControlEntryIndex);
		p_Writer.Write(RotationYaw);
		p_Writer.Write(RotationPitch);
		p_Writer.Write(RotationRoll);
		p_Writer.Write(Throttle);
		p_Writer.Write(Enabled);
		p_Writer.Write(LockedTeam);
		p_Writer.Write(InitialAutoSpawn);
		p_Writer.Write(AutoSpawn);
		p_Writer.Write(QueueSpawnEvent);
		p_Writer.Write(UseAsSpawnPoint);
		p_Writer.Write(SpawnProtectionCheckAllTeams);
		p_Writer.Write(ClearBangersOnSpawn);
		p_Writer.Write(OnlySendEventForHumanPlayers);
		p_Writer.Write(SendWeaponEvents);
		p_Writer.Write(TryToSpawnOutOfSight);
		p_Writer.Write(TakeControlOnTransformChange);
		p_Writer.Write(ReturnControlOnIdle);
		p_Writer.WriteNullBytes(15);
	}
}

