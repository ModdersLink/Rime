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
	[ContainerType(4, 48)]
	public class EnlightenBuildRadiositySceneDesc : 
		DataContainer
	{
		[ContainerField(8)]
		public List<EnlightenLightProbeSet> LightProbeSets { get; set; } = new();

		[ContainerField(12)]
		public List<EnlightenInputInstance> Instances { get; set; } = new();

		[ContainerField(16)]
		public List<Vec3> StaticLightProbes { get; set; } = new();

		[ContainerField(20), LayoutImmutable]
		public string Terrain { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint SamplesPerCluster { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float SystemInfluenceRadius { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint SystemSize { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint IrBudget { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float ClusterSize { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool SaveDebugData { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable]
		public bool DistributedBuild { get; set; }

		[ContainerField(46), LayoutImmutable, Blittable]
		public bool CacheEnable { get; set; }

	}
}
