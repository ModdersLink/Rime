///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Flags: 137, Size: 4  )]
	public enum PathfindingRepresentation : int
	{
		PathfindingRepresentation_Ignore = 0,
		PathfindingRepresentation_WalkableMesh = 1,
		PathfindingRepresentation_ObstacleMesh = 2,
		PathfindingRepresentation_ObstacleMeshAndThinSideLink = 3,
		PathfindingRepresentation_BoundingBoxExclusion = 4
	}

}
