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


namespace fb.Venice;

[ContainerType(1, 4)]
public enum TabletCommanderChatChannel : int
{
	TabletCommanderChatChannel_All = 0,
	TabletCommanderChatChannel_Team = 1,
	TabletCommanderChatChannel_Squad = 2,
	TabletCommanderChatChannel_Count = 3,
}

