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
public enum Pan2dOutputChannelCount : int
{
	Pan2dOutputChannelCount_Two = 0,
	Pan2dOutputChannelCount_Four = 1,
	Pan2dOutputChannelCount_Six = 2,
	Pan2dOutputChannelCount_Eight = 3,
}

