///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 128)]
	public class WarningSystemComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<SoundAsset> AimWarnSoundEffect { get; set; } = new();

		[ContainerField(100)]
		public CtrRef<SoundAsset> MissileWarnSoundEffect { get; set; } = new();

		[ContainerField(104)]
		public CtrRef<SoundAsset> LowHealthWarnSoundEffect { get; set; } = new();

		[ContainerField(108)]
		public CtrRef<SoundAsset> LockingWarnSoundEffect { get; set; } = new();

		[ContainerField(112)]
		public CtrRef<SoundAsset> LockedWarnSoundEffect { get; set; } = new();

		[ContainerField(116)]
		public WarningPlayerType PlayerType { get; set; } = new();

	}
}
