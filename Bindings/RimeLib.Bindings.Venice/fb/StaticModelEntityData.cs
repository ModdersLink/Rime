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
	[ContainerType(16, 160)]
	public class StaticModelEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112)]
		public RefArray<PartLinkData> PartLinks { get; set; } = new();

		[ContainerField(116)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public uint BoneCount { get; set; }

		[ContainerField(124)]
		public List<LinearTransform> BasePoseTransforms { get; set; } = new();

		[ContainerField(128)]
		public StaticModelNetworkInfo NetworkInfo { get; set; } = new();

		[ContainerField(144)]
		public List<PhysicsPartInfo> PhysicsPartInfos { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable]
		public bool ExcludeFromNearbyObjectDestruction { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable]
		public bool AnimatePhysics { get; set; }

		[ContainerField(150), LayoutImmutable, Blittable]
		public bool Visible { get; set; }

	}
}
