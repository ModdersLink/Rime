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
using fb.GameShared;
using fb.Entity;

namespace fb.SoldierShared;

[ContainerType(8, 144)]
public class SoldierWeaponUnlockAsset
	: fb.GameShared.WeaponUnlockAsset
{
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string WeaponBundleName { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string Weapon1pBundleName { get; set; } = string.Empty;
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<Blueprint> NonStreamedBlueprint { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<SoldierWeaponCustomizationAsset> Customization { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UnlockAssetBase> Extra { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public uint WeaponIdentifier { get; set; } = 0;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public uint Category { get; set; } = 0;
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public StoredWeaponData WeaponData { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public List<UnlockToBlueprintBundle> UnlockToBlueprintBundle { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(WeaponBundleName));
		p_Writer.Write(p_EbxWriter.WriteString(Weapon1pBundleName));
		p_Writer.Write(p_EbxWriter.WriteImport(NonStreamedBlueprint));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Customization));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Extra));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(WeaponIdentifier);
		p_Writer.Write(Category);
		WeaponData.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_UnlockToBlueprintBundle = p_EbxWriter.GetArrayWriter(UnlockToBlueprintBundle.GetType(), UnlockToBlueprintBundle.Count);
		p_Writer.Write(s_UnlockToBlueprintBundle.ArrayIndex);
		foreach (var s_Entry in UnlockToBlueprintBundle)
		{
			s_Entry.Serialize(s_UnlockToBlueprintBundle.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

