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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 72)]
public class UnlockAssetBase
	: fb.Entity.DataContainerPolicyAsset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<UnlockUserDataBase> UnlockUserData { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string DebugUnlockId { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint Identifier { get; set; } = 0;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint UnlockScore { get; set; } = 0;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<UnlockAssetBase> NextLevelUnlockAsset { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string PersistentStorageCode { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public UnlockAvailability AvailableForPlayer { get; set; } = UnlockAvailability.UnlockAvailability_All;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public bool AutoAvailable { get; set; } = false;
	
	[ContainerField(0x45), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
	public bool IgnoreAllUnlocked { get; set; } = false;
	
	[ContainerField(0x46), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
	public bool BypassLicenseCheckAllUnlocked { get; set; } = false;
	
	[ContainerField(0x47), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
	public bool HiddenInProgression { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(UnlockUserData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(DebugUnlockId));
		p_Writer.Write(Identifier);
		p_Writer.Write(UnlockScore);
		p_Writer.Write(p_EbxWriter.WriteImport(NextLevelUnlockAsset));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(PersistentStorageCode));
		p_Writer.Write((int) AvailableForPlayer);
		p_Writer.Write(AutoAvailable);
		p_Writer.Write(IgnoreAllUnlocked);
		p_Writer.Write(BypassLicenseCheckAllUnlocked);
		p_Writer.Write(HiddenInProgression);
	}
}

