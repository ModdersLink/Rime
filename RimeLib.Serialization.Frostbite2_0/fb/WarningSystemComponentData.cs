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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 128)]
	public class WarningSystemComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public CtrRef<SoundAsset> AimWarnSoundEffect { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public CtrRef<SoundAsset> MissileWarnSoundEffect { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public CtrRef<SoundAsset> LowHealthWarnSoundEffect { get; set; } = new();

		[ContainerField(108), JsonProperty(Order = 108)]
		public CtrRef<SoundAsset> LockingWarnSoundEffect { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public CtrRef<SoundAsset> LockedWarnSoundEffect { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public WarningPlayerType PlayerType { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(AimWarnSoundEffect));
			p_Writer.Write(p_EbxWriter.WriteImport(MissileWarnSoundEffect));
			p_Writer.Write(p_EbxWriter.WriteImport(LowHealthWarnSoundEffect));
			p_Writer.Write(p_EbxWriter.WriteImport(LockingWarnSoundEffect));
			p_Writer.Write(p_EbxWriter.WriteImport(LockedWarnSoundEffect));
			p_Writer.Write((int) PlayerType);
			p_Writer.WriteNullBytes(8);
		}
	}
}
