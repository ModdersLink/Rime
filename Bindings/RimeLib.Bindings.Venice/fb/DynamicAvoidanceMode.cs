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
	public enum DynamicAvoidanceMode : int
	{
		DynamicAvoidanceMode_Never = 0,
		DynamicAvoidanceMode_WhenScripted = 1,
		DynamicAvoidanceMode_WhenNotScripted = 2,
		DynamicAvoidanceMode_Always = 3
	}

}
