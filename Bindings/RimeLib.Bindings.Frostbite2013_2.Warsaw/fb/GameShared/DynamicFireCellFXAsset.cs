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

[ContainerType(8, 56)]
public class DynamicFireCellFXAsset
	: fb.Entity.DataContainerPolicyAsset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<CellFX> CellFXList { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public QualityScalableFloat MinSmokeSeparationDistance { get; set; } = new()
	{
		Ultra = 5.000f,
		High = 5.000f,
		Medium = 5.000f,
		Low = 5.000f,
	};
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<EffectBlueprint> SmokeEffect { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_CellFXList = p_EbxWriter.GetArrayWriter(CellFXList.GetType(), CellFXList.Count);
		p_Writer.Write(s_CellFXList.ArrayIndex);
		foreach (var s_Entry in CellFXList)
		{
			s_CellFXList.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		MinSmokeSeparationDistance.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_SmokeEffect = p_EbxWriter.GetArrayWriter(SmokeEffect.GetType(), SmokeEffect.Count);
		p_Writer.Write(s_SmokeEffect.ArrayIndex);
		foreach (var s_Entry in SmokeEffect)
		{
			s_SmokeEffect.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

