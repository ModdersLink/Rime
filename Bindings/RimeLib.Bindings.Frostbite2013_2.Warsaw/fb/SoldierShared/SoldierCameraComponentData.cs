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
using fb.GameShared;
using fb.Entity;

namespace fb.SoldierShared;

[ContainerType(16, 256)]
public class SoldierCameraComponentData
	: fb.GameShared.CharacterCameraComponentData
{
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float ExplosionImpulseMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float StrafeTiltStrength { get; set; } = 0.100f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float PitchTiltStrength { get; set; } = 0.100f;
	
	[ContainerField(0x8c), JsonProperty(Order = 140)]
	public Camera1pBinding Camera1pBinding { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public CameraCommonBinding CameraCommonBinding { get; set; } = new();
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float ForceFieldOfView { get; set; } = -1.000f;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public float Roll { get; set; } = 0.000f;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public bool DisableAiming { get; set; } = false;
	
	[ContainerField(0xf9), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
	public bool AuthoritativeEyePosition { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ExplosionImpulseMultiplier);
		p_Writer.Write(StrafeTiltStrength);
		p_Writer.Write(PitchTiltStrength);
		Camera1pBinding.Serialize(p_Writer, p_EbxWriter);
		CameraCommonBinding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ForceFieldOfView);
		p_Writer.Write(Roll);
		p_Writer.Write(DisableAiming);
		p_Writer.Write(AuthoritativeEyePosition);
		p_Writer.WriteNullBytes(6);
	}
}

