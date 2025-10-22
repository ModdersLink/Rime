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

[ContainerType(16, 304)]
public class SoldierEntryComponentData
	: fb.GameShared.CharacterEntryComponentData
{
	public SoldierEntryComponentData()
	{
		//EntryComponentData
		ShowSoldierWeaponInEntry = true;
		LockSoldierAimingToEntry = false;
	}
	
	[ContainerField(0x100), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public Vec3 AnimationAccelerationMultiplier { get; set; } = new()
	{
		z = 0.100f,
		y = 0.100f,
		x = 0.100f,
	};
	
	[ContainerField(0x110), JsonProperty(Order = 272)]
	public CtrRef<AntEnumeration> AntEntryEnumeration { get; set; } = new();
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public AimingWorldSpaceLockEfficiencyData WorldSpaceLockEfficiency { get; set; } = new();
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public bool LeaveSoldierInPlace { get; set; } = false;
	
	[ContainerField(0x129), LayoutImmutable, Blittable, JsonProperty(Order = 297)]
	public bool ClampSoldierOffsetToBoundingBox { get; set; } = false;
	
	[ContainerField(0x12a), LayoutImmutable, Blittable, JsonProperty(Order = 298)]
	public bool ClampSoldierYOffsetToFloor { get; set; } = false;
	
	[ContainerField(0x12b), LayoutImmutable, Blittable, JsonProperty(Order = 299)]
	public bool HideVehicleHud { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		AnimationAccelerationMultiplier.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(AntEntryEnumeration));
		p_Writer.WriteNullBytes(4);
		WorldSpaceLockEfficiency.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LeaveSoldierInPlace);
		p_Writer.Write(ClampSoldierOffsetToBoundingBox);
		p_Writer.Write(ClampSoldierYOffsetToFloor);
		p_Writer.Write(HideVehicleHud);
		p_Writer.WriteNullBytes(4);
	}
}

