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

[ContainerType(8, 440)]
public class GunSwayModifierData
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public GunSwayStanceZoomModifierData StandZoomModifier { get; set; } = new();
	
	[ContainerField(0x5c), JsonProperty(Order = 92)]
	public GunSwayStanceZoomModifierData StandNoZoomModifier { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public GunSwayStanceZoomModifierData CrouchZoomModifier { get; set; } = new();
	
	[ContainerField(0xe4), JsonProperty(Order = 228)]
	public GunSwayStanceZoomModifierData CrouchNoZoomModifier { get; set; } = new();
	
	[ContainerField(0x128), JsonProperty(Order = 296)]
	public GunSwayStanceZoomModifierData ProneZoomModifier { get; set; } = new();
	
	[ContainerField(0x16c), JsonProperty(Order = 364)]
	public GunSwayStanceZoomModifierData ProneNoZoomModifier { get; set; } = new();
	
	[ContainerField(0x1b0), LayoutImmutable, Blittable, JsonProperty(Order = 432)]
	public bool OnlyInSupportedShooting { get; set; } = false;
	
	[ContainerField(0x1b1), LayoutImmutable, Blittable, JsonProperty(Order = 433)]
	public bool OnlyOnWeaponLightEnabled { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		StandZoomModifier.Serialize(p_Writer, p_EbxWriter);
		StandNoZoomModifier.Serialize(p_Writer, p_EbxWriter);
		CrouchZoomModifier.Serialize(p_Writer, p_EbxWriter);
		CrouchNoZoomModifier.Serialize(p_Writer, p_EbxWriter);
		ProneZoomModifier.Serialize(p_Writer, p_EbxWriter);
		ProneNoZoomModifier.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(OnlyInSupportedShooting);
		p_Writer.Write(OnlyOnWeaponLightEnabled);
		p_Writer.WriteNullBytes(6);
	}
}

