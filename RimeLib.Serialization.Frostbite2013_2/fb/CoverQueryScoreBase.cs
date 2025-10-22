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

namespace fb.BFAI2Data;

[ContainerType(8, 72)]
public class CoverQueryScoreBase
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public CoverQueryStyle XStyle { get; set; } = CoverQueryStyle.CoverQueryStyle_Distance;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public CoverQueryPosition FromPosition { get; set; } = CoverQueryPosition.CoverQueryPosition_ActorPosition;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public CoverQueryPosition ToPosition { get; set; } = CoverQueryPosition.CoverQueryPosition_ActorPosition;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public CoverQueryDirection ReferenceDirection { get; set; } = CoverQueryDirection.CoverQueryDirection_CoverDirection;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public CoverQueryCurveXSource CurveXSource { get; set; } = CoverQueryCurveXSource.CoverQueryCurveXSource_Custom;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<float> X { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<float> Score { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool Enabled { get; set; } = true;
	
	[ContainerField(0x39), JsonProperty(Order = 57)]
	public CoverQueryFilter Filter { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) XStyle);
		p_Writer.Write((int) FromPosition);
		p_Writer.Write((int) ToPosition);
		p_Writer.Write((int) ReferenceDirection);
		p_Writer.Write((int) CurveXSource);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_X = p_EbxWriter.GetArrayWriter(X.GetType(), X.Count);
		p_Writer.Write(s_X.ArrayIndex);
		foreach (var s_Entry in X)
		{
			s_X.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Score = p_EbxWriter.GetArrayWriter(Score.GetType(), Score.Count);
		p_Writer.Write(s_Score.ArrayIndex);
		foreach (var s_Entry in Score)
		{
			s_Score.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Enabled);
		Filter.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(3);
	}
}

