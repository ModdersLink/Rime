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


namespace fb.GameShared;

[ContainerType(1, 4)]
public enum PlayerSpawnType : int
{
	PlayerSpawnType_HumanPlayer = 0,
	PlayerSpawnType_AiPlayer = 1,
	PlayerSpawnType_Actor = 2,
	PlayerSpawnType_BrainAI = 3,
	PlayerSpawnType_Ai2Player = 300,
}

