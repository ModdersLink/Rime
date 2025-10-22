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

using fb.Core;
using fb.Render;

namespace fb.GameShared;

[ContainerType(16, 64)]
public class VehicleHudData
	: EbxSerializable
{
	[ContainerField(0x0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public Vec3 CustomizationOffset { get; set; } = new()
	{
		z = -50.000f,
		y = 0.000f,
		x = 10.000f,
	};
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<VehicleCustomizationAsset> Customization { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public UIHudIcon MinimapIcon { get; set; } = UIHudIcon.UIHudIcon_Tank;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string IconName { get; set; } = string.Empty;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<TextureAsset> Texture { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint VehicleItemHash { get; set; } = 0;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool RotateInMap { get; set; } = true;
	
	[ContainerField(0x35), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
	public bool ShowHealth { get; set; } = true;
	
}

