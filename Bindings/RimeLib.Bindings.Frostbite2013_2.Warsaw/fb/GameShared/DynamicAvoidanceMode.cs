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
public enum DynamicAvoidanceMode : int
{
	DynamicAvoidanceMode_Never = 0,
	DynamicAvoidanceMode_WhenScripted = 1,
	DynamicAvoidanceMode_WhenNotScripted = 2,
	DynamicAvoidanceMode_Always = 3,
}

