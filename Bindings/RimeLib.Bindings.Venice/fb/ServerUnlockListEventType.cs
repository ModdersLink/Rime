///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum ServerUnlockListEventType : int
	{
		ServerUnlockListEventType_Add = 0,
		ServerUnlockListEventType_Remove = 1,
		ServerUnlockListEventType_Clear = 2,
		ServerUnlockListEventType_List = 3,
		ServerUnlockListEventType_Load = 4,
		ServerUnlockListEventType_Save = 5,
		ServerUnlockListEventType_GetMode = 6,
		ServerUnlockListEventType_SetMode = 7,
		ServerUnlockListEventType_SetFromBitmap = 8
	}

}
