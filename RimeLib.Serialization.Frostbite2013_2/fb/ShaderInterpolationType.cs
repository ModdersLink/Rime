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
public enum ShaderInterpolationType : int
{
	ShaderInterpolationType_Linear = 0,
	ShaderInterpolationType_Centroid = 1,
	ShaderInterpolationType_NoInterpolation = 2,
	ShaderInterpolationType_NoPerspective = 3,
	ShaderInterpolationType_Sample = 4,
	ShaderInterpolationType_Count = 5,
	ShaderInterpolationType_DomainManual = 256,
	ShaderInterpolationType_VertexOnly = 512,
	ShaderInterpolationType_VertexHullOnly = 1024,
	ShaderInterpolationType_VertexHullDomainOnly = 2048,
}

