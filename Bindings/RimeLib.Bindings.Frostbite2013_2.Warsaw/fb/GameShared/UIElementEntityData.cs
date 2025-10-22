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

[ContainerType(16, 208)]
public class UIElementEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string InstanceName { get; set; } = string.Empty;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public UIElementTransform UIElementTransform { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public UIElementColor Color { get; set; } = new();
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 PositionOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 RotationOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public uint InstanceNameHash { get; set; } = 0;
	
	[ContainerField(0x94), JsonProperty(Order = 148)]
	public UIElementSize Size { get; set; } = new();
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public UILayoutMode LayoutMode { get; set; } = UILayoutMode.UILayoutMode_AnchorOffset;
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public UIElementOffset Offset { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public UIElementAnchor Anchor { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public UIElementOffset Position { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public UIElementRectExpansion Expansion { get; set; } = new();
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public bool Visible { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(InstanceName));
		UIElementTransform.Serialize(p_Writer, p_EbxWriter);
		Color.Serialize(p_Writer, p_EbxWriter);
		PositionOffset.Serialize(p_Writer, p_EbxWriter);
		RotationOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(InstanceNameHash);
		Size.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) LayoutMode);
		Offset.Serialize(p_Writer, p_EbxWriter);
		Anchor.Serialize(p_Writer, p_EbxWriter);
		Position.Serialize(p_Writer, p_EbxWriter);
		Expansion.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Visible);
		p_Writer.WriteNullBytes(7);
	}
}

