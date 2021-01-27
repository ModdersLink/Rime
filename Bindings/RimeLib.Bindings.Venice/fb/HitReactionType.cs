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
