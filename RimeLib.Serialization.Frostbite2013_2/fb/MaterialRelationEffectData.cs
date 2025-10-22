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

[ContainerType(8, 40)]
public class MaterialRelationEffectData
	: fb.Entity.PhysicsMaterialRelationPropertyData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<EffectWithSpeedRange> ImpactEffects { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<ObjectBlueprint> ImpactDebris { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float ImpactEffectMaxSpreadAngle { get; set; } = 0.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool MirrorImpactDirection { get; set; } = false;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool EnableInheritedVelocity { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ImpactEffects = p_EbxWriter.GetArrayWriter(ImpactEffects.GetType(), ImpactEffects.Count);
		p_Writer.Write(s_ImpactEffects.ArrayIndex);
		foreach (var s_Entry in ImpactEffects)
		{
			s_Entry.Serialize(s_ImpactEffects.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ImpactDebris = p_EbxWriter.GetArrayWriter(ImpactDebris.GetType(), ImpactDebris.Count);
		p_Writer.Write(s_ImpactDebris.ArrayIndex);
		foreach (var s_Entry in ImpactDebris)
		{
			s_ImpactDebris.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ImpactEffectMaxSpreadAngle);
		p_Writer.Write(MirrorImpactDirection);
		p_Writer.Write(EnableInheritedVelocity);
		p_Writer.WriteNullBytes(2);
	}
}

