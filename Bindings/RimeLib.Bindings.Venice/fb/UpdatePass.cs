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
	[MemberInfoFlag(137), ContainerSize(4), ContainerEnum]
	public enum UpdatePass : int
	{
		UpdatePass_PreSim = 0,
		UpdatePass_PostSim = 1,
		UpdatePass_PostFrame = 2,
		UpdatePass_FrameInterpolation = 3,
		UpdatePass_PreInput = 4,
		UpdatePass_PreFrame = 5,
		UpdatePass_Count = 6
	}

}
