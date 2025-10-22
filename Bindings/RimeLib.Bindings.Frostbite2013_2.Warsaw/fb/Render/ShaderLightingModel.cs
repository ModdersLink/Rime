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
public enum ShaderLightingModel : int
{
	ShaderLightingModel_Standard = 0,
	ShaderLightingModel_Metallic = 1,
	ShaderLightingModel_Skin = 2,
	ShaderLightingModel_DynamicEnvmap = 3,
	ShaderLightingModel_Hair = 4,
	ShaderLightingModel_Translucent = 5,
}

