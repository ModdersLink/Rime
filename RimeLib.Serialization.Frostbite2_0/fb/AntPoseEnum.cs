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

namespace fb
{
	[ContainerType(4, 4)]
	public enum AntPoseEnum : int
	{
		AntPoseEnum_Stand = 0,
		AntPoseEnum_Crouch = 1,
		AntPoseEnum_AntEnumCount = 2,
		AntPoseEnum_NoChange = 3,
		AntPoseEnum_Count = 4
	}

}
