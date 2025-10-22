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

namespace fb.VeniceShared;

[ContainerType(8, 208)]
public class UIMinimapOrdersWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public UIVisualWidgetType VisualWidgetType { get; set; } = UIVisualWidgetType.UIVisualWidgetType_Default;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIMinimapLineStyle> PendingOrderStyle { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<UIMinimapLineStyle> UnselectedPendingOrderStyle { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public CtrRef<UIMinimapLineStyle> AttackOrderStyle { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<UIMinimapLineStyle> AttackOrderSquadStyle { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<UIMinimapLineStyle> UnselectedAttackOrderStyle { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public CtrRef<UIMinimapLineStyle> DefendOrderStyle { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<UIMinimapLineStyle> DefendOrderSquadStyle { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<UIMinimapLineStyle> UnselectedDefendOrderStyle { get; set; } = new();
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float StartpointBuffer { get; set; } = 0.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float EndpointBuffer { get; set; } = 0.000f;
	
	[ContainerField(0xb8), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public Vec2 EndpointStickBorderBuffer { get; set; } = new()
	{
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xc0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public Vec2 StartpointStickBorderBuffer { get; set; } = new()
	{
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public bool FullscreenMapMode { get; set; } = false;
	
	[ContainerField(0xc9), LayoutImmutable, Blittable, JsonProperty(Order = 201)]
	public bool ShowAllSquadOrders { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) VisualWidgetType);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PendingOrderStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(UnselectedPendingOrderStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AttackOrderStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AttackOrderSquadStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(UnselectedAttackOrderStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefendOrderStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefendOrderSquadStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(UnselectedDefendOrderStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(StartpointBuffer);
		p_Writer.Write(EndpointBuffer);
		EndpointStickBorderBuffer.Serialize(p_Writer, p_EbxWriter);
		StartpointStickBorderBuffer.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FullscreenMapMode);
		p_Writer.Write(ShowAllSquadOrders);
		p_Writer.WriteNullBytes(6);
	}
}

