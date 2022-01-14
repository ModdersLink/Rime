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
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum HitReactionType : int
	{
		HRT_Body = 0,
		HRT_Head = 1,
		HRT_RightArm = 2,
		HRT_LeftArm = 3,
		HRT_RightLeg = 4,
		HRT_LeftLeg = 5,
		HRT_Count = 6
	}

}
