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

[ContainerType(8, 144)]
public class UISoldierStatusWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public uint MaxGrenadesToDisplay { get; set; } = 3;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public uint ReloadAreaHeight { get; set; } = 30;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float ReloadAreaSpeed { get; set; } = 2.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float AmmoAnimationDuration { get; set; } = 0.500f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float AmmoAnimationTargetScale { get; set; } = 1.250f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public int SoldierHealthAnimationStartMinChange { get; set; } = 10;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float SoldierHealthAnimationDuration { get; set; } = 0.500f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float SoldierHealthAnimationTargetScale { get; set; } = 1.250f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float VehicleHealthAnimationDuration { get; set; } = 0.500f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float VehicleHealthAnimationTargetScale { get; set; } = 1.250f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxGrenadesToDisplay);
		p_Writer.Write(ReloadAreaHeight);
		p_Writer.Write(ReloadAreaSpeed);
		p_Writer.Write(AmmoAnimationDuration);
		p_Writer.Write(AmmoAnimationTargetScale);
		p_Writer.Write(SoldierHealthAnimationStartMinChange);
		p_Writer.Write(SoldierHealthAnimationDuration);
		p_Writer.Write(SoldierHealthAnimationTargetScale);
		p_Writer.Write(VehicleHealthAnimationDuration);
		p_Writer.Write(VehicleHealthAnimationTargetScale);
	}
}

