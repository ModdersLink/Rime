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
