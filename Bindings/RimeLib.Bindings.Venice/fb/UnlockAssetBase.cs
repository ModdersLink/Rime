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
	[ContainerType(4, 40)]
	public class UnlockAssetBase : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint UnlockScore { get; set; }

		[ContainerField(16)]
		public CtrRef<UnlockUserDataBase> UnlockUserData { get; set; } = new();

		[ContainerField(20), LayoutImmutable]
		public string DebugUnlockId { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint Identifier { get; set; }

		[ContainerField(28)]
		public UnlockAvailability AvailableForPlayer { get; set; } = new();

		[ContainerField(32)]
		public CtrRef<UnlockAssetBase> NextLevelUnlockAsset { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool AutoAvailable { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable]
		public bool HiddenInProgression { get; set; }

		public static void Deserialize(UnlockAssetBase p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UnlockScore = p_Reader.ReadUInt32();
			p_Instance.UnlockUserData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DebugUnlockId = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Identifier = p_Reader.ReadUInt32();
			p_Instance.AvailableForPlayer = (UnlockAvailability) p_Reader.ReadInt32();
			p_Instance.NextLevelUnlockAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AutoAvailable = p_Reader.ReadBool();
			p_Instance.HiddenInProgression = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
