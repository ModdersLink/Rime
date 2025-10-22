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

[ContainerType(16, 144)]
public class AttachTransformLayerData
	: fb.Entity.TransformLayerData
{
	public AttachTransformLayerData()
	{
		//TransformLayerData
		Blendtype = LayeredTransform_BlendType.LayeredTransform_BlendType_WorldOverride;
	}
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<GameObjectData> AttachEntity { get; set; } = new();
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public LinearTransform AttachOffset { get; set; } = new()
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
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public string ChildBoneName { get; set; } = string.Empty;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public string ParentBoneName { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(AttachEntity));
		p_Writer.WriteNullBytes(4);
		AttachOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ChildBoneName));
		p_Writer.Write(p_EbxWriter.WriteString(ParentBoneName));
	}
}

