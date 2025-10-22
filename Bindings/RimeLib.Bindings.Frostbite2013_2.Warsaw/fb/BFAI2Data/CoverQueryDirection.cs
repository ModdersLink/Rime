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


namespace fb.BFAI2Data;

[ContainerType(1, 4)]
public enum CoverQueryDirection : int
{
	CoverQueryDirection_CoverDirection = 0,
	CoverQueryDirection_WorldUpDirection = 1,
	CoverQueryDirection_ActorToHumanDirection = 2,
	CoverQueryDirection_HumanToActorDirection = 3,
	CoverQueryDirection_SquadToHumanDirection = 4,
	CoverQueryDirection_HumanToSquadDirection = 5,
	CoverQueryDirection_ActorToTargetDirection = 6,
	CoverQueryDirection_TargetToActorDirection = 7,
}

