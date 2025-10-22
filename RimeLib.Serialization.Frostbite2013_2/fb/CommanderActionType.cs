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


namespace fb.VeniceShared;

[ContainerType(1, 4)]
public enum CommanderActionType : int
{
	CommanderActionType_SectorScan = 0,
	CommanderActionType_SectorJam = 1,
	CommanderActionType_Order = 2,
	CommanderActionType_SupplyDrop = 3,
	CommanderActionType_VehicleSpawn = 4,
	CommanderActionType_DefenseDrop = 5,
	CommanderActionType_PromoteSquad = 6,
	CommanderActionType_LaunchTomahawk = 7,
	CommanderActionType_RadarScan = 8,
	CommanderActionType_EarlyWarning = 9,
	CommanderActionType_InfantryScan = 10,
	CommanderActionType_VehicleScan = 11,
	CommanderActionType_SatelliteEMP = 12,
	CommanderActionType_GunshipDeploy = 13,
	CommanderActionType_HighValueTarget = 14,
	CommanderActionType_ReinforceSquad = 15,
	CommanderActionType_SquadWipeProtection = 16,
	CommanderActionType_ProxyAttack = 17,
	CommanderActionType_Communication = 18,
	CommanderActionType_ParaDrop = 19,
	CommanderActionType_Count = 20,
	CommanderActionType_None = 21,
}

