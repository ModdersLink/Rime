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
	public enum RigidBodyQualityType : int
	{
		RigidBodyQualityType_Invalid = 0,
		RigidBodyQualityType_Fixed = 1,
		RigidBodyQualityType_Debris = 2,
		RigidBodyQualityType_DebrisSimpleToi = 3,
		RigidBodyQualityType_Moving = 4,
		RigidBodyQualityType_Critical = 5,
		RigidBodyQualityType_Size = 6
	}

}
