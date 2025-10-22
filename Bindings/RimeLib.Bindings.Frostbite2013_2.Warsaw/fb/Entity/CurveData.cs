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

[ContainerType(8, 88)]
public class CurveData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public InfinityType PreInfinity { get; set; } = InfinityType.InfinityType_Constant;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public InfinityType PostInfinity { get; set; } = InfinityType.InfinityType_Constant;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public CurveType CurveType { get; set; } = fb.Entity.CurveType.CurveType_Complex;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<float> X { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<float> Y { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<float> InTanX { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<float> InTanY { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<float> OutTanX { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public List<float> OutTanY { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool IsWeighted { get; set; } = false;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool IsStatic { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) PreInfinity);
		p_Writer.Write((int) PostInfinity);
		p_Writer.Write((int) CurveType);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_X = p_EbxWriter.GetArrayWriter(X.GetType(), X.Count);
		p_Writer.Write(s_X.ArrayIndex);
		foreach (var s_Entry in X)
		{
			s_X.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Y = p_EbxWriter.GetArrayWriter(Y.GetType(), Y.Count);
		p_Writer.Write(s_Y.ArrayIndex);
		foreach (var s_Entry in Y)
		{
			s_Y.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InTanX = p_EbxWriter.GetArrayWriter(InTanX.GetType(), InTanX.Count);
		p_Writer.Write(s_InTanX.ArrayIndex);
		foreach (var s_Entry in InTanX)
		{
			s_InTanX.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InTanY = p_EbxWriter.GetArrayWriter(InTanY.GetType(), InTanY.Count);
		p_Writer.Write(s_InTanY.ArrayIndex);
		foreach (var s_Entry in InTanY)
		{
			s_InTanY.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OutTanX = p_EbxWriter.GetArrayWriter(OutTanX.GetType(), OutTanX.Count);
		p_Writer.Write(s_OutTanX.ArrayIndex);
		foreach (var s_Entry in OutTanX)
		{
			s_OutTanX.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OutTanY = p_EbxWriter.GetArrayWriter(OutTanY.GetType(), OutTanY.Count);
		p_Writer.Write(s_OutTanY.ArrayIndex);
		foreach (var s_Entry in OutTanY)
		{
			s_OutTanY.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(IsWeighted);
		p_Writer.Write(IsStatic);
		p_Writer.WriteNullBytes(6);
	}
}

