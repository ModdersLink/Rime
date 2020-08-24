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
	[MemberInfoFlag(137), ContainerEnum]
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
