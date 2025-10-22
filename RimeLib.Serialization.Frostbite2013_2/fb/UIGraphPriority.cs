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


namespace fb.UI;

[ContainerType(1, 4)]
public enum UIGraphPriority : int
{
	UIGraphPriority_Low = 0,
	UIGraphPriority_Normal = 1,
	UIGraphPriority_High = 2,
	UIGraphPriority_OverlayScreens = 3,
	UIGraphPriority_Critical = 4,
}

