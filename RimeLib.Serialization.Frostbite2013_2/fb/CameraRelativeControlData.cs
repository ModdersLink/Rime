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

namespace fb.GameShared;

[ContainerType(8, 72)]
public class CameraRelativeControlData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public CameraRelativeControlEnum CameraRelativeControl { get; set; } = CameraRelativeControlEnum.UseProfileOptions;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public int CameraRelativeControl_Forward { get; set; } = -442021152;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public int CameraRelativeControl_Back { get; set; } = -765325833;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public int CameraRelativeControl_Strafe { get; set; } = -1921408025;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int ForcedMovingBodyWorldSpaceLock { get; set; } = 1018573301;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<CameraRelativeControlPerSpeedData> SpeedRelativeData { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int ThrottleOutput { get; set; } = -442021152;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public int BrakeOutput { get; set; } = -765325833;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int YawOutput { get; set; } = -1921408025;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public bool CombineWithNonRelativeControls { get; set; } = false;
	
	[ContainerField(0x3d), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
	public bool UseCameraComponentTransform { get; set; } = true;
	
	[ContainerField(0x3e), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
	public bool VehicleRelativeForward { get; set; } = false;
	
	[ContainerField(0x3f), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
	public bool VehicleRelativeStrafe { get; set; } = false;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool InvertedYawInReverse { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) CameraRelativeControl);
		p_Writer.Write(CameraRelativeControl_Forward);
		p_Writer.Write(CameraRelativeControl_Back);
		p_Writer.Write(CameraRelativeControl_Strafe);
		p_Writer.Write(ForcedMovingBodyWorldSpaceLock);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_SpeedRelativeData = p_EbxWriter.GetArrayWriter(SpeedRelativeData.GetType(), SpeedRelativeData.Count);
		p_Writer.Write(s_SpeedRelativeData.ArrayIndex);
		foreach (var s_Entry in SpeedRelativeData)
		{
			s_Entry.Serialize(s_SpeedRelativeData.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ThrottleOutput);
		p_Writer.Write(BrakeOutput);
		p_Writer.Write(YawOutput);
		p_Writer.Write(CombineWithNonRelativeControls);
		p_Writer.Write(UseCameraComponentTransform);
		p_Writer.Write(VehicleRelativeForward);
		p_Writer.Write(VehicleRelativeStrafe);
		p_Writer.Write(InvertedYawInReverse);
		p_Writer.WriteNullBytes(7);
	}
}

