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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 4)]
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
