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

namespace fb.Entity;

[ContainerType(16, 160)]
public class EffectEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public RefArray<GameObjectData> Components { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public QualityScalableInt MaxActiveInstanceCount { get; set; } = new()
	{
		Ultra = 30,
		High = 30,
		Medium = 30,
		Low = 30,
	};
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public QualityScalableFloat CullDistance { get; set; } = new();
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float StartDelay { get; set; } = 0.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public bool ResetInstanceWhenStarted { get; set; } = true;
	
	[ContainerField(0x8d), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
	public bool AttachToSpawnSurface { get; set; } = false;
	
	[ContainerField(0x8e), JsonProperty(Order = 142)]
	public QualityScalableBool Enable { get; set; } = new()
	{
		Ultra = true,
		High = true,
		Medium = true,
		Low = true,
	};
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Components = p_EbxWriter.GetArrayWriter(Components.GetType(), Components.Count);
		p_Writer.Write(s_Components.ArrayIndex);
		foreach (var s_Entry in Components)
		{
			s_Components.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		MaxActiveInstanceCount.Serialize(p_Writer, p_EbxWriter);
		CullDistance.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(StartDelay);
		p_Writer.Write(ResetInstanceWhenStarted);
		p_Writer.Write(AttachToSpawnSurface);
		Enable.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(14);
	}
}

