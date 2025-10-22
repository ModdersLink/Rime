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


namespace fb.GameShared;

[ContainerType(1, 4)]
public enum ANTClipEndRule : int
{
	ANTClipEndRule_None = 0,
	ANTClipEndRule_CarryIntoNextTimeline = 1,
	ANTClipEndRule_LoopIndefinitely = 2,
	ANTClipEndRule_PlayIndefinitely = 3,
	ANTClipEndRule_MatchBarLengthToRuntimeLength = 4,
}

