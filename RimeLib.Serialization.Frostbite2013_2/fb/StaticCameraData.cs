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
using fb.Physics;
using fb.Render;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 320)]
public class StaticCameraData
	: fb.GameShared.TargetCameraData
{
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public List<Vec3> LeftCurve { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public List<Vec3> RightCurve { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public List<Vec3> UpCurve { get; set; } = new();
	
	[ContainerField(0xe8), JsonProperty(Order = 232)]
	public List<Vec3> DownCurve { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public RefArray<CameraLoosePartPhysicsData> LoosePartPhysics { get; set; } = new();
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float LeftYawAngle { get; set; } = 0.000f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public float RightYawAngle { get; set; } = 0.000f;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float UpPitchAngle { get; set; } = 0.000f;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float DownPitchAngle { get; set; } = 0.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public int AverageFilterFrames { get; set; } = 10;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public int YawInputAction { get; set; } = 1018573301;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public int PitchInputAction { get; set; } = -754024050;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float WorldSpaceLockEfficiencyYaw { get; set; } = 0.000f;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public float WorldSpaceLockEfficiencyYawAway { get; set; } = -1.000f;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public float WorldSpaceLockEfficiencyPitch { get; set; } = 0.000f;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float YawSensitivityNonZoomed { get; set; } = 0.000f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public float YawSensitivityZoomed { get; set; } = 0.000f;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public float PitchSensitivityNonZoomed { get; set; } = 0.000f;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public float PitchSensitivityZoomed { get; set; } = 0.000f;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public bool MergeLeftAndRightCurves { get; set; } = false;
	
	[ContainerField(0x131), LayoutImmutable, Blittable, JsonProperty(Order = 305)]
	public bool MergeUpAndDownCurves { get; set; } = false;
	
	[ContainerField(0x132), LayoutImmutable, Blittable, JsonProperty(Order = 306)]
	public bool MirrorHorizontalCurves { get; set; } = false;
	
	[ContainerField(0x133), LayoutImmutable, Blittable, JsonProperty(Order = 307)]
	public bool MirrorVerticalCurves { get; set; } = false;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public bool AccumulateInput { get; set; } = true;
	
	[ContainerField(0x135), LayoutImmutable, Blittable, JsonProperty(Order = 309)]
	public bool ResetAccumulatedInputOnViewChange { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_LeftCurve = p_EbxWriter.GetArrayWriter(LeftCurve.GetType(), LeftCurve.Count);
		p_Writer.Write(s_LeftCurve.ArrayIndex);
		foreach (var s_Entry in LeftCurve)
		{
			s_Entry.Serialize(s_LeftCurve.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_RightCurve = p_EbxWriter.GetArrayWriter(RightCurve.GetType(), RightCurve.Count);
		p_Writer.Write(s_RightCurve.ArrayIndex);
		foreach (var s_Entry in RightCurve)
		{
			s_Entry.Serialize(s_RightCurve.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_UpCurve = p_EbxWriter.GetArrayWriter(UpCurve.GetType(), UpCurve.Count);
		p_Writer.Write(s_UpCurve.ArrayIndex);
		foreach (var s_Entry in UpCurve)
		{
			s_Entry.Serialize(s_UpCurve.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_DownCurve = p_EbxWriter.GetArrayWriter(DownCurve.GetType(), DownCurve.Count);
		p_Writer.Write(s_DownCurve.ArrayIndex);
		foreach (var s_Entry in DownCurve)
		{
			s_Entry.Serialize(s_DownCurve.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LoosePartPhysics = p_EbxWriter.GetArrayWriter(LoosePartPhysics.GetType(), LoosePartPhysics.Count);
		p_Writer.Write(s_LoosePartPhysics.ArrayIndex);
		foreach (var s_Entry in LoosePartPhysics)
		{
			s_LoosePartPhysics.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(LeftYawAngle);
		p_Writer.Write(RightYawAngle);
		p_Writer.Write(UpPitchAngle);
		p_Writer.Write(DownPitchAngle);
		p_Writer.Write(AverageFilterFrames);
		p_Writer.Write(YawInputAction);
		p_Writer.Write(PitchInputAction);
		p_Writer.Write(WorldSpaceLockEfficiencyYaw);
		p_Writer.Write(WorldSpaceLockEfficiencyYawAway);
		p_Writer.Write(WorldSpaceLockEfficiencyPitch);
		p_Writer.Write(YawSensitivityNonZoomed);
		p_Writer.Write(YawSensitivityZoomed);
		p_Writer.Write(PitchSensitivityNonZoomed);
		p_Writer.Write(PitchSensitivityZoomed);
		p_Writer.Write(MergeLeftAndRightCurves);
		p_Writer.Write(MergeUpAndDownCurves);
		p_Writer.Write(MirrorHorizontalCurves);
		p_Writer.Write(MirrorVerticalCurves);
		p_Writer.Write(AccumulateInput);
		p_Writer.Write(ResetAccumulatedInputOnViewChange);
		p_Writer.WriteNullBytes(10);
	}
}

