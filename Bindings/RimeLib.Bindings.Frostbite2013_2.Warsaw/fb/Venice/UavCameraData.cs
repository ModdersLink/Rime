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

using fb.GameShared;
using fb.Core;
using fb.Render;
using fb.Entity;

namespace fb.Venice;

[ContainerType(16, 320)]
public class UavCameraData
	: fb.GameShared.TargetCameraData
{
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float ViewDistance { get; set; } = 100.000f;
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public List<CameraSineCurveData> ViewDistanceCurve { get; set; } = new();
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public float ViewAngle { get; set; } = 15.000f;
	
	[ContainerField(0xe8), JsonProperty(Order = 232)]
	public List<CameraSineCurveData> ViewAngleCurve { get; set; } = new();
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float RotationSpeed { get; set; } = 3.000f;
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public List<CameraSineCurveData> RotationSpeedCurve { get; set; } = new();
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float ZoomFov { get; set; } = 6.000f;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float ZoomDelay { get; set; } = 3.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float ZoomTransitionTime { get; set; } = 0.200f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float Fov { get; set; } = 18.000f;
	
	[ContainerField(0x110), JsonProperty(Order = 272)]
	public UavCameraPointData FocusPoint { get; set; } = new();
	
	[ContainerField(0x120), JsonProperty(Order = 288)]
	public UavCameraPointData CenterPoint { get; set; } = new();
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float UpWeightDistance { get; set; } = 10.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ViewDistance);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ViewDistanceCurve = p_EbxWriter.GetArrayWriter(ViewDistanceCurve.GetType(), ViewDistanceCurve.Count);
		p_Writer.Write(s_ViewDistanceCurve.ArrayIndex);
		foreach (var s_Entry in ViewDistanceCurve)
		{
			s_Entry.Serialize(s_ViewDistanceCurve.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ViewAngle);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ViewAngleCurve = p_EbxWriter.GetArrayWriter(ViewAngleCurve.GetType(), ViewAngleCurve.Count);
		p_Writer.Write(s_ViewAngleCurve.ArrayIndex);
		foreach (var s_Entry in ViewAngleCurve)
		{
			s_Entry.Serialize(s_ViewAngleCurve.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(RotationSpeed);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_RotationSpeedCurve = p_EbxWriter.GetArrayWriter(RotationSpeedCurve.GetType(), RotationSpeedCurve.Count);
		p_Writer.Write(s_RotationSpeedCurve.ArrayIndex);
		foreach (var s_Entry in RotationSpeedCurve)
		{
			s_Entry.Serialize(s_RotationSpeedCurve.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ZoomFov);
		p_Writer.Write(ZoomDelay);
		p_Writer.Write(ZoomTransitionTime);
		p_Writer.Write(Fov);
		FocusPoint.Serialize(p_Writer, p_EbxWriter);
		CenterPoint.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(UpWeightDistance);
		p_Writer.WriteNullBytes(12);
	}
}

