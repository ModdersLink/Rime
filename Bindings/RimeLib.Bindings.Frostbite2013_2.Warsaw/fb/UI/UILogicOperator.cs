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


namespace fb.UI;

[ContainerType(1, 4)]
public enum UILogicOperator : int
{
	UILogicOperator_None = 0,
	UILogicOperator_Equal = 1,
	UILogicOperator_GreaterThan = 2,
	UILogicOperator_GreaterThanOrEqual = 3,
	UILogicOperator_LessThan = 4,
	UILogicOperator_LessThanOrEqual = 5,
}

