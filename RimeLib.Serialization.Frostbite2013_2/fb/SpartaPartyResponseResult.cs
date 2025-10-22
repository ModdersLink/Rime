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


namespace fb.SpartaShared;

[ContainerType(1, 4)]
public enum SpartaPartyResponseResult : int
{
	SpartaPartyResponseResult_Success = 0,
	SpartaPartyResponseResult_Cancelled = 1,
	SpartaPartyResponseResult_Failure = 2,
	SpartaPartyResponseResult_FailureNoParty = 3,
	SpartaPartyResponseResult_FailureNoMpPrivilege = 4,
	SpartaPartyResponseResult_FailurePartyIsFull = 5,
	SpartaPartyResponseResult_Unknown = 6,
	SpartaPartyResponseResult_Count = 7,
}

