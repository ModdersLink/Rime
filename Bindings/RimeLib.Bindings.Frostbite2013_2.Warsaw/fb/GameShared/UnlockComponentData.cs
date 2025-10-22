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

[ContainerType(16, 160)]
public class UnlockComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UnlockAssetBase> UnlockAsset { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public GUID UnlockAssetGuid { get; set; } = GUID.Empty;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public uint UnlockIdentifier { get; set; } = 0;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public uint UnlockDataKey { get; set; } = 0;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public bool InvertUnlockTest { get; set; } = false;
	
	[ContainerField(0x91), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
	public bool UnlockableFromAllEntries { get; set; } = false;
	
	[ContainerField(0x92), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
	public bool DeactivateCheckOnEnteringEntry { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(UnlockAsset));
		p_Writer.WriteNullBytes(4);
		UnlockAssetGuid.Serialize(p_Writer);
		p_Writer.Write(UnlockIdentifier);
		p_Writer.Write(UnlockDataKey);
		p_Writer.Write(InvertUnlockTest);
		p_Writer.Write(UnlockableFromAllEntries);
		p_Writer.Write(DeactivateCheckOnEnteringEntry);
		p_Writer.WriteNullBytes(13);
	}
}

