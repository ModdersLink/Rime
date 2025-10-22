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

[ContainerType(16, 304)]
public class CameraComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public RegularCameraViewData RegularView { get; set; } = new();
	
	[ContainerField(0xc0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public Vec3 CameraTransitionPos { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<TargetCameraData> Camera { get; set; } = new();
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float FieldOfView { get; set; } = 45.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float ForceFieldOfView { get; set; } = -1.000f;
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<AlternateCameraViewData> AlternateView { get; set; } = new();
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float OverrideFreelookPitch { get; set; } = 0.000f;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public float OverrideFreelookYaw { get; set; } = 0.000f;
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public CtrRef<CameraRelativeControlData> CameraRelativeControlConfig { get; set; } = new();
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float FreezeHeight { get; set; } = 0.000f;
	
	[ContainerField(0xfc), JsonProperty(Order = 252)]
	public SoldierAnimatedCameraData SoldierAnimatedCamera { get; set; } = new();
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float CameraTransitionTime { get; set; } = 2.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public uint MeshParentComponentNumber { get; set; } = 0;
	
	[ContainerField(0x110), JsonProperty(Order = 272)]
	public StanceCameraData StanceData { get; set; } = new();
	
	[ContainerField(0x120), JsonProperty(Order = 288)]
	public CtrRef<CameraComponentSoundData> CameraSoundData { get; set; } = new();
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public bool EnableCameraMesh { get; set; } = true;
	
	[ContainerField(0x129), LayoutImmutable, Blittable, JsonProperty(Order = 297)]
	public bool OverrideFreelookEnable { get; set; } = false;
	
	[ContainerField(0x12a), LayoutImmutable, Blittable, JsonProperty(Order = 298)]
	public bool AlternateViewEnabled { get; set; } = true;
	
	[ContainerField(0x12b), LayoutImmutable, Blittable, JsonProperty(Order = 299)]
	public bool IsFirstPerson { get; set; } = false;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public bool ReceiveImpulsesAsThirdPerson { get; set; } = false;
	
	[ContainerField(0x12d), LayoutImmutable, Blittable, JsonProperty(Order = 301)]
	public bool UseCameraTransition { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		RegularView.Serialize(p_Writer, p_EbxWriter);
		CameraTransitionPos.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Camera));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(FieldOfView);
		p_Writer.Write(ForceFieldOfView);
		p_Writer.Write(p_EbxWriter.WriteImport(AlternateView));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(OverrideFreelookPitch);
		p_Writer.Write(OverrideFreelookYaw);
		p_Writer.Write(p_EbxWriter.WriteImport(CameraRelativeControlConfig));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(FreezeHeight);
		SoldierAnimatedCamera.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CameraTransitionTime);
		p_Writer.Write(MeshParentComponentNumber);
		p_Writer.WriteNullBytes(4);
		StanceData.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(CameraSoundData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(EnableCameraMesh);
		p_Writer.Write(OverrideFreelookEnable);
		p_Writer.Write(AlternateViewEnabled);
		p_Writer.Write(IsFirstPerson);
		p_Writer.Write(ReceiveImpulsesAsThirdPerson);
		p_Writer.Write(UseCameraTransition);
		p_Writer.WriteNullBytes(2);
	}
}

