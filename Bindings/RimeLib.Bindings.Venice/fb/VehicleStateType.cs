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
	public enum VehicleStateType : int
	{
		VehicleStateType_Normal = 0,
		VehicleStateType_LowHealth = 1,
		VehicleStateType_CriticalState = 2,
		VehicleStateType_LAST_ITEM = 3
	}

}
