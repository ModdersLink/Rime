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
public enum UIOptionsConsoleControlsShown : int
{
	UIOptionsConsoleControlsShown_None = 0,
	UIOptionsConsoleControlsShown_Soldier = 1,
	UIOptionsConsoleControlsShown_Vehicle = 2,
	UIOptionsConsoleControlsShown_Heli = 3,
	UIOptionsConsoleControlsShown_Jet = 4,
	UIOptionsConsoleControlsShown_Default = 5,
}

