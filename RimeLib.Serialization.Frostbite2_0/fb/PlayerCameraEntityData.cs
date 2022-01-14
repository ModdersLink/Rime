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
	[ContainerType(16, 128)]
	public class PlayerCameraEntityData :
		CameraEntityBaseData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public TargetMode SoldierTargetMode { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public uint SoldierCameraIndex { get; set; }

		[ContainerField(104), JsonProperty(Order = 104)]
		public TargetMode VehicleTargetMode { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public uint VehicleCameraIndex { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public bool ReleaseControlIfTargetLost { get; set; }

		[ContainerField(113), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
		public bool ShouldTargetControllable { get; set; }

		[ContainerField(114), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
		public bool ShouldTargetVehicleDriverEntry { get; set; }

		[ContainerField(115), LayoutImmutable, Blittable, JsonProperty(Order = 115)]
		public bool ShouldTargetExtraPlayerInDoublePlayerEvent { get; set; }

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
