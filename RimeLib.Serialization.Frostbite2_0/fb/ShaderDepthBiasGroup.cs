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
	public enum ShaderDepthBiasGroup : int
	{
		ShaderDepthBiasGroup_Default = 0,
		ShaderDepthBiasGroup_Decal = 1,
		ShaderDepthBiasGroup_EmitterOcclusion = 2,
		ShaderDepthBiasGroup_EdgeModel = 3,
		ShaderDepthBiasGroup_TerrainDecal = 4,
		ShaderDepthBiasGroup_TerrainDecalZPass = 5,
		ShaderDepthBiasGroup_Shadow16Bit = 6,
		ShaderDepthBiasGroup_Shadow24Bit = 7,
		ShaderDepthBiasGroup_ZPass = 8,
		ShaderDepthBiasGroup_Emissive = 9,
		ShaderDepthBiasGroupCount = 10
	}

}
