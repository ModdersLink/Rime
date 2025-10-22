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
public enum AwardGroup : int
{
	AwardGroup_Undefined = 0,
	AwardGroup_Ribbons = 1,
	AwardGroup_DogTags = 2,
	AwardGroup_Medals = 3,
	AwardGroup_Star = 4,
	AwardGroup_Mission = 5,
	AwardGroup_LevelComplete = 6,
	AwardGroup_Achievements = 7,
	AwardGroup_Ranks = 8,
	AwardGroup_LastAwardGroup = 9,
}

