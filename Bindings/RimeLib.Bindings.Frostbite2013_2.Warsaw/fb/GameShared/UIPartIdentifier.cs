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
public enum UIPartIdentifier : int
{
	HCI_None = 0,
	HCI_RangeMeter = 1,
	HCI_PredictedSight = 2,
	HCI_VelocityVector = 3,
	HCI_RadioAltitude = 4,
}

