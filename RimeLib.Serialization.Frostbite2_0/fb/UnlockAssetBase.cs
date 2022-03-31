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

namespace fb
{
	[ContainerType(4, 40)]
	public class UnlockAssetBase :
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint UnlockScore { get; set; }

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<UnlockUserDataBase> UnlockUserData { get; set; } = new();

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string DebugUnlockId { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint Identifier { get; set; }

		[ContainerField(28), JsonProperty(Order = 28)]
		public UnlockAvailability AvailableForPlayer { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<UnlockAssetBase> NextLevelUnlockAsset { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool AutoAvailable { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		public bool HiddenInProgression { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(UnlockScore);
			p_Writer.Write(p_EbxWriter.WriteImport(UnlockUserData));
			p_Writer.Write(p_EbxWriter.WriteString(DebugUnlockId));
			p_Writer.Write(Identifier);
			p_Writer.Write((int) AvailableForPlayer);
			p_Writer.Write(p_EbxWriter.WriteImport(NextLevelUnlockAsset));
			p_Writer.Write(AutoAvailable);
			p_Writer.Write(HiddenInProgression);
			p_Writer.WriteNullBytes(2);
		}
	}
}
