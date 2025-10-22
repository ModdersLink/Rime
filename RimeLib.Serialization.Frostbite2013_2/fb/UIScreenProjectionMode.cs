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


namespace fb.GameShared;

[ContainerType(1, 4)]
public enum UIScreenProjectionMode : int
{
	UIScreenProjectionMode_Default = 0,
	UIScreenProjectionMode_Billboard = 1,
	UIScreenProjectionMode_BillboardCylindrical = 2,
	UIScreenProjectionMode_BillboardFixedSize = 3,
}

