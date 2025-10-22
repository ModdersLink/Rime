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


namespace fb.LuaRunner;

[ContainerType(1, 4)]
public enum ExecuteOnPropertyChangeType : int
{
	ExecuteOnPropertyChangeType_DontExecute = 0,
	ExecuteOnPropertyChangeType_Immediate = 1,
	ExecuteOnPropertyChangeType_Queued = 2,
}

