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
	public enum VoiceOverValueType : int
	{
		VoiceOverValueType_Boolean = 0,
		VoiceOverValueType_Integer = 1,
		VoiceOverValueType_Float = 2,
		VoiceOverValueType_Vector = 3,
		VoiceOverValueType_Object = 4,
		VoiceOverValueTypeCount = 5
	}

}
