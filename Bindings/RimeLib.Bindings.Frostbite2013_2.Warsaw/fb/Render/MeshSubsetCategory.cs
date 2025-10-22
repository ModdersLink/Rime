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


namespace fb.Render;

[ContainerType(1, 4)]
public enum MeshSubsetCategory : int
{
	MeshSubsetCategory_Opaque = 0,
	MeshSubsetCategory_Transparent = 1,
	MeshSubsetCategory_TransparentDecal = 2,
	MeshSubsetCategory_ZOnly = 3,
	MeshSubsetCategoryCount = 4,
}

