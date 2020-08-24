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
	public enum AddGameBanResponseType : int
	{
		AddGameBanResponseType_Success = 0,
		AddGameBanResponseType_Failure = 1,
		AddGameBanResponseType_UserNotFound = 2,
		AddGameBanResponseType_UserCannotBeBanned = 3
	}

}
