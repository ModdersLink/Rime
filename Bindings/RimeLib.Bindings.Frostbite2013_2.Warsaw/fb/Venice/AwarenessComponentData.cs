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

namespace fb.Venice;

[ContainerType(16, 336)]
public class AwarenessComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x74), JsonProperty(Order = 116)]
	public AwarenessComponentBinding Binding { get; set; } = new();
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public GameplayBones ReferenceJoint { get; set; } = GameplayBones.GameplayBones_HeadBone;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public GameplayBones OwnTargetBone { get; set; } = GameplayBones.GameplayBones_HeadBone;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public float OwnTargetRange { get; set; } = 5.000f;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public float DamageInflictorTargetDuration { get; set; } = 2.000f;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public GameplayBones DamageInflictorTargetBone { get; set; } = GameplayBones.GameplayBones_HeadBone;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public float MinLookatSoldierDuration { get; set; } = 2.000f;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public float MaxLookatSoldierDuration { get; set; } = 6.000f;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float MinIgnoreSoldierDuration { get; set; } = 5.000f;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public float MaxIgnoreSoldierDuration { get; set; } = 10.000f;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public float LookAtSlerpSpeed { get; set; } = 4.000f;
	
	[ContainerField(0x13c), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
	public float VehicleReactRadius { get; set; } = 4.000f;
	
	[ContainerField(0x140), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public float VehicleSpeedThreshold { get; set; } = 5.000f;
	
	[ContainerField(0x144), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
	public float VehicleDirectionConeAngle { get; set; } = 90.000f;
	
	[ContainerField(0x148), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
	public float VehicleReactionDuration { get; set; } = 3.000f;
	
	[ContainerField(0x14c), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
	public bool HasOwnTarget { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		Binding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) ReferenceJoint);
		p_Writer.Write((int) OwnTargetBone);
		p_Writer.Write(OwnTargetRange);
		p_Writer.Write(DamageInflictorTargetDuration);
		p_Writer.Write((int) DamageInflictorTargetBone);
		p_Writer.Write(MinLookatSoldierDuration);
		p_Writer.Write(MaxLookatSoldierDuration);
		p_Writer.Write(MinIgnoreSoldierDuration);
		p_Writer.Write(MaxIgnoreSoldierDuration);
		p_Writer.Write(LookAtSlerpSpeed);
		p_Writer.Write(VehicleReactRadius);
		p_Writer.Write(VehicleSpeedThreshold);
		p_Writer.Write(VehicleDirectionConeAngle);
		p_Writer.Write(VehicleReactionDuration);
		p_Writer.Write(HasOwnTarget);
		p_Writer.WriteNullBytes(3);
	}
}

