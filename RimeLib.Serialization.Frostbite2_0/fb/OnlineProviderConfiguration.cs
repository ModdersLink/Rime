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
	[ContainerType(4, 28)]
	public partial class OnlineProviderConfiguration :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private GamePlatform _Platform = new();
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		private string _Client = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _ServiceName = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _SKU = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		private string _Version = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _ServerSocketPacketSize;
		
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _IsServer;
		
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
