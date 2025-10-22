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


namespace fb.VeniceShared;

[ContainerType(1, 4)]
public enum RarenessLevel : int
{
	RarenessLevel_Standard = 0,
	RarenessLevel_Advanced = 1,
	RarenessLevel_Superior = 2,
	RarenessLevel_Distinguished = 3,
	RarenessLevel_Special = 4,
	RarenessLevel_Premium = 5,
	RarenessLevel_Mixed = 6,
}

