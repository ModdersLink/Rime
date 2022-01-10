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
