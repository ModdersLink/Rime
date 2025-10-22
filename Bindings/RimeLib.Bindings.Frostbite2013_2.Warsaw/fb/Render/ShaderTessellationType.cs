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
public enum ShaderTessellationType : int
{
	ShaderTessellationType_None = 0,
	ShaderTessellationType_Phong = 1,
	ShaderTessellationType_DisplacementMappingPhong = 2,
	ShaderTessellationType_DisplacementMapping = 3,
}

