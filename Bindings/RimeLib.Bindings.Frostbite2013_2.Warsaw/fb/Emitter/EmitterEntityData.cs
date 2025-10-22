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

namespace fb.Emitter;

[ContainerType(16, 192)]
public class EmitterEntityData
	: fb.Entity.EffectEntityData
{
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<EmitterAsset> Emitter { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public QualityScalableFloat SpawnProbability { get; set; } = new()
	{
		Ultra = 1.000f,
		High = 1.000f,
		Medium = 1.000f,
		Low = 1.000f,
	};
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public bool LocalPlayerOnly { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Emitter));
		p_Writer.WriteNullBytes(4);
		SpawnProbability.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LocalPlayerOnly);
		p_Writer.WriteNullBytes(7);
	}
}

