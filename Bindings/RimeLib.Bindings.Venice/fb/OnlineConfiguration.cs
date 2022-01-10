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
	[ContainerType(4, 28)]
	public class OnlineConfiguration : 
		Asset
	{
		[ContainerField(12)]
		public BackendType Backend { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<OnlineProviderAsset> Provider { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<RichPresenceData> RichPresence { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<ChatSettings> Chat { get; set; } = new();

		public static void Deserialize(OnlineConfiguration p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Backend = (BackendType) p_Reader.ReadInt32();
			p_Instance.Provider.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.RichPresence.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Chat.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
