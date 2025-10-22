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

namespace fb.VeniceShared;

[ContainerType(8, 104)]
public class SyncedBFSettings
	: fb.Core.SystemSettings
{
	public SyncedBFSettings()
	{
		//SystemSettings
		Name = @"SyncedBFSettings";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float GameModeCounterModifier { get; set; } = 1.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float RoundTimeLimit { get; set; } = 100.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string JesusModeForPlayerTag { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int Team1Faction { get; set; } = -1;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public int Team2Faction { get; set; } = -1;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int Team3Faction { get; set; } = -1;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public int Team4Faction { get; set; } = -1;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public uint CommanderSize { get; set; } = 4294967295;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string FieldSpecLevels { get; set; } = @"0,250,500,750";
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public ServerTypeValues ServerType { get; set; } = ServerTypeValues.ServerType_RANKED;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool AllUnlocksUnlocked { get; set; } = false;
	
	[ContainerField(0x55), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
	public bool NoMinimap { get; set; } = false;
	
	[ContainerField(0x56), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
	public bool NoHud { get; set; } = false;
	
	[ContainerField(0x57), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
	public bool NoMinimapSpotting { get; set; } = false;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public bool No3dSpotting { get; set; } = false;
	
	[ContainerField(0x59), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
	public bool NoNameTag { get; set; } = false;
	
	[ContainerField(0x5a), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
	public bool OnlySquadLeaderSpawn { get; set; } = false;
	
	[ContainerField(0x5b), LayoutImmutable, Blittable, JsonProperty(Order = 91)]
	public bool TeamSwitchingAllowed { get; set; } = true;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public bool RevertBackToBF3KillerCamera { get; set; } = false;
	
	[ContainerField(0x5d), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
	public bool DisableHitIndicators { get; set; } = false;
	
	[ContainerField(0x5e), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
	public bool DisableVehicleCommanderActions { get; set; } = false;
	
	[ContainerField(0x5f), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
	public bool IsCompetitive { get; set; } = false;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public bool CommanderEnabled { get; set; } = true;
	
	[ContainerField(0x61), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
	public bool FieldUpgradeSystemActive { get; set; } = true;
	
	[ContainerField(0x62), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
	public bool NotifyServerWhenIgnoringDamage { get; set; } = true;
	
	[ContainerField(0x63), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
	public bool ForceCrashWhenIgnoringDamage { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(GameModeCounterModifier);
		p_Writer.Write(RoundTimeLimit);
		p_Writer.Write(p_EbxWriter.WriteString(JesusModeForPlayerTag));
		p_Writer.Write(Team1Faction);
		p_Writer.Write(Team2Faction);
		p_Writer.Write(Team3Faction);
		p_Writer.Write(Team4Faction);
		p_Writer.Write(CommanderSize);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(FieldSpecLevels));
		p_Writer.Write((int) ServerType);
		p_Writer.Write(AllUnlocksUnlocked);
		p_Writer.Write(NoMinimap);
		p_Writer.Write(NoHud);
		p_Writer.Write(NoMinimapSpotting);
		p_Writer.Write(No3dSpotting);
		p_Writer.Write(NoNameTag);
		p_Writer.Write(OnlySquadLeaderSpawn);
		p_Writer.Write(TeamSwitchingAllowed);
		p_Writer.Write(RevertBackToBF3KillerCamera);
		p_Writer.Write(DisableHitIndicators);
		p_Writer.Write(DisableVehicleCommanderActions);
		p_Writer.Write(IsCompetitive);
		p_Writer.Write(CommanderEnabled);
		p_Writer.Write(FieldUpgradeSystemActive);
		p_Writer.Write(NotifyServerWhenIgnoringDamage);
		p_Writer.Write(ForceCrashWhenIgnoringDamage);
		p_Writer.WriteNullBytes(4);
	}
}

