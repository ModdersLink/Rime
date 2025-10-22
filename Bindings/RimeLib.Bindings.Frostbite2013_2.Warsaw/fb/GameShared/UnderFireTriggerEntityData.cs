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
public class UnderFireTriggerEntityData
	: fb.GameShared.TriggerEntityData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float Radius { get; set; } = 5.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float CoolDownTime { get; set; } = 1.000f;
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public MaterialDecl TriggerOnMaterialOnly { get; set; } = new();
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public AreaTriggerInclude TriggeredBy { get; set; } = AreaTriggerInclude.ATAll;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public bool DisableIfTrackEntityIsLost { get; set; } = true;
	
	[ContainerField(0x81), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
	public bool RandomYaw { get; set; } = true;
	
	[ContainerField(0x82), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
	public bool IndicateHit { get; set; } = false;
	
	[ContainerField(0x83), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
	public bool SendPlayerEvent { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Radius);
		p_Writer.Write(CoolDownTime);
		TriggerOnMaterialOnly.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) TriggeredBy);
		p_Writer.Write(DisableIfTrackEntityIsLost);
		p_Writer.Write(RandomYaw);
		p_Writer.Write(IndicateHit);
		p_Writer.Write(SendPlayerEvent);
		p_Writer.WriteNullBytes(12);
	}
}

