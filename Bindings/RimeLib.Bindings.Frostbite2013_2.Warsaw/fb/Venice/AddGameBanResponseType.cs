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
public enum AddGameBanResponseType : int
{
	AddGameBanResponseType_Success = 0,
	AddGameBanResponseType_Failure = 1,
	AddGameBanResponseType_UserNotFound = 2,
	AddGameBanResponseType_UserCannotBeBanned = 3,
}

