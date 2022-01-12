///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 112)]
	public class GameSplineEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public GameSplineType SplineType { get; set; } = new();

		[ContainerField(100)]
		public List<Vec3> LocalPoints { get; set; } = new();

		[ContainerField(104)]
		public List<Vec3> Normals { get; set; } = new();

	}
}
