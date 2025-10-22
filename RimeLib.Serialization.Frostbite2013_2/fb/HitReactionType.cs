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
public enum HitReactionType : int
{
	HRT_Body = 0,
	HRT_Head = 1,
	HRT_RightArm = 2,
	HRT_LeftArm = 3,
	HRT_RightLeg = 4,
	HRT_LeftLeg = 5,
	HRT_Special1 = 6,
	HRT_Special2 = 7,
	HRT_Special3 = 8,
	HRT_Special4 = 9,
	HRT_Special5 = 10,
	HRT_Special6 = 11,
	HRT_Special7 = 12,
	HRT_Special8 = 13,
	HRT_Count = 14,
}

