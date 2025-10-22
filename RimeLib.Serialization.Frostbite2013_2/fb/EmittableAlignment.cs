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


namespace fb.Emitter;

[ContainerType(1, 4)]
public enum EmittableAlignment : int
{
	EmittableAlignment_Screen = 0,
	EmittableAlignment_Emitter = 1,
	EmittableAlignment_Emittable = 2,
	EmittableAlignment_Direction = 3,
	EmittableAlignment_WorldFixedRotation = 4,
	EmittableAlignment_World = 5,
	EmittableAlignment_MotionStretch = 6,
}

