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
	[ContainerType(Flags: 137, Size: 4  )]
	public enum WaypointVaultType : int
	{
		WaypointVaultType_VaultOverHigh = 0,
		WaypointVaultType_VaultOntoLow = 1,
		WaypointVaultType_VaultDownLow = 2,
		WaypointVaultType_VaultDownHigh = 3,
		WaypointVaultType_ClimbUpHigh = 4,
		WaypointVaultType_ClimbOverHigh = 5,
		WaypointVaultType_JumpAcross = 6,
		WaypointVaultType_Count = 7
	}

}
