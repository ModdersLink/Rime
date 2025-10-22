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


namespace fb.Physics;

[ContainerType(1, 4)]
public enum CharacterPoseType : int
{
	CharacterPoseType_Stand = 0,
	CharacterPoseType_Crouch = 1,
	CharacterPoseType_Prone = 2,
	CharacterPoseTypeCount = 3,
}

