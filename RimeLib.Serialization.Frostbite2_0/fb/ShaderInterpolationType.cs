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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum ShaderInterpolationType : int
	{
		ShaderInterpolationType_Linear = 0,
		ShaderInterpolationType_Centroid = 1,
		ShaderInterpolationType_NoInterpolation = 2,
		ShaderInterpolationType_NoPerspective = 3,
		ShaderInterpolationType_Sample = 4,
		ShaderInterpolationType_Count = 5
	}

}
