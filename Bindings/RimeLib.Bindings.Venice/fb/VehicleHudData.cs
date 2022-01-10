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
		
		public static void Deserialize(VehicleHudData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.CustomizationOffset, p_Reader, p_Parser);
			p_Instance.Customization.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MinimapIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.Texture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.VehicleItemHash = p_Reader.ReadUInt32();
		}
	}
}
