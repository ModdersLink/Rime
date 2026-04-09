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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 4)]
	public enum ShaderStageType : int
	{
		ShaderStageType_Vertex = 0,
		ShaderStageType_Pixel = 1,
		ShaderStageType_Hull = 2,
		ShaderStageType_Domain = 3,
		ShaderStageType_Geometry = 4,
		ShaderStageType_Compute = 5,
		ShaderStageTypeCount = 6
	}

}
