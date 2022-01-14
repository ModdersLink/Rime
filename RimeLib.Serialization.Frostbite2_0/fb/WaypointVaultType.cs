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
