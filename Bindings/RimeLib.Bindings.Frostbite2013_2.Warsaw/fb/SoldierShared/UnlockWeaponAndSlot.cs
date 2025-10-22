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

namespace fb.SoldierShared;

[ContainerType(8, 32)]
public class UnlockWeaponAndSlot
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public CtrRef<SoldierWeaponUnlockAsset> Weapon { get; set; } = new();
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public WeaponSlot Slot { get; set; } = WeaponSlot.WeaponSlot_NotDefined;
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public RefArray<UnlockAssetBase> CustomizationUnlockAssets { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<UnlockAssetBase> UnlockAssets { get; set; } = new();
	
}

