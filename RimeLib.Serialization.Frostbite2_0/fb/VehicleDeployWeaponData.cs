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
	[ContainerType(4, 36)]
	public class VehicleDeployWeaponData :
		WeaponData
	{
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float DeployAreaRadius { get; set; }

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<ObjectBlueprint> PreviewObject { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float DeployAreaGroundRayLength { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float DeployAreaGroundFlatness { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool UsePreview { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool CheckClearSky { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		public bool CanRemoteEnterVehicle { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DeployAreaRadius);
			p_Writer.Write(p_EbxWriter.WriteImport(PreviewObject));
			p_Writer.Write(DeployAreaGroundRayLength);
			p_Writer.Write(DeployAreaGroundFlatness);
			p_Writer.Write(UsePreview);
			p_Writer.Write(CheckClearSky);
			p_Writer.Write(CanRemoteEnterVehicle);
			p_Writer.WriteNullBytes(1);
		}
	}
}
