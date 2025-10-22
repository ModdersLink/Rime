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
public enum NuiSpeechCommoroseApplicabilityCondition : int
{
	NuiSpeechCommoroseApplicabilityCondition_Always = 0,
	NuiSpeechCommoroseApplicabilityCondition_OnFoot = 1,
	NuiSpeechCommoroseApplicabilityCondition_InVehicle = 2,
	NuiSpeechCommoroseApplicabilityCondition_Squadleader = 3,
	NuiSpeechCommoroseApplicabilityCondition_AttackCommand = 4,
	NuiSpeechCommoroseApplicabilityCondition_OrderRequested = 5,
	NuiSpeechCommoroseApplicabilityCondition_SquadleaderResponseOrder = 6,
	NuiSpeechCommoroseApplicabilityCondition_SquadleaderRequestSupply = 7,
}

