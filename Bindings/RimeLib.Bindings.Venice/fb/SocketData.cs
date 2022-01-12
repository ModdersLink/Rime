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
	[ContainerType(16, 176)]
	public class SocketData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform BoneRigidTransform { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new();

		[ContainerField(144)]
		public CtrRef<UnlockAssetBase> UnlockAsset { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable]
		public int BoneId { get; set; }

		[ContainerField(152), LayoutImmutable]
		public string BoneName { get; set; } = string.Empty;

		[ContainerField(156)]
		public RefArray<SocketObjectDataBase> AvailableObjects { get; set; } = new();

		[ContainerField(160)]
		public GearSlot GearSlot { get; set; } = new();

		[ContainerField(164)]
		public SocketType SocketType { get; set; } = new();

		[ContainerField(168), LayoutImmutable, Blittable]
		public bool UsesDefaultObject { get; set; }

		[ContainerField(169), LayoutImmutable, Blittable]
		public bool Excluded { get; set; }

		[ContainerField(170), LayoutImmutable, Blittable]
		public bool DefaultEnableSocketEntities { get; set; }

		[ContainerField(171), LayoutImmutable, Blittable]
		public bool ForceSocketEntitiesEnabled { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public bool HideByZoomTransition { get; set; }

		[ContainerField(173), LayoutImmutable, Blittable]
		public bool HideByLightToggle { get; set; }

	}
}
