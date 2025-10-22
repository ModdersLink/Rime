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
public enum ShaderRenderPath : int
{
	ShaderRenderPath_Dx10 = 0,
	ShaderRenderPath_Dx10Plus = 1,
	ShaderRenderPath_Dx10_1 = 2,
	ShaderRenderPath_Dx11 = 3,
	ShaderRenderPath_Dx11_1 = 4,
	ShaderRenderPath_Xenon = 5,
	ShaderRenderPath_Ps3 = 6,
	ShaderRenderPath_Gl = 7,
	ShaderRenderPath_Gen4a = 8,
	ShaderRenderPath_Gen4b = 9,
	ShaderRenderPathCount = 10,
}

