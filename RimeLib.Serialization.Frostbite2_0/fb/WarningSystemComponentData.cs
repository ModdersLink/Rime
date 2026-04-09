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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 128)]
	public partial class WarningSystemComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private CtrRef<SoundAsset> _AimWarnSoundEffect = new();

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private CtrRef<SoundAsset> _MissileWarnSoundEffect = new();

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private CtrRef<SoundAsset> _LowHealthWarnSoundEffect = new();

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private CtrRef<SoundAsset> _LockingWarnSoundEffect = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private CtrRef<SoundAsset> _LockedWarnSoundEffect = new();

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private WarningPlayerType _PlayerType = new();

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
