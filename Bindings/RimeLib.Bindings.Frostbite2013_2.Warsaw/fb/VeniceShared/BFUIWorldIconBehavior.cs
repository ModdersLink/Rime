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

namespace fb.VeniceShared;

[ContainerType(8, 184)]
public class BFUIWorldIconBehavior
	: fb.GameShared.UIWorldIconBehavior
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public UIWorldIconFadeConfiguration IconFadeConfig { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public UIWorldIconFadeConfiguration LabelFadeConfig { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public UIWorldIconFadeConfiguration ProgressFadeConfig { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public UIWorldIconFadeConfiguration DistanceFadeConfig { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public UIWorldZoneDistanceConfiguration CustomZoneDistanceConfig { get; set; } = new();
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public UIWorldZoneType ScaleZone { get; set; } = UIWorldZoneType.UIWorldZoneType_Close;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float LowestScale { get; set; } = 0.500f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float ScaleDistance { get; set; } = 300.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public bool VisibleOnMinimap { get; set; } = true;
	
	[ContainerField(0xad), LayoutImmutable, Blittable, JsonProperty(Order = 173)]
	public bool MagneticToMinimap { get; set; } = true;
	
	[ContainerField(0xae), LayoutImmutable, Blittable, JsonProperty(Order = 174)]
	public bool VisibleOnScreen { get; set; } = true;
	
	[ContainerField(0xaf), LayoutImmutable, Blittable, JsonProperty(Order = 175)]
	public bool MagneticToScreen { get; set; } = true;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public bool VisibleBehind { get; set; } = true;
	
	[ContainerField(0xb1), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
	public bool VisibleOnDeploy { get; set; } = true;
	
	[ContainerField(0xb2), LayoutImmutable, Blittable, JsonProperty(Order = 178)]
	public bool ScaleOrderIcon { get; set; } = false;
	
	[ContainerField(0xb3), LayoutImmutable, Blittable, JsonProperty(Order = 179)]
	public bool UseCustomZoneDistance { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		IconFadeConfig.Serialize(p_Writer, p_EbxWriter);
		LabelFadeConfig.Serialize(p_Writer, p_EbxWriter);
		ProgressFadeConfig.Serialize(p_Writer, p_EbxWriter);
		DistanceFadeConfig.Serialize(p_Writer, p_EbxWriter);
		CustomZoneDistanceConfig.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) ScaleZone);
		p_Writer.Write(LowestScale);
		p_Writer.Write(ScaleDistance);
		p_Writer.Write(VisibleOnMinimap);
		p_Writer.Write(MagneticToMinimap);
		p_Writer.Write(VisibleOnScreen);
		p_Writer.Write(MagneticToScreen);
		p_Writer.Write(VisibleBehind);
		p_Writer.Write(VisibleOnDeploy);
		p_Writer.Write(ScaleOrderIcon);
		p_Writer.Write(UseCustomZoneDistance);
		p_Writer.WriteNullBytes(4);
	}
}

