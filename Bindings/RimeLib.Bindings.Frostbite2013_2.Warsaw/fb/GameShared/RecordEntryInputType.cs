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
public enum RecordEntryInputType : int
{
	RecordEntryInputType_FireInput = 0,
	RecordEntryInputType_PitchInput = 1,
	RecordEntryInputType_YawInput = 2,
	RecordEntryInputType_RollInput = 3,
	RecordEntryInputType_ThrottleInput = 4,
	RecordEntryInputType_DigitalBitFlagsInput = 5,
	RecordEntryInputType_AimingYaw = 6,
	RecordEntryInputType_AimingPitch = 7,
	RecordEntryInputTypeCount = 8,
}

