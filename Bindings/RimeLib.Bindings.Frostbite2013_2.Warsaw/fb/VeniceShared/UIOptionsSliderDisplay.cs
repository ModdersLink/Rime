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
public enum UIOptionsSliderDisplay : int
{
	UIOptionsSliderDisplay_PercentOfMax = 0,
	UIOptionsSliderDisplay_Integer = 1,
	UIOptionsSliderDisplay_ToPercent = 2,
	UIOptionsSliderDisplay_NoText = 3,
	UIOptionsSliderDisplay_FOV = 4,
	UIOptionsSliderDisplay_ToColorComponent = 5,
}

