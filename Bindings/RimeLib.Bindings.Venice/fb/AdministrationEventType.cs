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
	public enum AdministrationEventType : int
	{
		AdministrationEventType_Add = 0,
		AdministrationEventType_Remove = 1,
		AdministrationEventType_Clear = 2,
		AdministrationEventType_List = 3,
		AdministrationEventType_Load = 4,
		AdministrationEventType_Save = 5
	}

}
