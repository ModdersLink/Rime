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


namespace fb.BFAI2Data;

[ContainerType(1, 4)]
public enum CoverQueryPosition : int
{
	CoverQueryPosition_ActorPosition = 0,
	CoverQueryPosition_CoverPosition = 1,
	CoverQueryPosition_SquadPosition = 2,
	CoverQueryPosition_HumanPosition = 3,
	CoverQueryPosition_TargetPosition = 4,
}

