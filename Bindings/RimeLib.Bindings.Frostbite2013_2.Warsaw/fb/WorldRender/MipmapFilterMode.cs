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


namespace fb.WorldRender;

[ContainerType(1, 4)]
public enum MipmapFilterMode : int
{
	MipmapFilterMode_Box = 0,
	MipmapFilterMode_Renormalize = 1,
	MipmapFilterMode_Poisson13 = 2,
	MipmapFilterMode_Poisson13Clamped = 3,
}

