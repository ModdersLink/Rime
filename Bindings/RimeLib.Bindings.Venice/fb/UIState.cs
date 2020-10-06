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
	[MemberInfoFlag(137), ContainerSize(4), ContainerEnum]
	public enum UIState : int
	{
		UIState_Menu = 0,
		UIState_LoadingSP = 1,
		UIState_LoadingMP = 2,
		UIState_Playing = 3,
		UIState_Unload = 4,
		UIState_Embedded = 5,
		UIState_Static = 6,
		UIState_StaticGenerated = 7,
		UIState_PreEndOfRound = 8,
		UIState_EndOfRound = 9,
		UIState_PlayingSP = 10,
		UIState_PlayingMP = 11,
		UIState_None = 12
	}

}
