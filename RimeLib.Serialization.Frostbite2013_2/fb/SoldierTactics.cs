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

[ContainerType(8, 120)]
public class SoldierTactics
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<VehicleSettings> Vehicle { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<ChargeSettings> Charge { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<AttackSettings> Attack { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<HideSettings> Hide { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<FleeSettings> Flee { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<CloseCombatSettings> CloseCombat { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<SquadMovementSettings> SquadMovement { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<SquadEngageSettings> SquadEngageSettings { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public EngageSettings EngageSettings { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public WeaponSuppressionSettings WeaponSuppressionSettings { get; set; } = new();
	
	[ContainerField(0x6c), JsonProperty(Order = 108)]
	public VehicleSuppressionSettings VehicleSuppressionSettings { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Vehicle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Charge));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Attack));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Hide));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Flee));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CloseCombat));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SquadMovement));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SquadEngageSettings));
		p_Writer.WriteNullBytes(4);
		EngageSettings.Serialize(p_Writer, p_EbxWriter);
		WeaponSuppressionSettings.Serialize(p_Writer, p_EbxWriter);
		VehicleSuppressionSettings.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
	}
}

