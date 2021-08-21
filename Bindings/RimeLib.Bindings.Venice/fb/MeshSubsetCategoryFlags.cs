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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Flags: 137, Size: 4  )]
	public enum MeshSubsetCategoryFlags : int
	{
		MeshSubsetCategoryFlags_Opaque = 1,
		MeshSubsetCategoryFlags_Transparent = 2,
		MeshSubsetCategoryFlags_TransparentDecal = 4,
		MeshSubsetCategoryFlags_Normal = 7,
		MeshSubsetCategoryFlags_ZOnly = 8,
		MeshSubsetCategoryFlags_DynamicEnvmap = 16,
		MeshSubsetCategoryFlags_PlanarReflection = 32,
		MeshSubsetCategoryFlags_All = 63
	}

}
