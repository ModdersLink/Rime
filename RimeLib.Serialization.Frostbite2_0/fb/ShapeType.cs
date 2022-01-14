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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum ShapeType : int
	{
		ShapeType_Hull = 0,
		ShapeType_Box = 1,
		ShapeType_OBB = 2,
		ShapeType_Sphere = 3,
		ShapeType_Cylinder = 4,
		ShapeType_Capsule = 5,
		ShapeType_Mesh = 6,
		ShapeType_Decompose = 7,
		ShapeType_Unknown = 8
	}

}
