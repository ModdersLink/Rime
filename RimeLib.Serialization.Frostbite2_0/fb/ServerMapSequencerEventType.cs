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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum ServerMapSequencerEventType : int
	{
		ServerMapSequencerEventType_Add = 0,
		ServerMapSequencerEventType_Remove = 1,
		ServerMapSequencerEventType_Clear = 2,
		ServerMapSequencerEventType_List = 3,
		ServerMapSequencerEventType_Load = 4,
		ServerMapSequencerEventType_Save = 5,
		ServerMapSequencerEventType_SetNextMapIndex = 6,
		ServerMapSequencerEventType_GetMapIndices = 7,
		ServerMapSequencerEventType_GetRounds = 8,
		ServerMapSequencerEventType_RunNextRound = 9,
		ServerMapSequencerEventType_RestartRound = 10,
		ServerMapSequencerEventType_AvailableMaps = 11
	}

}
