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
public class TeamData
	: fb.GameShared.TeamAsset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<CharacterBlueprint> Soldier { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public FactionId Faction { get; set; } = FactionId.FactionNeutral;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<CharacterCustomizationAsset> SoldierCustomization { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<VehicleCustomizationAsset> VehicleCustomization { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Soldier));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Faction);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_SoldierCustomization = p_EbxWriter.GetArrayWriter(SoldierCustomization.GetType(), SoldierCustomization.Count);
		p_Writer.Write(s_SoldierCustomization.ArrayIndex);
		foreach (var s_Entry in SoldierCustomization)
		{
			s_SoldierCustomization.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_VehicleCustomization = p_EbxWriter.GetArrayWriter(VehicleCustomization.GetType(), VehicleCustomization.Count);
		p_Writer.Write(s_VehicleCustomization.ArrayIndex);
		foreach (var s_Entry in VehicleCustomization)
		{
			s_VehicleCustomization.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

