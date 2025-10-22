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
using fb.Entity;
using fb.Audio;
using fb.GameShared;

namespace fb.SoldierShared;

[ContainerType(8, 64)]
public class PowerToolWeaponData
	: fb.GameShared.WeaponData
{
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<SoundAsset> RepairSound { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<SoundAsset> RepairCompletedSound { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<SoundAsset> DamageSound { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public MaterialDecl RepairMaterialPair { get; set; } = new();
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public bool PlayFireEffectOnRepairOnly { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(RepairSound));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(RepairCompletedSound));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DamageSound));
		p_Writer.WriteNullBytes(4);
		RepairMaterialPair.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(PlayFireEffectOnRepairOnly);
		p_Writer.WriteNullBytes(3);
	}
}

