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
public enum RigidBodyType : int
{
	RBTypeCollision = 0,
	RBTypeDetail = 1,
	RBTypeCharacter = 2,
	RBTypeRaycast = 3,
	RBTypeGroup = 4,
	RBTypeSize = 5,
}

