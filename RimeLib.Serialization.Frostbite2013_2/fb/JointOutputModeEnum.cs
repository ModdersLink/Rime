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
public enum JointOutputModeEnum : int
{
	JointOutputModeEnum_NoOutput = 0,
	JointOutputModeEnum_AllJoints = 1,
	JointOutputModeEnum_GameplayBones = 2,
}

