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
public enum TerrainShaderParameterDataType : int
{
	TerrainShaderParameterDataType_Bool = 0,
	TerrainShaderParameterDataType_Scalar = 1,
	TerrainShaderParameterDataType_Vector2 = 2,
	TerrainShaderParameterDataType_Vector3 = 3,
	TerrainShaderParameterDataType_Vector4 = 4,
}

