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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 32)]
	public class VehicleHudData :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 CustomizationOffset { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<VehicleCustomizationAsset> Customization { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public UIHudIcon MinimapIcon { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<TextureAsset> Texture { get; set; } = new();
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint VehicleItemHash { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			CustomizationOffset.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Customization));
			p_Writer.Write((int) MinimapIcon);
			p_Writer.Write(p_EbxWriter.WriteImport(Texture));
			p_Writer.Write(VehicleItemHash);
		}
	}
}
