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


namespace fb.Venice;

[ContainerType(1, 4)]
public enum TabletCommanderMessageType : int
{
	TabletCommanderMessageType_TryConnect = 0,
	TabletCommanderMessageType_ConnectionApproved = 1,
	TabletCommanderMessageType_ConnectionDenied = 2,
	TabletCommanderMessageType_Ping = 3,
	TabletCommanderMessageType_Pong = 4,
	TabletCommanderMessageType_JoinServer = 5,
	TabletCommanderMessageType_LeaveServer = 6,
	TabletCommanderMessageType_LoadLevel = 7,
	TabletCommanderMessageType_LoadLevelPlayerData = 8,
	TabletCommanderMessageType_LoadLevelActionStates = 9,
	TabletCommanderMessageType_LoadLevelLevolutionStates = 10,
	TabletCommanderMessageType_LoadLevelSquadBarData = 11,
	TabletCommanderMessageType_LoadLevelRushData = 12,
	TabletCommanderMessageType_StartMatch = 13,
	TabletCommanderMessageType_EndMatch = 14,
	TabletCommanderMessageType_ActionEnteredState = 15,
	TabletCommanderMessageType_TriggerAction = 16,
	TabletCommanderMessageType_AbortAction = 17,
	TabletCommanderMessageType_AcknowledgedAction = 18,
	TabletCommanderMessageType_DeniedAction = 19,
	TabletCommanderMessageType_PlayerKilled = 20,
	TabletCommanderMessageType_LevolutionTriggered = 21,
	TabletCommanderMessageType_PlayerJoined = 22,
	TabletCommanderMessageType_PlayerLeft = 23,
	TabletCommanderMessageType_ScoringEvent = 24,
	TabletCommanderMessageType_RoundOver = 25,
	TabletCommanderMessageType_ScoreBoard = 26,
	TabletCommanderMessageType_GainAward = 27,
	TabletCommanderMessageType_GainRank = 28,
	TabletCommanderMessageType_MutinyCompleted = 29,
	TabletCommanderMessageType_ChangedSelectedSquad = 30,
	TabletCommanderMessageType_CombatAreaUpdated = 31,
	TabletCommanderMessageType_EnemyCommanderChanged = 32,
	TabletCommanderMessageType_ChatMessage = 33,
	TabletCommanderMessageType_CommanderSwitchedTeam = 34,
	TabletCommanderMessageType_ClientHasLoadedLevel = 35,
	TabletCommanderMessageType_CarrierState = 36,
	TabletCommanderMessageType_Assignment = 37,
	TabletCommanderMessageType_Count = 38,
}

