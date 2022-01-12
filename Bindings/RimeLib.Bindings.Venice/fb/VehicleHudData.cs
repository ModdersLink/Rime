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
	[ContainerType(16, 32)]
	public class VehicleHudData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CustomizationOffset { get; set; } = new();
		
		[ContainerField(16)]
		public CtrRef<VehicleCustomizationAsset> Customization { get; set; } = new();
		
		[ContainerField(20)]
		public UIHudIcon MinimapIcon { get; set; } = new();
		
		[ContainerField(24)]
		public CtrRef<TextureAsset> Texture { get; set; } = new();
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint VehicleItemHash { get; set; }
		
	}
}
