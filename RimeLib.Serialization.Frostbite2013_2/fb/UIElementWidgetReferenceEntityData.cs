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

[ContainerType(16, 368)]
public class UIElementWidgetReferenceEntityData
	: fb.Entity.LogicReferenceObjectData
{
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public UIElementTransform UIElementTransform { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public UIElementColor Color { get; set; } = new();
	
	[ContainerField(0xe0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public Vec3 PositionOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xf0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public Vec3 RotationOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public string InstanceName { get; set; } = string.Empty;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public uint InstanceNameHash { get; set; } = 0;
	
	[ContainerField(0x110), JsonProperty(Order = 272)]
	public UIElementInclusionSettings InclusionSettings { get; set; } = new();
	
	[ContainerField(0x128), JsonProperty(Order = 296)]
	public UIElementSize Size { get; set; } = new();
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public UILayoutMode LayoutMode { get; set; } = UILayoutMode.UILayoutMode_AnchorOffset;
	
	[ContainerField(0x134), JsonProperty(Order = 308)]
	public UIElementOffset Offset { get; set; } = new();
	
	[ContainerField(0x13c), JsonProperty(Order = 316)]
	public UIElementAnchor Anchor { get; set; } = new();
	
	[ContainerField(0x144), JsonProperty(Order = 324)]
	public UIElementOffset Position { get; set; } = new();
	
	[ContainerField(0x14c), JsonProperty(Order = 332)]
	public UIElementRectExpansion Expansion { get; set; } = new();
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public string CodeAccessIdentifier { get; set; } = string.Empty;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public bool UseElementSize { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		UIElementTransform.Serialize(p_Writer, p_EbxWriter);
		Color.Serialize(p_Writer, p_EbxWriter);
		PositionOffset.Serialize(p_Writer, p_EbxWriter);
		RotationOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(InstanceName));
		p_Writer.Write(InstanceNameHash);
		p_Writer.WriteNullBytes(4);
		InclusionSettings.Serialize(p_Writer, p_EbxWriter);
		Size.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) LayoutMode);
		Offset.Serialize(p_Writer, p_EbxWriter);
		Anchor.Serialize(p_Writer, p_EbxWriter);
		Position.Serialize(p_Writer, p_EbxWriter);
		Expansion.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(CodeAccessIdentifier));
		p_Writer.Write(UseElementSize);
		p_Writer.WriteNullBytes(7);
	}
}

