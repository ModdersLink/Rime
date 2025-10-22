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
public enum FOVTransitionType : int
{
	FOVTransitionType_Linear = 0,
	FOVTransitionType_Smooth = 1,
	FOVTransitionType_Count = 2,
}

