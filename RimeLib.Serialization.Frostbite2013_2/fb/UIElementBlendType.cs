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


namespace fb.GameShared;

[ContainerType(1, 4)]
public enum UIElementBlendType : int
{
	UIElementBlendType_Solid = 0,
	UIElementBlendType_AlphaBlend = 1,
	UIElementBlendType_Additive = 2,
	UIElementBlendType_Subtract = 3,
	UIElementBlendType_Multiply = 4,
	UIElementBlendType_Lighten = 5,
	UIElementBlendType_Darken = 6,
	UIElementBlendType_Difference = 7,
	UIElementBlendType_Erase = 8,
	UIElementBlendType_PreMultiply = 9,
	UIElementBlendType_AlphaBlendNonAdditive = 10,
	UIElementBlendType_Count = 11,
}

