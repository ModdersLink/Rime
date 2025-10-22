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
public enum NuiSpeechPhraseType : int
{
	NuiSpeechPhraseType_InputAction = 0,
	NuiSpeechPhraseType_Commorose = 1,
	NuiSpeechPhraseType_FocusPoint = 2,
	NuiSpeechPhraseType_Entity = 3,
	NuiSpeechPhraseType_Direct = 4,
	NuiSpeechPhraseType_DataSet = 5,
	NuiSpeechPhraseType_CommanderComplex = 6,
	NuiSpeechPhraseType_Count = 7,
}

