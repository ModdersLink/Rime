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

[ContainerType(16, 128)]
public class CharacterLookAtTriggerEntityData
	: fb.GameShared.TriggerEventEntityData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float FOV { get; set; } = 5.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float MinDistanceToObject { get; set; } = 0.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float MaxDistanceToObject { get; set; } = 0.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public bool StartTriggerLookingAt { get; set; } = true;
	
	[ContainerField(0x7d), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
	public bool CheckOcclusion { get; set; } = true;
	
	[ContainerField(0x7e), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
	public bool UseEntityDirection { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FOV);
		p_Writer.Write(MinDistanceToObject);
		p_Writer.Write(MaxDistanceToObject);
		p_Writer.Write(StartTriggerLookingAt);
		p_Writer.Write(CheckOcclusion);
		p_Writer.Write(UseEntityDirection);
		p_Writer.WriteNullBytes(1);
	}
}

