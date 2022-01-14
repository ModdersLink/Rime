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

namespace fb
{
	[ContainerType(16, 176)]
	public class SocketData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public LinearTransform BoneRigidTransform { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public LinearTransform Transform { get; set; } = new();

		[ContainerField(144), JsonProperty(Order = 144)]
		public CtrRef<UnlockAssetBase> UnlockAsset { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public int BoneId { get; set; }

		[ContainerField(152), LayoutImmutable, JsonProperty(Order = 152)]
		public string BoneName { get; set; } = string.Empty;

		[ContainerField(156), JsonProperty(Order = 156)]
		public RefArray<SocketObjectDataBase> AvailableObjects { get; set; } = new();

		[ContainerField(160), JsonProperty(Order = 160)]
		public GearSlot GearSlot { get; set; } = new();

		[ContainerField(164), JsonProperty(Order = 164)]
		public SocketType SocketType { get; set; } = new();

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public bool UsesDefaultObject { get; set; }

		[ContainerField(169), LayoutImmutable, Blittable, JsonProperty(Order = 169)]
		public bool Excluded { get; set; }

		[ContainerField(170), LayoutImmutable, Blittable, JsonProperty(Order = 170)]
		public bool DefaultEnableSocketEntities { get; set; }

		[ContainerField(171), LayoutImmutable, Blittable, JsonProperty(Order = 171)]
		public bool ForceSocketEntitiesEnabled { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public bool HideByZoomTransition { get; set; }

		[ContainerField(173), LayoutImmutable, Blittable, JsonProperty(Order = 173)]
		public bool HideByLightToggle { get; set; }

	}
}
