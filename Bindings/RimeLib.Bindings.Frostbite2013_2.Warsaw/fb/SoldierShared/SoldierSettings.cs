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

namespace fb.SoldierShared;

[ContainerType(8, 48)]
public class SoldierSettings
	: fb.Core.SystemSettings
{
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<SoldierWeaponSwitchingData> SoldierWeaponSwitching { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint MaxNumberDroppedPickups { get; set; } = 24;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint MaxVisiblePickupWeapons { get; set; } = 10;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(SoldierWeaponSwitching));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MaxNumberDroppedPickups);
		p_Writer.Write(MaxVisiblePickupWeapons);
	}
}

