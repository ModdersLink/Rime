///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
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
