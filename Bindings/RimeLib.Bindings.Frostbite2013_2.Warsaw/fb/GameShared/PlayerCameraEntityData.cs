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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 160)]
public class PlayerCameraEntityData
	: fb.GameShared.CameraEntityBaseData
{
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public TargetMode SoldierTargetMode { get; set; } = TargetMode.TargetMode_ThirdPerson;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public uint SoldierCameraIndex { get; set; } = 1;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public TargetMode VehicleTargetMode { get; set; } = TargetMode.TargetMode_ThirdPerson;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public uint VehicleCameraIndex { get; set; } = 1;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float CameraSmoothingFactor { get; set; } = 0.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public bool ReleaseControlIfTargetLost { get; set; } = false;
	
	[ContainerField(0x95), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
	public bool ShouldTargetControllable { get; set; } = false;
	
	[ContainerField(0x96), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
	public bool ShouldTargetVehicleDriverEntry { get; set; } = true;
	
	[ContainerField(0x97), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
	public bool ShouldTargetExtraPlayerInDoublePlayerEvent { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) SoldierTargetMode);
		p_Writer.Write(SoldierCameraIndex);
		p_Writer.Write((int) VehicleTargetMode);
		p_Writer.Write(VehicleCameraIndex);
		p_Writer.Write(CameraSmoothingFactor);
		p_Writer.Write(ReleaseControlIfTargetLost);
		p_Writer.Write(ShouldTargetControllable);
		p_Writer.Write(ShouldTargetVehicleDriverEntry);
		p_Writer.Write(ShouldTargetExtraPlayerInDoublePlayerEvent);
		p_Writer.WriteNullBytes(8);
	}
}

