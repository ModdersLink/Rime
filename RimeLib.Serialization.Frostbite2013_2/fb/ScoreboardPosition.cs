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


namespace fb.VeniceShared;

[ContainerType(1, 4)]
public enum ScoreboardPosition : int
{
	ScoreboardPosition_FirstPlace = 0,
	ScoreboardPosition_SecondPlace = 1,
	ScoreboardPosition_ThirdPlace = 2,
	ScoreboardPosition_FourthPlace = 3,
	ScoreboardPosition_FifthPlace = 4,
	ScoreboardPosition_LAST_ITEM = 5,
}

