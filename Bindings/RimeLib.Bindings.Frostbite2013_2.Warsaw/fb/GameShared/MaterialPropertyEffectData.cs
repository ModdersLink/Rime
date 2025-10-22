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

using fb.Entity;
using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 24)]
public class MaterialPropertyEffectData
	: fb.Entity.PhysicsMaterialRelationPropertyData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<EffectWithSpeedRange> ImpactEffects { get; set; } = new();
	
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
	}
}

