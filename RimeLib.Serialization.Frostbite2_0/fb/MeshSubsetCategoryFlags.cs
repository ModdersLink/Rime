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
