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


namespace fb.Entity;

[ContainerType(1, 4)]
public enum InfinityType : int
{
	InfinityType_Constant = 0,
	InfinityType_Linear = 1,
	InfinityType_Cycle = 2,
	InfinityType_CycleWithOffset = 3,
	InfinityType_Oscillate = 4,
}

