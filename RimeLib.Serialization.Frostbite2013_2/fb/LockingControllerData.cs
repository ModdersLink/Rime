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

namespace fb.GameShared;

[ContainerType(8, 96)]
public class LockingControllerData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<ZoomLevelLockData> ZoomLevelLock { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float LockTime { get; set; } = 3.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float UnLockTime { get; set; } = -1.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float ReleaseTime { get; set; } = 5.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float ReleaseOnNewTargetTime { get; set; } = 1.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float SampleRate { get; set; } = 0.100f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float HoldStillThreshold { get; set; } = 10.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float CheckVisibilityLength { get; set; } = 1000.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float RayLength { get; set; } = 1000.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float AcceptanceAngle { get; set; } = 0.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float AngleConstant { get; set; } = 50.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float DistanceConstant { get; set; } = 50.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float Sensitivity { get; set; } = 0.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float MinimumLockTime { get; set; } = 0.000f;
	
	[ContainerField(0x4c), JsonProperty(Order = 76)]
	public LockingAndHomingData LockingWeaponData { get; set; } = new();
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public bool LockOnVisibleTargetsOnly { get; set; } = false;
	
	[ContainerField(0x59), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
	public bool RequireAmmoToLock { get; set; } = false;
	
	[ContainerField(0x5a), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
	public bool PositionOnly { get; set; } = false;
	
	[ContainerField(0x5b), LayoutImmutable, Blittable, JsonProperty(Order = 91)]
	public bool LockOnWorldSpacePos { get; set; } = false;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public bool LockOnEmptyVehicles { get; set; } = true;
	
	[ContainerField(0x5d), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
	public bool LockOnCharacters { get; set; } = false;
	
	[ContainerField(0x5e), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
	public bool IgnoreHeigthLockDistance { get; set; } = false;
	
	[ContainerField(0x5f), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
	public bool LockInCombatAreaOnly { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ZoomLevelLock = p_EbxWriter.GetArrayWriter(ZoomLevelLock.GetType(), ZoomLevelLock.Count);
		p_Writer.Write(s_ZoomLevelLock.ArrayIndex);
		foreach (var s_Entry in ZoomLevelLock)
		{
			s_Entry.Serialize(s_ZoomLevelLock.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(LockTime);
		p_Writer.Write(UnLockTime);
		p_Writer.Write(ReleaseTime);
		p_Writer.Write(ReleaseOnNewTargetTime);
		p_Writer.Write(SampleRate);
		p_Writer.Write(HoldStillThreshold);
		p_Writer.Write(CheckVisibilityLength);
		p_Writer.Write(RayLength);
		p_Writer.Write(AcceptanceAngle);
		p_Writer.Write(AngleConstant);
		p_Writer.Write(DistanceConstant);
		p_Writer.Write(Sensitivity);
		p_Writer.Write(MinimumLockTime);
		LockingWeaponData.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LockOnVisibleTargetsOnly);
		p_Writer.Write(RequireAmmoToLock);
		p_Writer.Write(PositionOnly);
		p_Writer.Write(LockOnWorldSpacePos);
		p_Writer.Write(LockOnEmptyVehicles);
		p_Writer.Write(LockOnCharacters);
		p_Writer.Write(IgnoreHeigthLockDistance);
		p_Writer.Write(LockInCombatAreaOnly);
	}
}

