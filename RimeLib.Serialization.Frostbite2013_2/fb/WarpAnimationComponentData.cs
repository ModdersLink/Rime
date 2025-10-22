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

[ContainerType(16, 560)]
public class WarpAnimationComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public LinearTransform ConnectTransform { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public WarpAnimationBinding WarpBinding { get; set; } = new();
	
	[ContainerField(0x13c), JsonProperty(Order = 316)]
	public CannedAnimationBinding CannedAnimBinding { get; set; } = new();
	
	[ContainerField(0x218), LayoutImmutable, Blittable, JsonProperty(Order = 536)]
	public int AnimationEntitySpacePriority { get; set; } = 0;
	
	[ContainerField(0x21c), LayoutImmutable, Blittable, JsonProperty(Order = 540)]
	public GameplayBones BoneToAlign { get; set; } = GameplayBones.GameplayBones_ConnectBone;
	
	[ContainerField(0x220), LayoutImmutable, Blittable, JsonProperty(Order = 544)]
	public bool RequireAnimationWeight { get; set; } = true;
	
	[ContainerField(0x221), LayoutImmutable, Blittable, JsonProperty(Order = 545)]
	public bool ForceAnimationTransform { get; set; } = false;
	
	[ContainerField(0x222), LayoutImmutable, Blittable, JsonProperty(Order = 546)]
	public bool ExternalConnectTransform { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		ConnectTransform.Serialize(p_Writer, p_EbxWriter);
		WarpBinding.Serialize(p_Writer, p_EbxWriter);
		CannedAnimBinding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AnimationEntitySpacePriority);
		p_Writer.Write((int) BoneToAlign);
		p_Writer.Write(RequireAnimationWeight);
		p_Writer.Write(ForceAnimationTransform);
		p_Writer.Write(ExternalConnectTransform);
		p_Writer.WriteNullBytes(13);
	}
}

