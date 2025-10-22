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
public enum UIVisualWidgetType : int
{
	UIVisualWidgetType_Default = 0,
	UIVisualWidgetType_DeployMap = 1,
	UIVisualWidgetType_MenuBackground = 2,
	UIVisualWidgetType_Minimap = 3,
	UIVisualWidgetType_IndirectFire = 4,
	UIVisualWidgetType_BigMap = 5,
	UIVisualWidgetType_AirRadar = 6,
	UIVisualWidgetType_Count = 7,
}

