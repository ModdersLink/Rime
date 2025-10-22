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

using fb.Entity;
using fb.Core;

namespace fb.SoldierShared;

[ContainerType(16, 1824)]
public class SoldierWeaponsComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public LinearTransform AimDir { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public int PrimaryWeaponId { get; set; } = 0;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public int SecondaryWeaponId { get; set; } = 1;
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<SoldierAimingSimulationData> DefaultAimingController { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public AnimatedWeaponBinding AnimatedWeaponBinding { get; set; } = new();
	
	[ContainerField(0x660), JsonProperty(Order = 1632)]
	public Animated1pOnlyWeaponBinding Animated1pOnlyWeaponBinding { get; set; } = new();
	
	[ContainerField(0x6b0), JsonProperty(Order = 1712)]
	public Animated3pOnlyWeaponBinding Animated3pOnlyWeaponBinding { get; set; } = new();
	
	[ContainerField(0x6f0), JsonProperty(Order = 1776)]
	public CtrRef<SkeletonAsset> WeaponSkeleton { get; set; } = new();
	
	[ContainerField(0x6f8), LayoutImmutable, Blittable, JsonProperty(Order = 1784)]
	public float AmmoClipIncreaseMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x6fc), LayoutImmutable, Blittable, JsonProperty(Order = 1788)]
	public int GrenadeIncrease { get; set; } = 0;
	
	[ContainerField(0x700), LayoutImmutable, Blittable, JsonProperty(Order = 1792)]
	public int UnderslungGrenadeIncrease { get; set; } = 0;
	
	[ContainerField(0x704), LayoutImmutable, Blittable, JsonProperty(Order = 1796)]
	public float ExplosiveIncreaseMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x708), JsonProperty(Order = 1800)]
	public CtrRef<PickupEntityAsset> DropWeaponPickup { get; set; } = new();
	
	[ContainerField(0x710), LayoutImmutable, Blittable, JsonProperty(Order = 1808)]
	public bool UseExternalAimDir { get; set; } = false;
	
	[ContainerField(0x711), LayoutImmutable, Blittable, JsonProperty(Order = 1809)]
	public bool UnlimitedAmmo { get; set; } = false;
	
	[ContainerField(0x712), LayoutImmutable, Blittable, JsonProperty(Order = 1810)]
	public bool UnlimitedMags { get; set; } = false;
	
	[ContainerField(0x713), LayoutImmutable, Blittable, JsonProperty(Order = 1811)]
	public bool ForceZoom { get; set; } = false;
	
	[ContainerField(0x714), LayoutImmutable, Blittable, JsonProperty(Order = 1812)]
	public bool IsOwnedByAI { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		AimDir.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(PrimaryWeaponId);
		p_Writer.Write(SecondaryWeaponId);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultAimingController));
		p_Writer.WriteNullBytes(4);
		AnimatedWeaponBinding.Serialize(p_Writer, p_EbxWriter);
		Animated1pOnlyWeaponBinding.Serialize(p_Writer, p_EbxWriter);
		Animated3pOnlyWeaponBinding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(WeaponSkeleton));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AmmoClipIncreaseMultiplier);
		p_Writer.Write(GrenadeIncrease);
		p_Writer.Write(UnderslungGrenadeIncrease);
		p_Writer.Write(ExplosiveIncreaseMultiplier);
		p_Writer.Write(p_EbxWriter.WriteImport(DropWeaponPickup));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(UseExternalAimDir);
		p_Writer.Write(UnlimitedAmmo);
		p_Writer.Write(UnlimitedMags);
		p_Writer.Write(ForceZoom);
		p_Writer.Write(IsOwnedByAI);
		p_Writer.WriteNullBytes(11);
	}
}

