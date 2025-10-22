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
public enum CoverIdleType : int
{
	CoverIdleType_Calm = 0,
	CoverIdleType_SearchForEnemy = 1,
	CoverIdleType_PeekOut = 2,
	CoverIdleType_PeekOver = 3,
	CoverIdleType_UnderFire = 4,
	CoverIdleType_Suppressed = 5,
}

