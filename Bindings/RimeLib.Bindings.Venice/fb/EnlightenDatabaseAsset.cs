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
	[ContainerType(4, 36)]
	public class EnlightenDatabaseAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint DataVersion { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint DebugMeshDataVersion { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint OutputSizeX { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint OutputSizeY { get; set; }

		[ContainerField(28)]
		public List<EnlightenDbSystem> Systems { get; set; } = new();

		[ContainerField(32)]
		public List<EnlightenLightProbeSet> LightProbeSets { get; set; } = new();

	}
}
