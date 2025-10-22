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

using fb.VeniceShared;
using fb.Core;

namespace fb.BFAI2Data;

[ContainerType(8, 272)]
public class AttackSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<CoverQueryData> GoalCoverQuery { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<CoverQueryData> ProtectionCoverQuery { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<CoverQueryData> HideCoverQuery { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<CoverQueryData> ValidCoverQuery { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<MoveSettings> MoveSettings { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<CoverControlSettings> CoverSettings { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public AttackCoverRequestSettings CoverRequestSettings { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public AttackCoverRequestSettings IndoorCoverRequestSettings { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public AttackCoverRequestSettings OutdoorCoverRequestSettings { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public CtrRef<ProjectileSettings> ProjectileSettings { get; set; } = new();
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public AICombatIntensity CombatIntensity { get; set; } = AICombatIntensity.AICombatIntensity_None;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(GoalCoverQuery));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ProtectionCoverQuery));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HideCoverQuery));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ValidCoverQuery));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MoveSettings));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CoverSettings));
		p_Writer.WriteNullBytes(4);
		CoverRequestSettings.Serialize(p_Writer, p_EbxWriter);
		IndoorCoverRequestSettings.Serialize(p_Writer, p_EbxWriter);
		OutdoorCoverRequestSettings.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(ProjectileSettings));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) CombatIntensity);
		p_Writer.WriteNullBytes(4);
	}
}

