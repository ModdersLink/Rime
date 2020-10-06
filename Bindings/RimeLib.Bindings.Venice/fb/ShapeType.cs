///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[MemberInfoFlag(137), ContainerSize(4), ContainerEnum]
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
