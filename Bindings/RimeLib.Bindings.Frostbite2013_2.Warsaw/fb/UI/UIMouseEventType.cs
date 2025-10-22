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
public enum UIMouseEventType : int
{
	UIMouseEventType_MouseMove = 0,
	UIMouseEventType_MouseWheel = 1,
	UIMouseEventType_ButtonDown = 2,
	UIMouseEventType_ButtonUp = 3,
}

