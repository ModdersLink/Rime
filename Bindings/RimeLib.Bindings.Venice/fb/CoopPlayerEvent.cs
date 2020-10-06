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
	[MemberInfoFlag(137), ContainerSize(4), ContainerEnum]
	public enum CoopPlayerEvent : int
	{
		CoopPlayerEvent_Connecting = 0,
		CoopPlayerEvent_Connected = 1,
		CoopPlayerEvent_Disconnected = 2,
		CoopPlayerEvent_Stats = 3,
		CoopPlayerEvent_StatsFailed = 4
	}

}
