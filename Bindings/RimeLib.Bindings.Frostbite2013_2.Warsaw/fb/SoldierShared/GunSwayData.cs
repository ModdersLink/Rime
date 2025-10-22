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

namespace fb.SoldierShared;

[ContainerType(8, 1104)]
public class GunSwayData
	: fb.GameShared.WeaponSwayData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public GunSwayStandData Stand { get; set; } = new();
	
	[ContainerField(0x188), JsonProperty(Order = 392)]
	public GunSwayCrouchProneData Crouch { get; set; } = new();
	
	[ContainerField(0x240), JsonProperty(Order = 576)]
	public GunSwayCrouchProneData Prone { get; set; } = new();
	
	[ContainerField(0x2f8), JsonProperty(Order = 760)]
	public GunSwayStanceTransition ProneToCrouch { get; set; } = new();
	
	[ContainerField(0x314), JsonProperty(Order = 788)]
	public GunSwayStanceTransition ProneToStand { get; set; } = new();
	
	[ContainerField(0x330), JsonProperty(Order = 816)]
	public GunSwayStanceTransition CrouchToProne { get; set; } = new();
	
	[ContainerField(0x34c), JsonProperty(Order = 844)]
	public GunSwayStanceTransition CrouchToStand { get; set; } = new();
	
	[ContainerField(0x368), JsonProperty(Order = 872)]
	public GunSwayStanceTransition StandToProne { get; set; } = new();
	
	[ContainerField(0x384), JsonProperty(Order = 900)]
	public GunSwayStanceTransition StandToCrouch { get; set; } = new();
	
	[ContainerField(0x3a0), JsonProperty(Order = 928)]
	public GunSwayStanceZoomModifierData SuppressionModifierUnzoomed { get; set; } = new();
	
	[ContainerField(0x3e4), JsonProperty(Order = 996)]
	public GunSwayStanceZoomModifierData SuppressionModifierZoomed { get; set; } = new();
	
	[ContainerField(0x428), JsonProperty(Order = 1064)]
	public List<GunSwayModifierUnlock> ModifierUnlocks { get; set; } = new();
	
	[ContainerField(0x430), LayoutImmutable, Blittable, JsonProperty(Order = 1072)]
	public float DeviationScaleFactorZoom { get; set; } = 1.000f;
	
	[ContainerField(0x434), LayoutImmutable, Blittable, JsonProperty(Order = 1076)]
	public float GameplayDeviationScaleFactorZoom { get; set; } = 1.000f;
	
	[ContainerField(0x438), LayoutImmutable, Blittable, JsonProperty(Order = 1080)]
	public float DeviationScaleFactorNoZoom { get; set; } = 1.000f;
	
	[ContainerField(0x43c), LayoutImmutable, Blittable, JsonProperty(Order = 1084)]
	public float GameplayDeviationScaleFactorNoZoom { get; set; } = 1.000f;
	
	[ContainerField(0x440), LayoutImmutable, Blittable, JsonProperty(Order = 1088)]
	public float ShootingRecoilDecreaseScale { get; set; } = 0.100f;
	
	[ContainerField(0x444), LayoutImmutable, Blittable, JsonProperty(Order = 1092)]
	public float FirstShotRecoilMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x448), JsonProperty(Order = 1096)]
	public CtrRef<CameraRecoilData> CameraRecoil { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Stand.Serialize(p_Writer, p_EbxWriter);
		Crouch.Serialize(p_Writer, p_EbxWriter);
		Prone.Serialize(p_Writer, p_EbxWriter);
		ProneToCrouch.Serialize(p_Writer, p_EbxWriter);
		ProneToStand.Serialize(p_Writer, p_EbxWriter);
		CrouchToProne.Serialize(p_Writer, p_EbxWriter);
		CrouchToStand.Serialize(p_Writer, p_EbxWriter);
		StandToProne.Serialize(p_Writer, p_EbxWriter);
		StandToCrouch.Serialize(p_Writer, p_EbxWriter);
		SuppressionModifierUnzoomed.Serialize(p_Writer, p_EbxWriter);
		SuppressionModifierZoomed.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ModifierUnlocks = p_EbxWriter.GetArrayWriter(ModifierUnlocks.GetType(), ModifierUnlocks.Count);
		p_Writer.Write(s_ModifierUnlocks.ArrayIndex);
		foreach (var s_Entry in ModifierUnlocks)
		{
			s_Entry.Serialize(s_ModifierUnlocks.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DeviationScaleFactorZoom);
		p_Writer.Write(GameplayDeviationScaleFactorZoom);
		p_Writer.Write(DeviationScaleFactorNoZoom);
		p_Writer.Write(GameplayDeviationScaleFactorNoZoom);
		p_Writer.Write(ShootingRecoilDecreaseScale);
		p_Writer.Write(FirstShotRecoilMultiplier);
		p_Writer.Write(p_EbxWriter.WriteImport(CameraRecoil));
		p_Writer.WriteNullBytes(4);
	}
}

