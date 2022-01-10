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
	public enum VehicleHudType : int
	{
		VehicleHudType_Car = 0,
		VehicleHudType_Tank = 1,
		VehicleHudType_Boat = 2,
		VehicleHudType_Helicopter = 3,
		VehicleHudType_Stationary = 4,
		VehicleHudType_Strategic = 5,
		VehicleHudType_Dummy = 6,
		VehicleHudType_Count = 7
	}

}
