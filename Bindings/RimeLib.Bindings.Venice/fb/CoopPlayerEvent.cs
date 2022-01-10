///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum CoopPlayerEvent : int
	{
		CoopPlayerEvent_Connecting = 0,
		CoopPlayerEvent_Connected = 1,
		CoopPlayerEvent_Disconnected = 2,
		CoopPlayerEvent_Stats = 3,
		CoopPlayerEvent_StatsFailed = 4
	}

}
