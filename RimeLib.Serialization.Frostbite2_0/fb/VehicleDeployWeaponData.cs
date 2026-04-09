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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 36)]
	public partial class VehicleDeployWeaponData :
		WeaponData
	{
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _DeployAreaRadius;

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<ObjectBlueprint> _PreviewObject = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _DeployAreaGroundRayLength;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _DeployAreaGroundFlatness;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private bool _UsePreview;

		[ObservableProperty]
		[property: ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		private bool _CheckClearSky;

		[ObservableProperty]
		[property: ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		private bool _CanRemoteEnterVehicle;

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
