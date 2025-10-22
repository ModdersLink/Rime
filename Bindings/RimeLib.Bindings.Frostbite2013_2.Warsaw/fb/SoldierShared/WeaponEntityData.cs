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
using fb.Entity;
using fb.Core;

namespace fb.SoldierShared;

[ContainerType(16, 176)]
public class WeaponEntityData
	: fb.Entity.GameComponentEntityData
{
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public WeaponClassEnum WeaponClass { get; set; } = WeaponClassEnum.wc12gauge;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public List<WeaponStateData> WeaponStates { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<WeaponFiringData> WeaponFiring { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public CtrRef<WeaponData> CustomWeaponType { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<GameAIWeaponData> AIData { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) WeaponClass);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_WeaponStates = p_EbxWriter.GetArrayWriter(WeaponStates.GetType(), WeaponStates.Count);
		p_Writer.Write(s_WeaponStates.ArrayIndex);
		foreach (var s_Entry in WeaponStates)
		{
			s_Entry.Serialize(s_WeaponStates.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(WeaponFiring));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CustomWeaponType));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AIData));
		p_Writer.WriteNullBytes(12);
	}
}

