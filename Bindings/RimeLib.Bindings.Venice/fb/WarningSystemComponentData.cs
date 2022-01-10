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

		public static void Deserialize(WarningSystemComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.AimWarnSoundEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MissileWarnSoundEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.LowHealthWarnSoundEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.LockingWarnSoundEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.LockedWarnSoundEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.PlayerType = (WarningPlayerType) p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
