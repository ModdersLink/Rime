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

using fb.GameShared;
using fb.Core;

namespace fb.BFAI2Data;

[ContainerType(8, 152)]
public class BFAI2SystemData
	: fb.GameShared.GameAISystem
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<BFCoverConstantData> CoverConstants { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public DamageAndPrecisionData DamageAndPrecision { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<FiringPatternCollectionData> FiringPatternCollection { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public TargetingData Targeting { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public ShootingData Shooting { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public SquadEngageData SquadEngageData { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public AreaBookingSettings AreaBookingSettings { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<PreferredRange> PreferredRange { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(CoverConstants));
		p_Writer.WriteNullBytes(4);
		DamageAndPrecision.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FiringPatternCollection));
		p_Writer.WriteNullBytes(4);
		Targeting.Serialize(p_Writer, p_EbxWriter);
		Shooting.Serialize(p_Writer, p_EbxWriter);
		SquadEngageData.Serialize(p_Writer, p_EbxWriter);
		AreaBookingSettings.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PreferredRange));
		p_Writer.WriteNullBytes(4);
	}
}

