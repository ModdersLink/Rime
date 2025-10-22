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
public enum TextureType : int
{
	TextureType_1d = 5,
	TextureType_1dArray = 4,
	TextureType_2d = 0,
	TextureType_2dArray = 3,
	TextureType_Cube = 1,
	TextureType_3d = 2,
	TextureTypeCount = 6,
}

