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

[ContainerType(16, 192)]
public class UIEventLogWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIElementFontStyle> Font { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public uint LineSpacing { get; set; } = 30;
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor KillWeaponColor { get; set; } = new();
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float NudgeDownDistance { get; set; } = 24.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public uint MaxTrackedLines { get; set; } = 30;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float UnderPopulatedLineExpiryTime { get; set; } = 2.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float OverPopulatedLineExpiryTime { get; set; } = 1.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float LineAddCooldown { get; set; } = 0.500f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float FadeTime { get; set; } = 0.250f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Font));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(LineSpacing);
		p_Writer.WriteNullBytes(12);
		KillWeaponColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(NudgeDownDistance);
		p_Writer.Write(MaxTrackedLines);
		p_Writer.Write(UnderPopulatedLineExpiryTime);
		p_Writer.Write(OverPopulatedLineExpiryTime);
		p_Writer.Write(LineAddCooldown);
		p_Writer.Write(FadeTime);
		p_Writer.WriteNullBytes(8);
	}
}

