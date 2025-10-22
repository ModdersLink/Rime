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

namespace fb.GameShared;

[ContainerType(8, 40)]
public class UICppScreenData
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float FieldOfView { get; set; } = 45.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float ScreenLayoutWidth { get; set; } = 1280.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float ScreenLayoutHeight { get; set; } = 720.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool ScaleUpAndKeepAspectRatio { get; set; } = false;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool FlashCompatibilityMode { get; set; } = false;
	
	[ContainerField(0x26), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
	public bool EatAllInput { get; set; } = false;
	
	[ContainerField(0x27), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
	public bool LayoutWithSafeZone { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FieldOfView);
		p_Writer.Write(ScreenLayoutWidth);
		p_Writer.Write(ScreenLayoutHeight);
		p_Writer.Write(ScaleUpAndKeepAspectRatio);
		p_Writer.Write(FlashCompatibilityMode);
		p_Writer.Write(EatAllInput);
		p_Writer.Write(LayoutWithSafeZone);
	}
}

