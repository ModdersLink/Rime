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
public enum PrimitiveType : int
{
	PrimitiveType_PointList = 0,
	PrimitiveType_LineList = 1,
	PrimitiveType_LineStrip = 2,
	PrimitiveType_TriangleList = 3,
	PrimitiveType_TriangleStrip = 5,
	PrimitiveType_QuadList = 7,
	PrimitiveType_RectList = 8,
}

