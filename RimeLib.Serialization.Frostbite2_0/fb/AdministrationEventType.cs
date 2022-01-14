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
	public enum AdministrationEventType : int
	{
		AdministrationEventType_Add = 0,
		AdministrationEventType_Remove = 1,
		AdministrationEventType_Clear = 2,
		AdministrationEventType_List = 3,
		AdministrationEventType_Load = 4,
		AdministrationEventType_Save = 5
	}

}
