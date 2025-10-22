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
public enum UIPerformanceMetric : int
{
	UIPerformanceMetric_FramesPerSecond = 0,
	UIPerformanceMetric_PacketLossIn = 1,
	UIPerformanceMetric_PacketLossOut = 2,
	UIPerformanceMetric_Latency = 3,
	UIPerformanceMetric_Count = 4,
}

