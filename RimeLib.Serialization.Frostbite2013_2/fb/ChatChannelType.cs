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
public enum ChatChannelType : int
{
	CctSayAll = 0,
	CctTeam = 1,
	CctSquad = 2,
	CctSquadLeader = 3,
	CctAdmin = 4,
	CctGame = 5,
	CctSize = 6,
}

