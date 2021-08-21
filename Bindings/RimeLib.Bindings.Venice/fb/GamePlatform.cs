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
	public enum GamePlatform : int
	{
		GamePlatform_Ps3 = 0,
		GamePlatform_Win32 = 1,
		GamePlatform_Xenon = 2,
		GamePlatform_Any = 3,
		GamePlatform_Invalid = 4,
		GamePlatform_Count = 5
	}

}
