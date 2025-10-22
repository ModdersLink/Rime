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
public enum UIOptionsSpecialCase : int
{
	UIOptionsSpecialCase_Normal = 0,
	UIOptionsSpecialCase_Voiceover_Language = 1,
	UIOptionsSpecialCase_FullscreenScreen = 2,
	UIOptionsSpecialCase_Resolution = 3,
	UIOptionsSpecialCase_OverallGraphicsQuality = 4,
	UIOptionsSpecialCase_AdvancedVideo = 5,
	UIOptionsSpecialCase_ConsoleVideo = 6,
	UIOptionsSpecialCase_VerticalLook = 7,
	UIOptionsSpecialCase_VerticalFlight = 8,
	UIOptionsSpecialCase_Brightess = 9,
	UIOptionsSpecialCase_ConsoleBrightess = 10,
	UIOptionsSpecialCase_SpeechRecognitionDialect = 11,
	UIOptionsSpecialCase_ColorBlind = 12,
	UIOptionsSpecialCase_SpeechRecognitionEnabled = 13,
	UIOptionsSpecialCase_OptionalTelemetry = 14,
	UIOptionsSpecialCase_SquadDeploy = 15,
	UIOptionsSpecialCase_SquadDeployDisabled = 16,
	UIOptionsSpecialCase_SquadDeployQuickMatchGameMode = 17,
	UIOptionsSpecialCase_SquadDeployQuickMatchMapPack = 18,
	UIOptionsSpecialCase_SeparatorText = 19,
	UIOptionsSpecialCase_AimAssistServerOverride = 20,
	UIOptionsSpecialCase_AimAssistSlowdownServerOverride = 21,
	UIOptionsSpecialCase_AutoLean = 22,
	UIOptionsSpecialCase_AllowNetworkGraphGen4b = 23,
}

