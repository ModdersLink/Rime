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


namespace fb.Online;

[ContainerType(1, 4)]
public enum InvitePlatform : int
{
	InvitePlatform_Invalid = 0,
	InvitePlatform_X360 = 1,
	InvitePlatform_PS3 = 2,
	InvitePlatform_PC = 3,
	InvitePlatform_CAFE = 4,
	InvitePlatform_Gen4a = 5,
	InvitePlatform_Gen4b = 6,
	InvitePlatform_Count = 7,
}

