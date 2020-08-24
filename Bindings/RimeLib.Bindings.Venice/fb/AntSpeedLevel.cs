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
	public enum AntSpeedLevel : int
	{
		AntSpeedLevel_Still = 0,
		AntSpeedLevel_Walk = 1,
		AntSpeedLevel_Jog_DEPRECATED_DO_NOT_USE = 2,
		AntSpeedLevel_Sneak = 3,
		AntSpeedLevel_Run = 4,
		AntSpeedLevel_Sprint = 5,
		AntSpeedLevel_Stairs_Walk_Up = 6,
		AntSpeedLevel_Stairs_Walk_Down = 7,
		AntSpeedLevel_Stairs_Run_Up = 8,
		AntSpeedLevel_Stairs_Run_Down = 9,
		AntSpeedLevel_Stairs_Sprint_Up = 10,
		AntSpeedLevel_Stairs_Sprint_Down = 11,
		AntSpeedLevel_AntEnumCount = 12,
		AntSpeedLevel_NoChange = 13,
		AntSpeedLevel_Count = 14
	}

}
