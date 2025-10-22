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

[ContainerType(8, 80)]
public class TransformPartPropertyTrackData
	: fb.Entity.PropertyTrackData
{
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public ResourceRef Resource { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public TransformPart TransformPart { get; set; } = fb.Entity.TransformPart.TransformPart_TranslationX;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public CurveInfinityType PreInfinity { get; set; } = CurveInfinityType.CurveInfinityType_Constant;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public CurveInfinityType PostInfinity { get; set; } = CurveInfinityType.CurveInfinityType_Constant;
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<TransformPartPropertyKey> Values { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float EvaluatorFps { get; set; } = 1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public uint KeyStartIndex { get; set; } = 0;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public uint KeyCount { get; set; } = 0;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public bool Weighted { get; set; } = false;
	
	[ContainerField(0x4d), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
	public bool IsStatic { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Resource.Serialize(p_Writer);
		p_Writer.Write((int) TransformPart);
		p_Writer.Write((int) PreInfinity);
		p_Writer.Write((int) PostInfinity);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Values = p_EbxWriter.GetArrayWriter(Values.GetType(), Values.Count);
		p_Writer.Write(s_Values.ArrayIndex);
		foreach (var s_Entry in Values)
		{
			s_Entry.Serialize(s_Values.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(EvaluatorFps);
		p_Writer.Write(KeyStartIndex);
		p_Writer.Write(KeyCount);
		p_Writer.Write(Weighted);
		p_Writer.Write(IsStatic);
		p_Writer.WriteNullBytes(2);
	}
}

