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
	[ContainerType(4, 28)]
	public class OnlineConfiguration :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public BackendType Backend { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<OnlineProviderAsset> Provider { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<RichPresenceData> RichPresence { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<ChatSettings> Chat { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Backend);
			p_Writer.Write(p_EbxWriter.WriteImport(Provider));
			p_Writer.Write(p_EbxWriter.WriteImport(RichPresence));
			p_Writer.Write(p_EbxWriter.WriteImport(Chat));
		}
	}
}
