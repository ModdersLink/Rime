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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Flags: 137, Size: 4  )]
	public enum EventConnectionTargetType : int
	{
		EventConnectionTargetType_Invalid = 0,
		EventConnectionTargetType_ClientAndServer = 1,
		EventConnectionTargetType_Client = 2,
		EventConnectionTargetType_Server = 3,
		EventConnectionTargetType_NetworkedClient = 4,
		EventConnectionTargetType_NetworkedClientAndServer = 5
	}

}
