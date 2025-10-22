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
public enum ExecutionPriority : int
{
	ExecutionPriority_All = 0,
	ExecutionPriority_Idle = 1,
	ExecutionPriority_Combat = 2,
}

