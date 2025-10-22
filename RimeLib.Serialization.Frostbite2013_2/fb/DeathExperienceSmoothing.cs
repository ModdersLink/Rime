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
public enum DeathExperienceSmoothing : int
{
	DeathExperienceSmoothing_EaseInAndOut = 0,
	DeathExperienceSmoothing_EaseIn = 1,
	DeathExperienceSmoothing_EaseOut = 2,
	DeathExperienceSmoothing_Linear = 3,
	DeathExperienceSmoothing_Size = 4,
}

