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


namespace fb.Ant;

[ContainerType(1, 4)]
public enum AntPackagingType : int
{
	AntPackagingType_Chunk = 0,
	AntPackagingType_Bundle = 1,
	AntPackagingType_AnimationSet = 2,
	AntPackagingType_Static = 3,
}

