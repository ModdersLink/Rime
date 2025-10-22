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


namespace fb.Terrain;

[ContainerType(1, 4)]
public enum MeshScatteringInstanceDataMode : int
{
	MeshScatteringInstanceDataMode_None = 0,
	MeshScatteringInstanceDataMode_Normal = 1,
	MeshScatteringInstanceDataMode_NormalAndAtlasIndex = 2,
	MeshScatteringInstanceDataMode_NormalAndColor = 3,
	MeshScatteringInstanceDataMode_WindAndAtlasIndex = 4,
	MeshScatteringInstanceDataMode_Wind = 5,
}

