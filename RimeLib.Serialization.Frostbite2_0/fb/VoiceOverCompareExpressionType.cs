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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum VoiceOverCompareExpressionType : int
	{
		VoiceOverCompareExpressionType_Equals = 0,
		VoiceOverCompareExpressionType_Differs = 1,
		VoiceOverCompareExpressionType_Greater = 2,
		VoiceOverCompareExpressionType_Less = 3,
		VoiceOverCompareExpressionType_GreaterOrEquals = 4,
		VoiceOverCompareExpressionType_LessOrEquals = 5
	}

}
