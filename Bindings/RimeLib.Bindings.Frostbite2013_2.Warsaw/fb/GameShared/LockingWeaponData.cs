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

[ContainerType(8, 64)]
public class LockingWeaponData
	: fb.GameShared.WeaponData
{
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<LockingControllerData> LockingController { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<LockingControllerData> SecondaryLockingController { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public WarnTarget WarnLock { get; set; } = WarnTarget.wtWarnNone;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool OverrideLockingControllerSettings { get; set; } = true;
	
	[ContainerField(0x35), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
	public bool IsHoming { get; set; } = true;
	
	[ContainerField(0x36), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
	public bool IsGuided { get; set; } = false;
	
	[ContainerField(0x37), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
	public bool IsGuidedWhenZoomed { get; set; } = false;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool IsGuidedHoming { get; set; } = false;
	
	[ContainerField(0x39), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
	public bool FireOnlyWhenLockedOn { get; set; } = false;
	
	[ContainerField(0x3a), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
	public bool GuideOnlyWhenLockedOn { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(LockingController));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SecondaryLockingController));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) WarnLock);
		p_Writer.Write(OverrideLockingControllerSettings);
		p_Writer.Write(IsHoming);
		p_Writer.Write(IsGuided);
		p_Writer.Write(IsGuidedWhenZoomed);
		p_Writer.Write(IsGuidedHoming);
		p_Writer.Write(FireOnlyWhenLockedOn);
		p_Writer.Write(GuideOnlyWhenLockedOn);
		p_Writer.WriteNullBytes(5);
	}
}

