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

using fb.GameShared;
using fb.Core;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 160)]
public class UIIndirectFireIconsWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public UIVisualWidgetType VisualWidgetType { get; set; } = UIVisualWidgetType.UIVisualWidgetType_IndirectFire;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public UIPlayerFilter PlayerFilter { get; set; } = UIPlayerFilter.UIPlayerFilter_LocalPlayer;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public UIElementColor CircleColor { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float CircleStartSize { get; set; } = 0.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float CircleTargetSize { get; set; } = 16.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float CircleExpandDuration { get; set; } = 2.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float CircleThickness { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) VisualWidgetType);
		p_Writer.Write((int) PlayerFilter);
		CircleColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CircleStartSize);
		p_Writer.Write(CircleTargetSize);
		p_Writer.Write(CircleExpandDuration);
		p_Writer.Write(CircleThickness);
	}
}

