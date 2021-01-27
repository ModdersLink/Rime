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
	public enum UIMinimapZoomState : int
	{
		UIMinimapZoomState_Default = 0,
		UIMinimapZoomState_Overview = 1,
		UIMinimapZoomState_CombatArea = 2,
		UIMinimapZoomState_Mission = 3,
		UIMinimapZoomState_Artillery = 4,
		UIMinimapZoomState_Spawn = 5,
		UIMinimapZoomState_ManDown = 6,
		UIMinimapZoomState_Count = 7
	}

}
