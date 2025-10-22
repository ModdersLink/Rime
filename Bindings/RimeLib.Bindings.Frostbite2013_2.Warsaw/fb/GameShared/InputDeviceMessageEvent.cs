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


namespace fb.GameShared;

[ContainerType(1, 4)]
public enum InputDeviceMessageEvent : int
{
	IDME_ThrowGrenade = 0,
	IDME_Sidearm = 1,
	IDME_Reload = 2,
	IDME_Countermeasures = 3,
	IDME_Undefined = 4,
}

