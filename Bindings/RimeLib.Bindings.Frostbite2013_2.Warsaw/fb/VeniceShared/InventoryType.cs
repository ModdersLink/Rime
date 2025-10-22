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
public enum InventoryType : int
{
	IT_None = 0,
	IT_LightIndicator = 1,
	IT_LaserIndicator = 2,
	IT_Magnifier = 3,
	IT_CantedSight = 4,
	IT_LaserLightCombo = 5,
	IT_ZoomToggle = 6,
}

