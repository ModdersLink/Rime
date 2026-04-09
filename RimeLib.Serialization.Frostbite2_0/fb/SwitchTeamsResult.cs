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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 4)]
	public enum SwitchTeamsResult : int
	{
		SwitchTeamsResult_Success = -1,
		SwitchTeamsResult_FailedUnbalanced = 0,
		SwitchTeamsResult_FailedTooSoon = 1,
		SwitchTeamsResult_FailedTooFewTickets = 2,
		SwitchTeamsResult_FailedMustBeDead = 3,
		SwitchTeamsResult_FailedTeamFull = 4,
		SwitchTeamsResult_FailedDisabled = 5
	}

}
