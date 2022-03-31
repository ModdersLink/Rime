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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum ShaderRenderPath : int
	{
		ShaderRenderPath_Dx10 = 0,
		ShaderRenderPath_Dx10Plus = 1,
		ShaderRenderPath_Dx10_1 = 2,
		ShaderRenderPath_Dx11 = 3,
		ShaderRenderPath_Xenon = 4,
		ShaderRenderPath_Ps3 = 5,
		ShaderRenderPath_Gl = 6,
		ShaderRenderPathCount = 7
	}

}
