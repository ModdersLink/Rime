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


namespace fb.Audio;

[ContainerType(1, 4)]
public enum ConditionType : int
{
	ConditionType_And = 0,
	ConditionType_Or = 1,
	ConditionType_XOr = 2,
	ConditionType_Equal = 3,
	ConditionType_NotEqual = 4,
	ConditionType_Less = 5,
	ConditionType_Greater = 6,
	ConditionType_LessOrEqual = 7,
	ConditionType_GreaterOrEqual = 8,
}

