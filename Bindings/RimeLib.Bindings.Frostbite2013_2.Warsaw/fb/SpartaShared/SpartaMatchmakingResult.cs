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
public enum SpartaMatchmakingResult : int
{
	SpartaMatchmakingResult_Success = 0,
	SpartaMatchmakingResult_Failure = 1,
	SpartaMatchmakingResult_Timeout = 2,
}

