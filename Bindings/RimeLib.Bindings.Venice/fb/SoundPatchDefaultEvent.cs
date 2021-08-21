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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Flags: 137, Size: 4  )]
	public enum SoundPatchDefaultEvent : int
	{
		SoundPatchDefaultEvent_Start = 0,
		SoundPatchDefaultEvent_Stop = 1,
		SoundPatchDefaultEvent_EnterScope = 2,
		SoundPatchDefaultEvent_ForceInit = 3
	}

}
