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
	public enum ServerUnlockSystemType : int
	{
		ServerUnlockSystemType_All = 0,
		ServerUnlockSystemType_Common = 1,
		ServerUnlockSystemType_None = 2,
		ServerUnlockSystemType_FromStats = 3,
		ServerUnlockSystemType_FromWhiteList = 4,
		ServerUnlockSystemType_FromBlackList = 5,
		ServerUnlockSystemType_Count = 6
	}

}
