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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Flags: 137, Size: 4  )]
	public enum UIIconState : int
	{
		UIIconState_Default = 0,
		UIIconState_Enemy = 1,
		UIIconState_Friendly = 2,
		UIIconState_Neutral = 3,
		UIIconState_Squad = 4,
		UIIconState_Blink = 5,
		UIIconState_BlinkEnemy = 6,
		UIIconState_Count = 7
	}

}
