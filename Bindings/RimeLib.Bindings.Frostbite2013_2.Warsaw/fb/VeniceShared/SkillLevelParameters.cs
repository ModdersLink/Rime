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

namespace fb.VeniceShared;

[ContainerType(8, 64)]
public class SkillLevelParameters
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public SkillLevelComponent SPM { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public SkillLevelComponent KPM { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public SkillLevelComponent KDR { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float OldValueWeight { get; set; } = 0.900f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float MaxValue { get; set; } = 1000.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float MinimumTimeRequired { get; set; } = 300.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		SPM.Serialize(p_Writer, p_EbxWriter);
		KPM.Serialize(p_Writer, p_EbxWriter);
		KDR.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(OldValueWeight);
		p_Writer.Write(MaxValue);
		p_Writer.Write(MinimumTimeRequired);
		p_Writer.WriteNullBytes(4);
	}
}

