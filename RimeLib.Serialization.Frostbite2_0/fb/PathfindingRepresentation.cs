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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum PathfindingRepresentation : int
	{
		PathfindingRepresentation_Ignore = 0,
		PathfindingRepresentation_WalkableMesh = 1,
		PathfindingRepresentation_ObstacleMesh = 2,
		PathfindingRepresentation_ObstacleMeshAndThinSideLink = 3,
		PathfindingRepresentation_BoundingBoxExclusion = 4
	}

}
