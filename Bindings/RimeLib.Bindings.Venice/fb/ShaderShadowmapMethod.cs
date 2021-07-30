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
	public enum ShaderShadowmapMethod : int
	{
		ShaderShadowmapMethod_None = 0,
		ShaderShadowmapMethod_Single = 1,
		ShaderShadowmapMethod_SingleDiscard = 2,
		ShaderShadowmapMethod_CascadedBox3 = 3,
		ShaderShadowmapMethod_CascadedBox4 = 4
	}

}
