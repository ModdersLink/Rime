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
	[ContainerType(16, 128)]
	public class VegetationBaseEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public List<LinearTransform> BasePoseTransforms { get; set; } = new();

		[ContainerField(100)]
		public List<Vec3> BasePoseTranslations { get; set; } = new();

		[ContainerField(104)]
		public List<int> Hierarchy { get; set; } = new();

		[ContainerField(108)]
		public CtrRef<SkinnedMeshAsset> Mesh { get; set; } = new();

		[ContainerField(112)]
		public CtrRef<SkinnedMeshAsset> ShadowMesh { get; set; } = new();

		[ContainerField(116)]
		public CtrRef<PhysicsEntityData> PhysicsData { get; set; } = new();

	}
}
