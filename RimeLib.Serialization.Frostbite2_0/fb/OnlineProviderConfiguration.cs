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
	[ContainerType(4, 28)]
	public class OnlineProviderConfiguration :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public GamePlatform Platform { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string Client { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string ServiceName { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string SKU { get; set; } = string.Empty;
		
		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string Version { get; set; } = string.Empty;
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint ServerSocketPacketSize { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public bool IsServer { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Platform);
			p_Writer.Write(p_EbxWriter.WriteString(Client));
			p_Writer.Write(p_EbxWriter.WriteString(ServiceName));
			p_Writer.Write(p_EbxWriter.WriteString(SKU));
			p_Writer.Write(p_EbxWriter.WriteString(Version));
			p_Writer.Write(ServerSocketPacketSize);
			p_Writer.Write(IsServer);
			p_Writer.WriteNullBytes(3);
		}
	}
}
