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


namespace fb.Entity;

[ContainerType(1, 4)]
public enum UpdatePass : int
{
	UpdatePass_PreSim = 0,
	UpdatePass_PostSim = 1,
	UpdatePass_PostFrame = 2,
	UpdatePass_FrameInterpolation = 3,
	UpdatePass_PreInput = 4,
	UpdatePass_PreFrame = 5,
	UpdatePass_PreAnimation = 6,
	UpdatePass_AnimationAttach = 7,
	UpdatePass_PostAnimation = 8,
	UpdatePass_Count = 9,
}

