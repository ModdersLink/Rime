///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[MemberInfoFlag(137), ContainerEnum]
	public enum VehicleStateType : int
	{
		VehicleStateType_Normal = 0,
		VehicleStateType_LowHealth = 1,
		VehicleStateType_CriticalState = 2,
		VehicleStateType_LAST_ITEM = 3
	}

}
