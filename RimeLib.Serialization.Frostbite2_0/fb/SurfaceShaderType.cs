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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 4)]
	public enum SurfaceShaderType : int
	{
		SurfaceShaderType_Opaque = 0,
		SurfaceShaderType_OpaqueAlphaTest = 1,
		SurfaceShaderType_OpaqueAlphaTestSimple = 2,
		SurfaceShaderType_Transparent = 3,
		SurfaceShaderType_TransparentDecal = 4
	}

}
