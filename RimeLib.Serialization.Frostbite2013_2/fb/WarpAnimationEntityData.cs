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

[ContainerType(16, 256)]
public class WarpAnimationEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public WarpAnimationBinding WarpBinding { get; set; } = new();
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public int AnimationEntitySpacePriority { get; set; } = 2;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public GameplayBones BoneToAlign { get; set; } = GameplayBones.GameplayBones_ConnectBone;
	
	[ContainerField(0xb0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
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
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public bool RequireAnimationWeight { get; set; } = true;
	
	[ContainerField(0xf1), LayoutImmutable, Blittable, JsonProperty(Order = 241)]
	public bool ForceAnimationTransform { get; set; } = false;
	
	[ContainerField(0xf2), LayoutImmutable, Blittable, JsonProperty(Order = 242)]
	public bool ExternalConnectTransform { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		WarpBinding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AnimationEntitySpacePriority);
		p_Writer.Write((int) BoneToAlign);
		p_Writer.WriteNullBytes(4);
		ConnectTransform.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RequireAnimationWeight);
		p_Writer.Write(ForceAnimationTransform);
		p_Writer.Write(ExternalConnectTransform);
		p_Writer.WriteNullBytes(13);
	}
}

