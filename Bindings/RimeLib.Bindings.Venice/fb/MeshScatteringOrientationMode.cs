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
	public enum MeshScatteringOrientationMode : int
	{
		MeshScatteringOrientationMode_Horizontal = 0,
		MeshScatteringOrientationMode_LeanToTerrain = 1,
		MeshScatteringOrientationMode_SkewToTerrain = 2
	}

}
