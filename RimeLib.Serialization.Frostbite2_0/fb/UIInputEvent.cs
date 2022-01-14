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

namespace fb
{
	[ContainerType(4, 4)]
	public enum UIInputEvent : int
	{
		UIInputEvent_None = 0,
		UIInputEvent_OnButtonA = 1,
		UIInputEvent_OnButtonB = 2,
		UIInputEvent_OnButtonBack = 3,
		UIInputEvent_OnButtonDPad_Down = 4,
		UIInputEvent_OnButtonDPad_Left = 5,
		UIInputEvent_OnButtonDPad_Right = 6,
		UIInputEvent_OnButtonDPad_Up = 7,
		UIInputEvent_OnButtonLB = 8,
		UIInputEvent_OnButtonRB = 9,
		UIInputEvent_OnButtonStart = 10,
		UIInputEvent_OnButtonX = 11,
		UIInputEvent_OnButtonY = 12
	}

}
