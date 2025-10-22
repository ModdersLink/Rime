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
public enum ScreenActionInputEventType : int
{
	ScreenActionInputEventType_RuleRecognition = 0,
	ScreenActionInputEventType_CommoroseActivation = 1,
	ScreenActionInputEventType_CommoroseIndication = 2,
	ScreenActionInputEventType_Deploy = 3,
	ScreenActionInputEventType_CommanderSquad = 4,
	ScreenActionInputEventType_CommanderAction = 5,
	ScreenActionInputEventType_CommanderTarget = 6,
	ScreenActionInputEventType_CommanderOther = 7,
	ScreenActionInputEventType_SystemSpeechCommand_OpenMenu = 8,
	ScreenActionInputEventType_SystemSpeechCommand_Play = 9,
	ScreenActionInputEventType_SystemSpeechCommand_Pause = 10,
	ScreenActionInputEventType_SystemSpeechCommand_ShowView = 11,
	ScreenActionInputEventType_SystemSpeechCommand_Back = 12,
	ScreenActionInputEventType_Count = 13,
}

