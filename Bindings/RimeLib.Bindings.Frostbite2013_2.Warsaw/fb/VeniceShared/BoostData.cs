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

[ContainerType(8, 56)]
public class BoostData
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string Key { get; set; } = string.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float ScoreModifier { get; set; } = 0.000f;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<ScoringBucketModifierData> ScoringBucketModifiers { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint Identifier { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Key));
		p_Writer.Write(ScoreModifier);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ScoringBucketModifiers = p_EbxWriter.GetArrayWriter(ScoringBucketModifiers.GetType(), ScoringBucketModifiers.Count);
		p_Writer.Write(s_ScoringBucketModifiers.ArrayIndex);
		foreach (var s_Entry in ScoringBucketModifiers)
		{
			s_Entry.Serialize(s_ScoringBucketModifiers.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Identifier);
		p_Writer.WriteNullBytes(4);
	}
}

