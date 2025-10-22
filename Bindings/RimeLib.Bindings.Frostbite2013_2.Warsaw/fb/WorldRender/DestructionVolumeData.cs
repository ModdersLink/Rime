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

namespace fb.WorldRender;

[ContainerType(16, 80)]
public class DestructionVolumeData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<DestructionVolumeAsset> Asset { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<Vec4> Impacts { get; set; } = new();
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public AxisAlignedBox BoundingBox { get; set; } = new()
	{
		max = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		min = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
	};
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<uint> PartToImpactIndices { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Asset));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Impacts = p_EbxWriter.GetArrayWriter(Impacts.GetType(), Impacts.Count);
		p_Writer.Write(s_Impacts.ArrayIndex);
		foreach (var s_Entry in Impacts)
		{
			s_Entry.Serialize(s_Impacts.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		BoundingBox.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_PartToImpactIndices = p_EbxWriter.GetArrayWriter(PartToImpactIndices.GetType(), PartToImpactIndices.Count);
		p_Writer.Write(s_PartToImpactIndices.ArrayIndex);
		foreach (var s_Entry in PartToImpactIndices)
		{
			s_PartToImpactIndices.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(12);
	}
}

