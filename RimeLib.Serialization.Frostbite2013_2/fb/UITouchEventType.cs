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
public enum UITouchEventType : int
{
	UITouchEventType_Start = 1,
	UITouchEventType_Move = 2,
	UITouchEventType_End = 3,
}

