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
	[ContainerType(16, 128)]
	public partial class PlayerCameraEntityData :
		CameraEntityBaseData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private TargetMode _SoldierTargetMode = new();

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private uint _SoldierCameraIndex;

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private TargetMode _VehicleTargetMode = new();

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private uint _VehicleCameraIndex;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private bool _ReleaseControlIfTargetLost;

		[ObservableProperty]
		[property: ContainerField(113), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
		private bool _ShouldTargetControllable;

		[ObservableProperty]
		[property: ContainerField(114), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
		private bool _ShouldTargetVehicleDriverEntry;

		[ObservableProperty]
		[property: ContainerField(115), LayoutImmutable, Blittable, JsonProperty(Order = 115)]
		private bool _ShouldTargetExtraPlayerInDoublePlayerEvent;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) SoldierTargetMode);
			p_Writer.Write(SoldierCameraIndex);
			p_Writer.Write((int) VehicleTargetMode);
			p_Writer.Write(VehicleCameraIndex);
			p_Writer.Write(ReleaseControlIfTargetLost);
			p_Writer.Write(ShouldTargetControllable);
			p_Writer.Write(ShouldTargetVehicleDriverEntry);
			p_Writer.Write(ShouldTargetExtraPlayerInDoublePlayerEvent);
			p_Writer.WriteNullBytes(12);
		}
	}
}
