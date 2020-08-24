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
	public enum UIMessageEntityType : int
	{
		UIMessageEntityType_Message = 0,
		UIMessageEntityType_Tooltip = 1,
		UIMessageEntityType_LogLines = 2,
		UIMessageEntityType_Subtitle = 3,
		UIMessageEntityType_FailState = 4,
		UIMessageEntityType_OutOfBounds = 5
	}

}
