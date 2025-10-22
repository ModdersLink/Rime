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
public enum SoundPatchDefaultEvent : int
{
	SoundPatchDefaultEvent_Start = 0,
	SoundPatchDefaultEvent_Stop = 1,
	SoundPatchDefaultEvent_EnterScope = 2,
	SoundPatchDefaultEvent_ForceInit = 3,
}

