///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
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
