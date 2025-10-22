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
using fb.Audio;

namespace fb.GameShared;

[ContainerType(16, 592)]
public class FiringFunctionData
	: fb.Core.GameDataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<FiringDispersionData> Dispersion { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public WeaponDispersion WeaponDispersion { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public ShotConfigData Shot { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public OverHeatData OverHeat { get; set; } = new();
	
	[ContainerField(0x150), JsonProperty(Order = 336)]
	public List<FireEffectData> FireEffects1p { get; set; } = new();
	
	[ContainerField(0x158), JsonProperty(Order = 344)]
	public List<FireEffectData> FireEffects3p { get; set; } = new();
	
	[ContainerField(0x160), JsonProperty(Order = 352)]
	public CtrRef<SoundAsset> Sound { get; set; } = new();
	
	[ContainerField(0x168), JsonProperty(Order = 360)]
	public FireLogicData FireLogic { get; set; } = new();
	
	[ContainerField(0x220), JsonProperty(Order = 544)]
	public AmmoConfigData Ammo { get; set; } = new();
	
	[ContainerField(0x244), LayoutImmutable, Blittable, JsonProperty(Order = 580)]
	public float SelfHealTimeWhenDeployed { get; set; } = 0.000f;
	
	[ContainerField(0x248), LayoutImmutable, Blittable, JsonProperty(Order = 584)]
	public bool UsePrimaryAmmo { get; set; } = true;
	
	[ContainerField(0x249), LayoutImmutable, Blittable, JsonProperty(Order = 585)]
	public bool UnlimitedAmmoForAI { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Dispersion = p_EbxWriter.GetArrayWriter(Dispersion.GetType(), Dispersion.Count);
		p_Writer.Write(s_Dispersion.ArrayIndex);
		foreach (var s_Entry in Dispersion)
		{
			s_Entry.Serialize(s_Dispersion.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		WeaponDispersion.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		Shot.Serialize(p_Writer, p_EbxWriter);
		OverHeat.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_FireEffects1p = p_EbxWriter.GetArrayWriter(FireEffects1p.GetType(), FireEffects1p.Count);
		p_Writer.Write(s_FireEffects1p.ArrayIndex);
		foreach (var s_Entry in FireEffects1p)
		{
			s_Entry.Serialize(s_FireEffects1p.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_FireEffects3p = p_EbxWriter.GetArrayWriter(FireEffects3p.GetType(), FireEffects3p.Count);
		p_Writer.Write(s_FireEffects3p.ArrayIndex);
		foreach (var s_Entry in FireEffects3p)
		{
			s_Entry.Serialize(s_FireEffects3p.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Sound));
		p_Writer.WriteNullBytes(4);
		FireLogic.Serialize(p_Writer, p_EbxWriter);
		Ammo.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SelfHealTimeWhenDeployed);
		p_Writer.Write(UsePrimaryAmmo);
		p_Writer.Write(UnlimitedAmmoForAI);
		p_Writer.WriteNullBytes(6);
	}
}

