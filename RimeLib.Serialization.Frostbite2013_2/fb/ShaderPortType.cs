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
public enum ShaderPortType : int
{
	SptBool = 0,
	SptInteger = 1,
	SptScalar = 2,
	SptVec2 = 3,
	SptVec3 = 4,
	SptVec4 = 5,
	SptColor = 6,
}

