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
public enum AISuppressionState : int
{
	AISuppressionState_None = 0,
	AISuppressionState_Active = 1,
	AISuppressionState_Potential = 2,
	AISuppressionState_CoolDown = 3,
	AISuppressionState_Count = 4,
}

