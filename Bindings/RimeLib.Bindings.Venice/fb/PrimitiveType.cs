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
	[ContainerType(Flags: 137, Size: 4  )]
	public enum PrimitiveType : int
	{
		PrimitiveType_PointList = 0,
		PrimitiveType_LineList = 1,
		PrimitiveType_LineStrip = 2,
		PrimitiveType_TriangleList = 3,
		PrimitiveType_TriangleStrip = 5,
		PrimitiveType_QuadList = 7,
		PrimitiveType_XenonRectList = 8
	}

}
