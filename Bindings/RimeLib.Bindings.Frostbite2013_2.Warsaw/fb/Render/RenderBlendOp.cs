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
public enum RenderBlendOp : int
{
	RenderBlendOp_Add = 0,
	RenderBlendOp_Subtract = 1,
	RenderBlendOp_RevSubtract = 2,
	RenderBlendOp_Min = 3,
	RenderBlendOp_Max = 4,
}

