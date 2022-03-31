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
	[ContainerType(4, 20)]
	public class OnlinePlatformConfiguration :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public GamePlatform Platform { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public CtrRef<OnlineServicesAsset> Services { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public RefArray<PresenceBackendData> ClientBackends { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<ServerBackendData> ServerBackends { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool IsFallback { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Platform);
			p_Writer.Write(p_EbxWriter.WriteImport(Services));
			(RimeWriter Writer, uint ArrayIndex) s_ClientBackends = p_EbxWriter.GetArrayWriter(ClientBackends.GetType(), ClientBackends.Count);
			p_Writer.Write(s_ClientBackends.ArrayIndex);
			foreach (var s_Entry in ClientBackends)
			{
				s_ClientBackends.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_ServerBackends = p_EbxWriter.GetArrayWriter(ServerBackends.GetType(), ServerBackends.Count);
			p_Writer.Write(s_ServerBackends.ArrayIndex);
			foreach (var s_Entry in ServerBackends)
			{
				s_ServerBackends.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(IsFallback);
			p_Writer.WriteNullBytes(3);
		}
	}
}
