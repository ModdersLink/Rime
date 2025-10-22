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

using fb.Audio;
using fb.Entity;
using fb.Core;

namespace fb.GameShared;

[ContainerType(16, 160)]
public class WarningSystemComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<SoundAsset> AimWarnSoundEffect { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<SoundAsset> MissileWarnSoundEffect { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public CtrRef<SoundAsset> LowHealthWarnSoundEffect { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<SoundAsset> LockingWarnSoundEffect { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<SoundAsset> LockedWarnSoundEffect { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public WarningPlayerType PlayerType { get; set; } = WarningPlayerType.WPTInflictor;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(AimWarnSoundEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MissileWarnSoundEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LowHealthWarnSoundEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LockingWarnSoundEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LockedWarnSoundEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) PlayerType);
		p_Writer.WriteNullBytes(4);
	}
}

