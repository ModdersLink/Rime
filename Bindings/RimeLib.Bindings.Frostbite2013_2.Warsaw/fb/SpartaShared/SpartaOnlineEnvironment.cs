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


namespace fb.SpartaShared;

[ContainerType(1, 4)]
public enum SpartaOnlineEnvironment : int
{
	SpartaOnlineEnvironment_Development = 0,
	SpartaOnlineEnvironment_Test = 1,
	SpartaOnlineEnvironment_Certification = 2,
	SpartaOnlineEnvironment_Production = 3,
	SpartaOnlineEnvironment_Count = 4,
}

