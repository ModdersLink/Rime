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
public enum PersistenceGameType : int
{
	PersistenceGameType_Singleplayer = 0,
	PersistenceGameType_Cooperative = 1,
	PersistenceGameType_Multiplayer = 2,
	PersistenceGameType_Count = 3,
}

