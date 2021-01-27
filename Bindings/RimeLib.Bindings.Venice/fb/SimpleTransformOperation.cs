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
	public enum SimpleTransformOperation : int
	{
		SimpleTransformOperation_Add = 0,
		SimpleTransformOperation_Subtract = 1,
		SimpleTransformOperation_Multiply = 2,
		SimpleTransformOperation_Divide = 3,
		SimpleTransformOperation_Sine = 4,
		SimpleTransformOperation_Cosine = 5,
		SimpleTransformOperation_ArcSine = 6,
		SimpleTransformOperation_ArcCosine = 7,
		SimpleTransformOperation_Modulus = 8,
		SimpleTransformOperation_Round = 9,
		SimpleTransformOperation_Floor = 10,
		SimpleTransformOperation_Ceiling = 11,
		SimpleTransformOperation_Power = 12,
		SimpleTransformOperation_SquareRoot = 13,
		SimpleTransformOperation_Absolute = 14,
		SimpleTransformOperation_Exp = 15,
		SimpleTransformOperation_Log = 16,
		SimpleTransformOperation_Log10 = 17,
		SimpleTransformOperation_Tangent = 18,
		SimpleTransformOperation_ArcTangent = 19
	}

}
