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


namespace fb.Entity;

[ContainerType(1, 4)]
public enum VectorMathOp : int
{
	VectorMathOp_Add = 0,
	VectorMathOp_Subtract = 1,
	VectorMathOp_MultiplyByFloat = 2,
	VectorMathOp_DivideByFloat = 3,
	VectorMathOp_Cross = 4,
	VectorMathOp_Dot = 5,
	VectorMathOp_Length = 6,
	VectorMathOp_Transform = 7,
	VectorMathOp_InverseTransform = 8,
	VectorMathOp_Rotate = 9,
	VectorMathOp_InverseRotate = 10,
}

